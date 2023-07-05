using DotNetTest.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DotNetTest.Pages.UserPanel
{
    public class SignUpModel : PageModel
    {
        public User UserInfo = new User();
        public String errorMessage = "";
        public String succesMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            UserInfo.Username = Request.Form["Username"];
            UserInfo.Email = Request.Form["Email"];
            UserInfo.Password = Request.Form["Password"];

            if (UserInfo.Username.Length == 0 || UserInfo.Email.Length == 0 ||
                UserInfo.Password.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            if (CheckDataPatern(UserInfo))
            {
                succesMessage = "Singed Up Successfully";
                Response.Redirect("/UserPanel/Login");
            }
            else
            {
                return;
            }


            //save new user
            try
            {
                String connectionString = "Data Source=DESKTOP-25Q87GI;Initial Catalog=ContactsDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO Users " +
                                 "(Username, Email, Password) VALUES " +
                                 "(@Username, @Email, @Password);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", UserInfo.Username);
                        command.Parameters.AddWithValue("@Email", UserInfo.Email);
                        command.Parameters.AddWithValue("@Password", UserInfo.Password);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }
            UserInfo.Username = ""; UserInfo.Email = ""; UserInfo.Password = "";
            
            
        }

        private bool CheckDataPatern(User user)
        {
            Regex emailRegex = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            Regex passwordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (!passwordRegex.IsMatch(user.Password))
            {
                errorMessage = "Password must have atleast: One Uppercase letter, One Lowercase letter, One special character, 8 characters";
                return false;
            }
            if (!emailRegex.IsMatch(user.Email))
                {
                errorMessage = "Invalid Email addres";
                return false;
                }

            return true;
        }

    }
}

