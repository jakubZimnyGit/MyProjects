using DotNetTest.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace DotNetTest.Pages.Contacts
{
    public class CreateModel : PageModel
    {
        public Contact ContactInfo = new Contact();     // Tworze obiekt przechowuj�cy informacje podane przez uzytkownika, aby m�c go p�niej doda� do bazy danych
        public String errorMessage = "";    // Wiadomo�� wy�wietlana w przypadku "B�edu" np. nie uzupe�nienia niezb�dnych p�l przez u�ytkownika
        public String succesMessage = "";   // Wiadomo�� wy�wietlana, po pomy�lnym zako�czeniu procesu
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            ContactInfo.Name = Request.Form["Name"];    // Z obecnych na stronie "Form" pobieram informacje podane przez u�ytkownika i przypisuje owe warto�ci
            ContactInfo.LastName = Request.Form["LastName"];   // do stworzonego wcze�niej obiektu
            ContactInfo.Email = Request.Form["Email"];
            ContactInfo.PhoneNumber = Request.Form["PhoneNumber"];
            ContactInfo.Category = Request.Form["Category"];


            if (ContactInfo.Name.Length == 0 || ContactInfo.Email.Length == 0 ||            //Je�eli jedno z p�l nie zosta�o wype�nione,  
                ContactInfo.LastName.Length == 0 || ContactInfo.PhoneNumber.Length == 0)   // Zmieniamy warto�� "errorMessage" i zwracamy zaka�czamy w tym momencie
            {                                                                               //funkcje OnPost, wy�wietlaj�c ow� wiadomo��
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
                        command.Parameters.AddWithValue("@name", ContactInfo.Name);         // Wykonuje podan� wy�ej komende z odpowienimi warto�ciami, kt�re
                        command.Parameters.AddWithValue("@LastName", ContactInfo.LastName); // chce przypisa� do konkretnych kolumn w bazie danych
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
            succesMessage = "New Contact Added Correctly";  // Jezeli wczesniej nie wyst�pi� b��d, to wy�wietlam wiadomo�� o pozytywnym zako�czeniu procesu 

            Response.Redirect("/Contacts/Index");  // Przekierowuje na stronie z kontaktami
        }
    }
}
