using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

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

        private void DisplayByUser()
        {
            Console.WriteLine("Enter Name of user");
            string user = Console.ReadLine();
            news.DisplayByUser(user);
        }

        private void DisplayAll()
        {
            news.Display();
            DisplayAllMenu();
        }

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
        }

     
        private void PostMessage()
        {
            Console.WriteLine("Post a Message");

            Console.WriteLine("Enter your name > ");
            string author = Console.ReadLine();

            Console.WriteLine("Whats on your mind > ");
            string text = Console.ReadLine();

            MessagePost post = new MessagePost(author, text);
            news.AddMessagePost(post);
        }



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
        private void Remove()
        {
            ConsoleHelper.OutputHeading("Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ", 1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        private void Comment()
        {
            Console.WriteLine("Comment on a Post");
            Post post = FindPost();
            post.Display();
            Console.WriteLine("Please Enter your Comment");
            string comment = Console.ReadLine();
            post.AddComment(comment);
        }

        private void Unlike()
        {
            Console.WriteLine("Unlike a Post");
            Post post = FindPost();
            post.Unlike();
        }

        private void Like()
        {
            Console.WriteLine("Like a Post");
            Post post = FindPost();
            post.Like();
        }

        public Post FindPost()
        {
            int postID;
            postID = (int)ConsoleHelper.InputNumber("Please Enter Post ID > ");
            return news.FindPost(postID);
        }
    }
}
