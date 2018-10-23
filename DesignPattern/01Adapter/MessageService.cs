using System;
using System.Collections.Generic;

namespace _01Adapter
{
    public class MessageService
    {
        private List<Message> messages = new List<Message>();

        public MessageService()
        {
        }

        internal void AddMessage(string to, string subject, string text)
        {
            messages.Add(new Message { to="to", subject="subject", text="text" });
        }

        internal void SendMessages()
        {
            foreach (var message in messages)
            {
                Console.WriteLine($"To={message.to}, subject={message.subject}, text={message.text}");
            }
        }
    }
}