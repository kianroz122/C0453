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
                    case 4: DisplayFromUser(); break;
                    case 5: SaveAllPosts(); break;
                    case 6: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void SaveAllPosts()
        {
            throw new NotImplementedException();
        }

        private void DisplayAll()
        {
            news.Display();
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
