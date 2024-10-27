using System;
using System.IO;
using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint.Client;

namespace Milestone7Assessment
{
    internal class _2FileUpload
    {
        private static void Main2(string[] args)
        {
            string tenantUrl = "https://yourtenant.sharepoint.com/sites/yoursite"; // Your SharePoint site URL
            string clientId = "YOUR_CLIENT_ID"; // Your Azure AD App client ID
            string clientSecret = "YOUR_CLIENT_SECRET"; // Your Azure AD App client secret
            string documentLibraryName = "Documents"; // Name of your document library
            string filePath = @"C:\path\to\yourfile.docx"; // Path to the file you want to upload
            string tenantId = "TENANT ID";

            // Authenticate and upload the document
            using (var context = new ClientContext(tenantUrl))
            {
                var authManager = new AuthenticationManager();
                context.ExecutingWebRequest += (s, e) =>
                {
                    e.WebRequestExecutor.RequestHeaders["Authorization"] = "Bearer " + authManager.GetAccessToken(clientId, clientSecret, tenantUrl, tenantId);
                };

                // Upload the file
                UploadFile(context, documentLibraryName, filePath);
            }
        }

        private static void UploadFile(ClientContext context, string documentLibraryName, string filePath)
        {
            // Get the document library
            List documentLibrary = context.Web.Lists.GetByTitle(documentLibraryName);
            context.Load(documentLibrary);
            context.ExecuteQuery();

            // Read the file content
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                var fileInfo = new FileInfo(filePath);
                var fileCreationInfo = new FileCreationInformation
                {
                    ContentStream = fs,
                    Url = fileInfo.Name,
                    Overwrite = true
                };

                Microsoft.SharePoint.Client.File uploadFile = documentLibrary.RootFolder.Files.Add(fileCreationInfo);
                context.Load(uploadFile);
                context.ExecuteQuery();

                Console.WriteLine($"File uploaded successfully: {uploadFile.ServerRelativeUrl}");
            }
        }
    }
}
