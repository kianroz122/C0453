using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    [Serializable]
    public class Post
    {
        public int likes;
        public int PostID;
        private static int instances = 0;
        private readonly List<String> comments;

        public DateTime Timestamp { get; }
        public String Username { get; }

        public Post(string author)
        {
            instances++;
            PostID = instances;
            this.Username = author;
            Timestamp = DateTime.Now;
            likes = 0;
            comments = new List<String>();
        }

        /// <summary>
        /// When the user has selected the post and chose the like option it will count the extra likes
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        ///Shows when a user has undone their like 
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>       
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

        ///<summary>
        /// Display the details of this post.
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Post Id: {PostID}");
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes:  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    {comments.Count}  comment(s). ");
            }
        }

        /// <summary>
        /// Returns the amount of posts
        /// </summary>
        /// <returns></returns>
        public static int GetNumberOfPosts()
        {
            return instances;
        }
    }
}
