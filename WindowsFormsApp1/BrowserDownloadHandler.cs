using CefSharp;
using System;
using System.IO;

namespace WindowsFormsApp1
{
    public class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public DownloadHandler()
        {
        }

        public bool CanDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, string mimeType, string fileName)
        {
            // Return true if you want to allow the download, otherwise false
            return true;
        }

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            if (!callback.IsDisposed)
            {
                var suggestedFileName = downloadItem.SuggestedFileName;

                // You can modify the suggested file name if needed
                // For example, you can change the file download location
                var filePath = Path.Combine(@"C:\Downloads", suggestedFileName);

                using (callback)
                {
                    callback.Continue(filePath, showDialog: false);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            // Handle download progress or completion here if needed
        }
    }
}
