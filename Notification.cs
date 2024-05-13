using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SocialConnect
{
    internal class Notification
    {
        private int notiID;
        private int userID;
        private string content;
        private DateTime timestamp;
        private int postID;

        public static int lastNotiID = 0;

        public Notification(int userID, string content, string timestamp, int postID)
        {
            notiID = ++lastNotiID;
            this.userID = userID;
            this.content = content;
            DateTime tempTimestamp = DateTime.ParseExact(timestamp, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.timestamp = tempTimestamp;
            this.postID = postID;
        }

        public int NotiID { get => notiID; set => notiID = value; }
        public int UserID { get => userID; set => userID = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        public int PostID { get => postID; set => postID = value; }

        public void XuatThongBao()
        {
            string s = $"\n\tNoi Dung: {content} \n\tThoi Gian: {timestamp} ";
            Console.WriteLine(s);
        }
    }
}
