using System;
using System.Collections.Generic;

namespace _01Adapter
{
    internal class AdapterExample
    {
        public void Start()
        {
            // datasource
            // var list = new List<string>() { "mailAddress1", "mailAddress2" };

            var repo = new AddressRepository();

            // email solution
            //var message = new MailMessage();
            //message.To.Add(new MailAddress("email address"));

            // két objektum erős csatolásban van, ha az egyik módosítása nem zárja ki
            // a másik megváltoztatását, minnél erősebb a csatolás annál valószínűbb, hogy a 
            // meg is változik a második objektum.

            // [Egyik objektum]---(csatolás)---[Másik objektum]

            // mit lehet tenni? INDIREKCIÓ
            // ADAPTER DESING MINTA

            // [Egyik objektum]---(csatolás)---[köztes ADAPTER objektum]---(csatolás)---[Másik objektum]

            var addressList = repo.GetAddresses();

            var messageService = new MessageService();


            foreach (var address in addressList)
            {
                messageService.AddMessage(to: address.Email, subject: "Ez az uzenet cime", text: "Uzenet szovege");

            }

            messageService.SendMessages();
        }
    }
}