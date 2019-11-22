using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace ExcelImageReader.Model
{
    public class ImageWriter
    {
        private const String MESSAGE_WRONG_LOCATORS = "Wrong data specified - url = {0}, name = {1}, extension = {2}";
        private const String MESSAGE_WRONG_URI_PATTERN = "Wrong URI specified - {0}";

        private string destinationPath;
        private WebClient webClient;

        public ImageWriter(string destinationPath)
        {
            this.destinationPath = destinationPath;

            this.webClient = new WebClient();
        }

        public void Write(ImageData imageData)
        {
            Image image = imageData.GetImage();

            string fileName = imageData.GetName() + "." + imageData.GetExtension();
            fileName = Path.Combine(destinationPath, fileName);

            image.Save(fileName);
        }

        public void Write(ImageLocators imageLocators)
        {
            checkLocators(imageLocators);
            checkURI(imageLocators.GetUrl());

            string fileName = imageLocators.GetName() + "." + imageLocators.GetExtension();
            fileName = Path.Combine(destinationPath, fileName);

            webClient.DownloadFile(imageLocators.GetUrl(), fileName);
        }

        private void checkLocators(ImageLocators imageLocators)
        {
            string url = imageLocators.GetUrl();
            string name = imageLocators.GetName();
            string extension = imageLocators.GetExtension();

            if (String.IsNullOrWhiteSpace(url) || String.IsNullOrWhiteSpace(name))
                throw new Exception(String.Format(MESSAGE_WRONG_LOCATORS, url, name, extension));
        }

        private void checkURI(String uriString)
        {
            Uri uriResult;

            bool result = Uri.TryCreate(uriString, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (!result)
                throw new Exception(String.Format(MESSAGE_WRONG_URI_PATTERN, uriString));
        }
    }
}
