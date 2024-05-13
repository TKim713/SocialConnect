using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SocialConnect
{
    internal class Post
    {
        private int postID;
        private string content;
        private string author;
        private DateTime timestamp;
        private List<Comment> comments;
        private List<Like> likes;

        public static int lastPostID = 0;

        public Post(string content, string author, string timestamp, List<Comment> comments, List<Like> likes)
        {
            postID = ++lastPostID;
            this.content = content;
            this.author = author;
            DateTime tempTimestamp = DateTime.ParseExact(timestamp, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.timestamp = tempTimestamp;
            this.comments = comments;
            this.likes = likes;
        }

        public int PostID { get => postID; set => postID = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        internal string Author { get => author; set => author = value; }
        internal List<Comment> Comments { get => comments; set => comments = value; }
        internal List<Like> Likes { get => likes; set => likes = value; }

        public void XuatBaiViet()
        {
            string s = $"\n\tNoi Dung: {content} \n\tTac Gia: {author} " +
                $"\n\tNgay Dang: {timestamp: dd/MM/yyyy} \n\tComment: \n{comments}";
            Console.WriteLine(s);
        }
    }
}
