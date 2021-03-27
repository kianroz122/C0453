using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Kian Rozblat
    /// version 0.1
    /// </author>
    public class MessagePost: Post
    {
        public String Message { get; }

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        public MessagePost(String author, String text): base(author)
        {
            Message = text;
        }
        /// <summary>
        /// Displays the message post
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"    Message: {Message}");
            base.Display();
        }
    }
}
