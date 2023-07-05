using DotNetTest.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace DotNetTest.Pages.UserPanel
{
    public class LoginModel : PageModel
    {
        List<User> listOfUsers = new List<User>();

        public User UserInfo = new User();
        public String errorMessage = "";
        public String succesMessage = "";
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            UserInfo.Email = Request.Form["Email"];
            UserInfo.Password = Request.Form["Password"];

            if (UserInfo.Password.Length == 0 || UserInfo.Email.Length == 0)
                
            {
                errorMessage = "All the fields are required";
                return;
            }
            User logUser = new User();
            logUser.Email = UserInfo.Email;
            logUser.Password = UserInfo.Password;

            if (IsValid(logUser))
            {
                Response.Redirect("/IndexLoggedIn");
            }
            else
            {
                errorMessage = "Invalid Data. Try again.";
            }
            errorMessage = "";

        }

        private List<User> GetUsers()
        {
            String connectionString = "Data Source=DESKTOP-25Q87GI;Initial Catalog=ContactsDB;Integrated Security=True";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var output = connection.Query<User>("dbo.spUsersGetAll").ToList();
                return output;
            }
        }

        private bool IsValid(User user)
        {
            listOfUsers = GetUsers();
            return listOfUsers.Any( x => x.Email == user.Email && x.Password == user.Password);
        }

        
    }
}
