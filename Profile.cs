using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialConnect
{
    internal class Profile: User
    {
        private string bio;
        private string gender;
        private DateTime dateOfBirth;
        private string location;

        public Profile(string bio, string gender, DateTime dateOfBirth, string location)
        {
            this.bio = bio;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.location = location;
        }

        public string Bio { get => bio; set => bio = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Location { get => location; set => location = value; }
        public string Gender { get => gender; set => gender = value; }

        public void XuatThongTin()
        {
            string s = $"{toString()} \n\tTieu Su: {bio} \n\tGioi Tinh: {gender} " +
                $"\n\tNgay Sinh: {dateOfBirth: dd/MM/yyyy} \n\tDia Chi: {location}";
            Console.WriteLine(s);
        }
    }
}
