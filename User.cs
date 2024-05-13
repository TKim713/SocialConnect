using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialConnect
{
    internal class User
    {
        private int userID;
        private string username;
        private string email;
        private string password;

        private static int lastUserID = 0;

        public User(string username, string email, string password)
        {
            userID = ++lastUserID;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        public User()
        {
            username = "";
            email = "";
            password = "";
        }

        public User(string username)
        {
            this.username = username;
        }

        public int UserID { get => userID; set => userID = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        // Ham Dang Ky
        public void DangKy()
        {
            NhapUsername();
            NhapEmail();
            NhapPassword();
        }

        public void NhapUsername()
        {
        // Nhap Username
        Username:
            Console.Write("\nUsername: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            username = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (username == "")
            {
                Check(1);
                goto Username;
            }
        }

        public void NhapEmail()
        {
        // Nhap Email
        Email:
            Console.Write("\nEmail: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            email = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (email == "")
            {
                Check(1);
                goto Email;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                Check(2);
            }
        }

        public void NhapPassword()
        {
        // Nhap Password
        Password:
            Console.Write("\nPassword: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (password == "")
            {
                Check(1);
                goto Password;
            }
            if (password.Length < 6)
            {
                Check(3);
                goto Password;
            }
        }

        public void Check(int chon)
        {
            switch (chon)
            {
                // Neu la loi chuoi rong
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Khong duoc de trong. Moi nhap lai!", Console.ForegroundColor);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                // Neu la loi dinh dang email
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Email khong hop le. Moi nhap lai!", Console.ForegroundColor);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                // Neu password <6 ky tu
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Mat khau phai lon hon 6 ky tu. Moi nhap lai!", Console.ForegroundColor);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public string toString()
        {
            return $"\tUsername: {username}";
        }
    }
}
