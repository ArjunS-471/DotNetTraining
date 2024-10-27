using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using Microsoft.SharePoint.Client;

namespace Milestone7Assessment
{
    internal class _6SharePointListUpdate
    {
        static void Main6(string[] args)
        {
            string tenantUrl = "https://yourtenant.sharepoint.com/sites/yoursite"; // Your SharePoint site URL
            string clientId = "YOUR_CLIENT_ID"; // Your Azure AD App client ID
            string clientSecret = "YOUR_CLIENT_SECRET"; // Your Azure AD App client secret
            string listName = "YourListName"; // Name of your SharePoint list
            string tenantId = "TENANT ID";

            // Authenticate and update list item
            using (var context = new ClientContext(tenantUrl))
            {
                var authManager = new AuthenticationManager();
                context.ExecutingWebRequest += (s, e) =>
                {
                    e.WebRequestExecutor.RequestHeaders["Authorization"] = "Bearer " + authManager.GetAccessToken(clientId, clientSecret, tenantUrl, tenantId);
                };

                // Get item ID to update
                Console.Write("Enter the ID of the item you want to update: ");
                int itemId = int.Parse(Console.ReadLine());

                // Load the SharePoint list
                Microsoft.SharePoint.Client.List list = context.Web.Lists.GetByTitle(listName);
                Microsoft.SharePoint.Client.ListItem item = list.GetItemById(itemId);
                context.Load(item);
                context.ExecuteQuery();

                // Get new value from user
                Console.Write("Enter the new value for the Title field: ");
                string newTitle = Console.ReadLine();

                // Update the item
                item["Title"] = newTitle;
                item.Update();
                context.ExecuteQuery();

                Console.WriteLine($"Item with ID {itemId} updated successfully.");
            }
        }
    }
}
