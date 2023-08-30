using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public int Phone { get; set; }  
        public string Email { get; set; } 
        
        public User() { }

        public User(string name, string surname,int phone, string email)
        {
            Name = name; 
            Surname = surname; 
            Phone = phone; 
            Email = email;   
        }
    }
}
