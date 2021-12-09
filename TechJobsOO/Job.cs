using System;
using System.Text;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, 
            PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append($"ID: {Id}" +"\n");
            sb.Append($"Name: {Name}" +"\n");
            /*Assert.IsTrue(words[3].Equals($"Employer: {testJob.EmployerName.Value}"));
            Assert.IsTrue(words[4].Equals($"Location: {testJob.EmployerLocation.Value}"));
            Assert.IsTrue(words[5].Equals($"Position Type: {testJob.JobType.Value}"));
            Assert.IsTrue(words[6].Equals($"Core Competency: {testJob.JobCoreCompetency.Value}"));*/
            sb.Append($"Employer: {EmployerName.Value}" + "\n");
            sb.Append($"Location: {EmployerLocation.Value}" + "\n");
            sb.Append($"Position Type: {JobType.Value}" + "\n");
            sb.Append($"Core Competency: {JobCoreCompetency.Value}" 
                + "\n");
            string almostDone = sb.ToString();
            string[] fields = almostDone.Split("\n");
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("\n");
            for (int i=1; i<(fields.Length-1); i++)
            {
                string field = fields[i];
                //Console.WriteLine(field + "\t"+"; "+field.Length);
                string[] fieldParts = field.Split(": "); 
                if (fieldParts[1].Length == 0) 
                { 
                    field = fieldParts[0] + ": " + "Data not available";
                }
                sb2.Append(field + "\n");
            }
            Console.WriteLine(sb2.ToString());
            return sb2.ToString();
        }


    }
}
