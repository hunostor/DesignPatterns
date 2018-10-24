using System;
using System.Collections.Generic;

namespace _01Adapter
{
    public class AdapterExample
    {
        private readonly IAddressRepository repository;
        private readonly IMessageService service;

        public AdapterExample(IAddressRepository repository, IMessageService service)
        {
            if(repository == null) { throw new ArgumentNullException(nameof(repository)); }
            this.repository = repository;

            if (service == null) { throw new ArgumentNullException(nameof(service)); }
            this.service = service;
        }


        public void Start()
        {           
            // datasource
            // var list = new List<string>() { "mailAddress1", "mailAddress2" };

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

            var addressList = repository.GetAddresses();

            foreach (var address in addressList)
            {
                service.AddMessage(to: address.Email, subject: "Ez az uzenet cime", text: "Uzenet szovege");

            }

            service.SendMessages();
        }
    }
}