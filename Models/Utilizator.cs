using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AgendaActivitati
{
    [Serializable]
    public class Utilizator
    {
        //atribute
        private string username;
        private string password;

        //constructor
        public Utilizator(string username, string password)
        {
            this.username = username;
            Password = HashPassword(password);
        }

        //metode
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public bool VerificaAutentificarea(string username, string password)
        {
            return Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                   && Password == HashPassword(password);
        }



        //proprietati
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
