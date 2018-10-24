using System;
using System.Collections.Generic;

namespace _01Adapter
{
    public class MessageTestService : IMessageService
    {
        private List<Message> messages = new List<Message>();     

        public void AddMessage(string to, string subject, string text)
        {
            messages.Add(new Message { to="to", subject="subject", text="text" });
        }

        public void SendMessages()
        {
            foreach (var message in messages)
            {
                Console.WriteLine($"To={message.to}, subject={message.subject}, text={message.text}");
            }
        }
    }
}