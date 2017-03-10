﻿using System;

namespace NewStuff.Events
{
    public class CustomerAdded : CustomerEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
    }
}