using System;

namespace MizoChokaFinal.API.Models
{
    public class User
    {
         public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        // public string Email { get; set; }
        // public string Thuthar { get; set; }
        // public DateTime Created { get; set; }
        // public string Ingredients { get; set; }
        // public string RecipeName { get; set; }
        // public string Steps { get; set; }
        // public ICollection<Photo> Photos { get; set; }
    }
}