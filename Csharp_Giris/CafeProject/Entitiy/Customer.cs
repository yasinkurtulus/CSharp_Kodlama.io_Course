﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CafeProject.Entitiy
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        public int Stars { get; set; }
    }
}
