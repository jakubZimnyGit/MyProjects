using DotNetTest.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace DotNetTest.Pages.Contacts
{
    public class CreateModel : PageModel
    {
        public Contact ContactInfo = new Contact();     // Tworze obiekt przechowuj¹cy informacje podane przez uzytkownika, aby móc go póŸniej dodaæ do bazy danych
        public String errorMessage = "";    // Wiadomoœæ wyœwietlana w przypadku "B³edu" np. nie uzupe³nienia niezbêdnych pól przez u¿ytkownika
        public String succesMessage = "";   // Wiadomoœæ wyœwietlana, po pomyœlnym zakoñczeniu procesu
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            ContactInfo.Name = Request.Form["Name"];    // Z obecnych na stronie "Form" pobieram informacje podane przez u¿ytkownika i przypisuje owe wartoœci
            ContactInfo.LastName = Request.Form["LastName"];   // do stworzonego wczeœniej obiektu
            ContactInfo.Email = Request.Form["Email"];
            ContactInfo.PhoneNumber = Request.Form["PhoneNumber"];
            ContactInfo.Category = Request.Form["Category"];


            if (ContactInfo.Name.Length == 0 || ContactInfo.Email.Length == 0 ||            //Je¿eli jedno z pól nie zosta³o wype³nione,  
                ContactInfo.LastName.Length == 0 || ContactInfo.PhoneNumber.Length == 0)   // Zmieniamy wartoœæ "errorMessage" i zwracamy zakañczamy w tym momencie
            {                                                                               //funkcje OnPost, wyœwietlaj¹c ow¹ wiadomoœæ
                errorMessage = "All the fields are required";
                return;
            }

            // Zapisywanie nowego kontaktu
            try
            {
                String connectionString = "Data Source=DESKTOP-25Q87GI;Initial Catalog=ContactsDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();                  //SQL Query
                    String sql = "INSERT INTO Contacts " +
                                 "(name, LastName, Email, PhoneNumber, Category) VALUES " +
                                 "(@name, @LastName, @Email, @PhoneNumber, @Category);";

                    using (SqlCommand command = new SqlCommand(sql, connection))  
                    {
                        command.Parameters.AddWithValue("@name", ContactInfo.Name);         // Wykonuje podan¹ wy¿ej komende z odpowienimi wartoœciami, które
                        command.Parameters.AddWithValue("@LastName", ContactInfo.LastName); // chce przypisaæ do konkretnych kolumn w bazie danych
                        command.Parameters.AddWithValue("@Email", ContactInfo.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", ContactInfo.PhoneNumber);
                        command.Parameters.AddWithValue("@Category", ContactInfo.Category);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }
            ContactInfo.Name = ""; ContactInfo.Email = ""; ContactInfo.LastName = ""; ContactInfo.PhoneNumber = "";
            succesMessage = "New Contact Added Correctly";  // Jezeli wczesniej nie wyst¹pi³ b³¹d, to wyœwietlam wiadomoœæ o pozytywnym zakoñczeniu procesu 

            Response.Redirect("/Contacts/Index");  // Przekierowuje na stronie z kontaktami
        }
    }
}
