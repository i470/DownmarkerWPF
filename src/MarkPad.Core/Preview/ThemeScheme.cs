using System;
using System.IO;
using System.Linq;
using CefSharp;
using CefSharp.Callback;

namespace MarkPad.Preview
{
    public class ThemeSchemeHandlerFactory : ISchemeHandlerFactory
    {
        //public ISchemeHandler Create()
        //{
        //    return new ThemeSchemeHandler();
        //}

        public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request)
        {
            //string resource;

            //var uri = new Uri(request.Url);
            //var segments = uri.Segments;

            //var path = Path.Combine(HtmlPreview.BaseDirectory,
            //    string.Concat(uri.Segments.Skip(1).Select(p => p.Replace('/', '\\'))));

            //var file = new FileInfo(path);
            //var extension = Path.GetExtension(file);

            //if (file.Exists)
            //{
            //    response.ResponseStream = file.OpenRead();
            //    response.MimeType = "text/html";
            

            //    return ResourceHandler.FromString(resource, extension);
            //}

            //return null;

            
            var uri = new Uri(request.Url);
            var fileName = uri.AbsolutePath;
            var extension = Path.GetExtension(fileName);

            string resource;
            if (ResourceDictionary.TryGetValue(fileName, out resource) && !string.IsNullOrEmpty(resource))
            {
                //For css/js/etc it's important to specify a mime/type, here we use the file extension to perform a lookup
                //there are overloads where you can specify more options including Encoding, mimeType
                return ResourceHandler.FromString(resource, extension);
            }

            return null;
        }
    }


}