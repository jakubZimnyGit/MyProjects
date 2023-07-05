using DotNetTest.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Net.Security;

namespace DotNetTest.Pages.Contacts
{
    public class EditModel : PageModel
    {
        public Contact ContactInfo = new Contact();     
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()         // Pobieramy informacje o konkretnym kontakcie i wyœwietlamy na stronie (Edit.html).
        {
            String id = Request.Query["Id"];  

            try
            {
                String connectionString = "Data Source=DESKTOP-25Q87GI;Initial Catalog=ContactsDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Contacts WHERE Id=@Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ContactInfo.Id = "" + reader.GetInt32(0);
                                ContactInfo.Name = reader.GetString(1);
                                ContactInfo.LastName = reader.GetString(2);
                                ContactInfo.Email = reader.GetString(3);
                                ContactInfo.PhoneNumber = reader.GetString(4);
                                ContactInfo.Category = reader.GetString(5);
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }

        public void OnPost()    // Pobieramy podane przez u¿ytkownika informacje i za pomoc¹ poni¿szej komendy (sql = ...) przypisujemy do kontaktu o danym
        {                               // id, informacje zebrane z "Form", które wpisa³ u¿ytkownik
            ContactInfo.Id = Request.Form["Id"];
            ContactInfo.Name = Request.Form["Name"];
            ContactInfo.LastName = Request.Form["LastName"];
            ContactInfo.Email = Request.Form["Email"];                      // Ta metoda jest bardzo podobna do dodawania nowego kontaktu, 
            ContactInfo.PhoneNumber = Request.Form["PhoneNumber"];          // ró¿ni siê tym ¿e nie dodajemy nowego rekordu, a edytujemy (UPDATE *nazwa tabeli SET...
            ContactInfo.Category = Request.Form["Category"];                    //WHERE...id=@id)

            if (ContactInfo.Name.Length == 0 || ContactInfo.Email.Length == 0 ||
                ContactInfo.LastName.Length == 0 || ContactInfo.PhoneNumber.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            try
            {
                String connectionString = "Data Source=DESKTOP-25Q87GI;Initial Catalog=ContactsDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "UPDATE Contacts " +
                                 "SET name=@name, LastName=@LastName, Email=@Email, PhoneNumber=@PhoneNumber, Category=@Category " +
                                 "WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", ContactInfo.Name);
                        command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
                        command.Parameters.AddWithValue("@Email", ContactInfo.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", ContactInfo.PhoneNumber);
                        command.Parameters.AddWithValue("@Category", ContactInfo.Category);
                        command.Parameters.AddWithValue("@id", ContactInfo.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            Response.Redirect("/Contacts");
        }
    }
}
