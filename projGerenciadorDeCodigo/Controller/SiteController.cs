using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projGerenciadorDeCodigo.Controller
{
    class SiteController
    {
        List<string> fileNames = new List<string>();
        ProgressBar ProgressBar;
        string Uri;
        string Url;
        public SiteController(string uri, string url, ProgressBar progressBar)
        {
            var files = Directory.GetFiles(uri, "*.html");

            ProgressBar = progressBar;
            ProgressBar.Maximum = files.Length;
            ProgressBar.Minimum = 0;
            ProgressBar.Step = 1;
            ProgressBar.Value = 0;

            Uri = uri;
            Url = url;

            foreach (string file in files) 
            {
                fileNames.Add(Path.GetFileName(file)); 
            }
        }

        public void SetChanges(bool canonical, bool mobirise, bool google, bool sitemap)
        {
            foreach(var file in fileNames)
            {
                if (file != "google8e97f3aebffc65ea.html")
                {
                    if (canonical) AddCanonicalTag(file);
                    if (mobirise) RemoveMobiriseWaterMark(file);
                    if (google) AddGoogleVerification();
                }
                ProgressBar.PerformStep();
            }

            if (sitemap) AddSitemap();

            ProgressBar.Value = 0;
            MessageBox.Show("Páginas modificadas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AddCanonicalTag(string fileName)
        {
            string content = File.ReadAllText(Uri + @"\" + fileName);
            string tag = "<link rel=\"canonical\" href=\"" + Url + "/" + fileName + "/" + "\" " + ">";
            content = content.Replace("<head>", "<head>\n  " + tag);
            File.WriteAllText(Uri + @"\" + fileName, content);
        }

        private void RemoveMobiriseWaterMark(string fileName)
        {
            string content = File.ReadAllText(Uri + @"\" + fileName);
            int indiceInicial = content.IndexOf("<section class=\"display-7\"");
            int indiceFinal = content.LastIndexOf("</a></section>") + "</a></section>".Length;

            string substring = content.Substring(indiceInicial, indiceFinal - indiceInicial);

            string tag = "<section class=\"display-7\">\r\n\t<a href=\"https://mobiri.se/2909436\">\r\n\t<p class=\"display-7\" style=\"display: none;\">Made with &#8204;</p>\r\n\t<a style=\"display: none;\" href=\"https://mobirise.com\"> Website Building Software</a>\r\n</section>";

            content = content.Replace(substring, tag);
            File.WriteAllText(Uri + @"\" + fileName, content);
        }

        private void AddGoogleVerification()
        {
            string content = "google-site-verification: google8e97f3aebffc65ea.html";
            File.WriteAllText(Uri + @"\" + "google8e97f3aebffc65ea.html", content);
        }

        private void AddSitemap()
        {
            string content = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<urlset\r\n" +
                "      xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\"\r\n      " +
                "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"\r\n      " +
                "xsi:schemaLocation=\"http://www.sitemaps.org/schemas/sitemap/0.9\r\n            " +
                "http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd\">\r\n" +
                "<!-- criado por enrique -->\r\n\r\n";

            foreach(var file in fileNames)
            {
                content += $"<url>\r\n  <loc>{Url}/{file}/</loc>\r\n  " +
                "<lastmod>2023-03-13T01:24:33+00:00</lastmod>\r\n  " +
                "<priority>1.00</priority>\r\n</url>";
            }

            content += "\r\n</urlset>";
            File.WriteAllText(Uri + @"\" + "sitemap.xml", content);
        }
    }
}
