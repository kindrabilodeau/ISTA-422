﻿using System;

namespace EfConsoleApplication
{
    /// <summary>
    /// The person model.
    /// </summary>
    public class Person
    {
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}