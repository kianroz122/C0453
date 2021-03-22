using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    ///</summary>
    ///<author>
    ///  Kian Rozblat
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Kian";
        private readonly List<Post> posts;
        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
            MessagePost post = new MessagePost(AUTHOR, "Hello there");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "A Dog");
            AddPhotoPost(photoPost);
        }


        ///<summary>
        /// Add a text post to the news feed.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();
            }
        }

        private void DisplayFromUser()
        {
            Console.WriteLine(" Which user do you want to see mentions from > ");
            string name = Console.ReadLine();
            if (name.Contains("much") == true)
            {
                Console.WriteLine("User found!");
            }
            else
            {
                Console.WriteLine("Word not found!");
            }
        }
    }
}
