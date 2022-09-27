﻿using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        //Modifiers changed from private to public
        //public int Id { get; }
        //public static int nextId = 1;
        //public string Value { get; set; }

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency() : base()
        {
            //Id = nextId;
            //nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
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
