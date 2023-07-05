using DotNetTest.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace DotNetTest.Pages.Contacts
{
    public class IndexNotLoggedModel : PageModel
    {
        public List<Contact> ContactsList = new List<Contact>();
        public void OnGet()
        {
            try
            {
                ContactsList = GetContacts();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.ToString());
            }

        }
        public List<Contact> GetContacts()
        {
            String connectionString = "Data Source=DESKTOP-25Q87GI;Initial Catalog=ContactsDB;Integrated Security=True";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var output = connection.Query<Contact>("dbo.spContactsGetAll").ToList();
                return output;
            }
        }
    }
}
