﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency: JobField
    {
        

        public CoreCompetency(): base(){}

        public CoreCompetency(string value): base(value){}

        

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

       
    }
}

