using System;
using Microsoft.SharePoint.Client;

namespace Milestone7Assessment
{
    internal class _5O365App
    {
        static void Main5(string[] args)
        {
            string tenantUrl = "https://yourtenant.sharepoint.com/sites/yoursite"; // Your SharePoint site URL
            string clientId = "YOUR_CLIENT_ID"; // Your Azure AD App client ID
            string clientSecret = "YOUR_CLIENT_SECRET"; // Your Azure AD App client secret
            string listName = "YourListName"; // Name of your SharePoint list
            string tenantId = "TENANT ID";

            // Authenticate and retrieve list data
            using (var context = new ClientContext(tenantUrl))
            {
                var authManager = new AuthenticationManager();
                context.ExecutingWebRequest += (s, e) =>
                {
                    e.WebRequestExecutor.RequestHeaders["Authorization"] = "Bearer " + authManager.GetAccessToken(clientId, clientSecret, tenantUrl, tenantId);
                };

                // Load the SharePoint list
                List list = context.Web.Lists.GetByTitle(listName);
                CamlQuery query = CamlQuery.CreateAllItemsQuery();
                ListItemCollection items = list.GetItems(query);
                context.Load(items);
                context.ExecuteQuery();

                // Output the list items
                Console.WriteLine($"Items in the list '{listName}':");
                foreach (ListItem item in items)
                {
                    Console.WriteLine($"ID: {item.Id}, Title: {item["Title"]}"); // Adjust field names as necessary
                }
            }
        }
    }
}
