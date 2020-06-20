using System;
using System.ComponentModel.DataAnnotations;

namespace MizoChokaFinal.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email ah hian '@' tih tel angai")]
        public string Email { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "I password hi thumal 4 atanga 8 inkar a ngai")]
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public UserForRegisterDto()
        {
            Created = DateTime.Now;
        }
    }
}