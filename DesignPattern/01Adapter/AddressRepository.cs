﻿using System;
using System.Collections.Generic;

namespace _01Adapter
{
    public class AddressRepository
    {
        public AddressRepository()
        {
        }

        public IList<Address> GetAddresses()
        {
            return new List<Address> { new Address { Email = "example@gmail.com" } };
        }
    }
}