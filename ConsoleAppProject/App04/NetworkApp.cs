using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        public NewsFeed NewsFeed
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This is the primary menu where the user chooses whether to add a post or display all posts
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("   Kian's News Feed");

            string[] choices = new string[]
            {
                "Post Message","Post Image",""+
                "Display All Posts", "Display User post", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DisplayByUser(); break;
                    case 5: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        /// <summary>
        /// Displays posts only by a specific user 
        /// </summary>
        private void DisplayByUser()
        {
            Console.WriteLine("Enter Name of user");
            string user = Console.ReadLine();
            news.DisplayByUser(user);
            Console.WriteLine();
        }

        /// <summary>
        /// Displays all the posts and also uses the display menu 
        /// function to give the user more choices
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
            DisplayAllMenu();
        }

        /// <summary>
        /// Where the User will post an image by adding their name 
        /// then the url of the image and then a caption
        /// </summary>
        private void PostImage()
        {
            Console.WriteLine("Post an Image");

            Console.WriteLine("Enter your name > ");
            string author = Console.ReadLine();

            Console.WriteLine("Enter image url > ");
            string filename = Console.ReadLine();

            Console.WriteLine("Enter Caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author,filename,caption);
            news.AddPhotoPost(post);
            Console.WriteLine();
        }

     
        /// <summary>
        /// This is where the user will post a basic text message post
        /// </summary>
        private void PostMessage()
        {
            Console.WriteLine("Post a Message");

            Console.WriteLine("Enter your name > ");
            string author = Console.ReadLine();

            Console.WriteLine("Whats on your mind > ");
            string text = Console.ReadLine();

            MessagePost post = new MessagePost(author, text);
            news.AddMessagePost(post);
            Console.WriteLine();
        }


        /// <summary>
        /// This is the menu where the user interacts with the posts for example like,
        /// unlike, comment, remove posts and also allows the usr to go back to the main page
        /// </summary>
        public void DisplayAllMenu()
        {
            ConsoleHelper.OutputHeading("   Display All Posts By Kian Rozblat");

            string[] choices = new string[]
            {
                "Like","Unlike","Comment","Remove","Back to Menu", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: Like(); break;
                    case 2: Unlike(); break;
                    case 3: Comment(); break;
                    case 4: Remove(); break;
                    case 5: DisplayMenu(); break;
                    case 6: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        /// <summary>
        /// Removes a specific post that is chosen by the post id
        /// </summary>
        private void Remove()
        {
            ConsoleHelper.OutputHeading("Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ", 1, Post.GetNumberOfPosts());
            news.RemovePost(id);
            Console.WriteLine();
        }

        /// <summary>
        /// where the user adds a Comment onto a post
        /// </summary>
        private void Comment()
        {
            Console.WriteLine("Comment on a Post");
            Post post = FindPost();
            post.Display();
            Console.WriteLine("Please Enter your Comment");
            string comment = Console.ReadLine();
            post.AddComment(comment);
            Console.WriteLine("Comment Added");
            Console.WriteLine();
        }

        /// <summary>
        /// Where the user can unlike a previously liked post
        /// </summary>
        private void Unlike()
        {
            Console.WriteLine("Unlike a Post");
            Post post = FindPost();
            post.Unlike();
            Console.WriteLine("Post Unliked");
            Console.WriteLine();
        }

        /// <summary>
        /// Where the user can like a post
        /// </summary>
        private void Like()
        {
            Console.WriteLine("Like a Post");
            Post post = FindPost();
            post.Like();
            Console.WriteLine("Post Liked");
            Console.WriteLine();
        }

        /// <summary>
        /// Finds the specific post from the id entered from the user
        /// </summary>
        public Post FindPost()
        {
            int postID;
            postID = (int)ConsoleHelper.InputNumber("Please Enter Post ID > ");
            return news.FindPost(postID);
        }
    }
}
