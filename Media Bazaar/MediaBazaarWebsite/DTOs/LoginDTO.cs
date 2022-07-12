using System.ComponentModel.DataAnnotations;

namespace MediaBazaarWebsite.DTOs
{
    public class LoginDTO
    {
        string userName;
        string password;

        public LoginDTO()
        {
        }

        [Required]
        [StringLength(25, ErrorMessage = "The minimum allowed length is 4 characters.", MinimumLength = 4)]
        public string UserName { get => userName; set => userName = value; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }
    }
}
