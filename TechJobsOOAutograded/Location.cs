﻿using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class Location : JobField
    {
        //public int Id { get; }
        //public static int nextId = 1;
        //public string Value { get; set; }

        public Location() :  base()
        {
            //Id = nextId;
            //nextId++;
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.
        public Location(string value) : base(value)
        {
            
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

    }
}