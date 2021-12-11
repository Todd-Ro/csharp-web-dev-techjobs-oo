using System;

namespace TechJobsOO
{
    public abstract class JobField
    {
        private static int nextId = 1;
        public int Id { get; }
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

        //Equals will be overridden in the child classes
        public abstract override bool Equals(object obj);
        
    }
}