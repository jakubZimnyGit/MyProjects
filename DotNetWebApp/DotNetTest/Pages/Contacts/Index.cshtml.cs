using Dapper;
using DotNetTest.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Data.SqlClient;


namespace DotNetTest.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        public List<Contact> ContactsList = new List<Contact>();        //U¿y³em metody GetContacts, aby do listy ContacsList dodaæ wszystkie kontakty z bazy danych
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
        public List<Contact> GetContacts()  // W tej funkcji u¿y³em procedury, aby "Wybraæ" potrzebne informacje z tabeli "Contacts" (SELECT*)
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
