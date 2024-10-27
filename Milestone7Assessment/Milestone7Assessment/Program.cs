using System;
using System.Net;
using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint.Client;


namespace Milestone7Assessment
{
    internal class Program
    {
        private static void Main1(string[] args)
        {
            string tenantUrl = "https://yourtenant.sharepoint.com/sites/yoursite"; // Your SharePoint site URL
            string clientId = "YOUR_CLIENT_ID"; // Your Azure AD App client ID
            string clientSecret = "YOUR_CLIENT_SECRET"; // Your Azure AD App client secret
            string documentLibraryName = "Documents"; // Name of your document library
            string tenantId = "TENANT ID";

            // Authenticate using client credentials
            using (var context = new ClientContext(tenantUrl))
            {
                var authManager = new AuthenticationManager();
                context.ExecutingWebRequest += (s, e) =>
                {
                    e.WebRequestExecutor.RequestHeaders["Authorization"] = "Bearer " + authManager.GetAccessToken(clientId, clientSecret, tenantUrl, tenantId);
                };

                // Load the document library
                List documentLibrary = context.Web.Lists.GetByTitle(documentLibraryName);
                CamlQuery query = CamlQuery.CreateAllItemsQuery();
                ListItemCollection items = documentLibrary.GetItems(query);
                context.Load(items);
                context.ExecuteQuery();

                // Output the document names
                Console.WriteLine("Documents in the library:");
                foreach (ListItem item in items)
                {
                    if (item.FileSystemObjectType == FileSystemObjectType.File)
                    {
                        Console.WriteLine($"- {item["FileLeafRef"]}");
                    }
                }
            }
        }
    }

    public class AuthenticationManager
    {
        public string GetAccessToken(string clientId, string clientSecret, string tenantUrl, string tenantId)
        {
            var authorityUrl = $"https://accounts.accesscontrol.windows.net/tenantId/tokens/OAuth/2";
            var resource =  tenantUrl+ "/";
            var clientCredential = new System.Net.NetworkCredential(clientId, clientSecret);

            using (var client = new System.Net.Http.HttpClient())
            {
                var requestBody = new System.Collections.Generic.Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" },
                    { "client_id", clientId },
                    { "client_secret", clientSecret },
                    { "resource", resource }
                };

                var response = client.PostAsync(authorityUrl, new FormUrlEncodedContent(requestBody)).Result;
                response.EnsureSuccessStatusCode();

                var responseBody = response.Content.ReadAsStringAsync().Result;
                dynamic tokenResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                return tokenResponse.access_token;
            }
        }
    }
}