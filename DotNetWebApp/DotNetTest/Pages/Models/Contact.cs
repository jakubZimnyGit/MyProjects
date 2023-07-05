using Microsoft.VisualBasic;

namespace DotNetTest.Pages.Models
{
    public class Contact         // Model "kontaktu" to klasa posiadająca te same Własności co kontakt w bazie danych, aby z łatwością dodawać rekordy
                                 // do tabeli "Contacts" w bazie danych
    {                                                                                                                                           
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Category { get; set; }
             

    }
}
