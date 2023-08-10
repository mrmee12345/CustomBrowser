using System;
using System.IO;
using CefSharp;
using CefSharp.WinForms;

public class BrowserDownloadHandler : IDownloadHandler
{
    public event EventHandler<DownloadItem> OnBeforeDownloadFired;

    public bool CanDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, string mimeType, string fileName)
    {
        return true; // Return true to allow downloads
    }

    public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
    {
        OnBeforeDownloadFired?.Invoke(this, downloadItem);
        if (!callback.IsDisposed)
        {
            string suggestedFileName = downloadItem.SuggestedFileName;
            string downloadPath = Path.Combine("C:\\Downloads", suggestedFileName);
            callback.Continue(downloadPath, showDialog: false);
        }
    }

    public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
    {
        // Handle download progress updates if needed
        // This method can be empty if you don't need to track progress
    }
}
