using System;
using System.Collections.Generic;
using TechJobsOO;

namespace TechJobsOO
{
    public class TechJob
    {
        /*
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        // TODO: Generate Equals() and GetHashCode() methods.

        */

        
        public int Id { get; }
        public static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public TechJob()
        {
            Id = nextId;
            nextId++;
        }
        public TechJob(string value,Employer employer, Location location, PositionType positiontype, CoreCompetency corecompetency) : this()
        {
            this.Name = value;
            this.EmployerName = employer;
            this.EmployerLocation = location;
            this.JobType = positiontype;
            this.JobCoreCompetency = corecompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is TechJob job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {


            //string completeString = "\nID: " + this.Id + "\nName: Data not available" + "\nEmployer: Data not available" + "\nLocation: Data not available" + "\nPosition Type: Data not available" + "\nCore Competency: Data not available\n";
            string completeString = "\nID: " + this.Id;
            if (this.Name != "")
            {
                completeString += "\nName: " + this.Name;
            }
            else
            {
                completeString += "\nName: Data not available";
            }
            if (this.EmployerName.Value != null && this.EmployerName.Value != "")
            {
                completeString += "\nEmployer: " + this.EmployerName.ToString();
            }
            else
            {
                completeString += "\nEmployer: Data not available";
            }
            if (this.EmployerLocation.Value != "" && this.EmployerLocation.Value != null)
            {
                completeString += "\nLocation: " + this.EmployerLocation.Value;
            }
            else
            {
                completeString += "\nLocation: Data not available";
            }
            if (this.JobType.Value != null && this.JobType.Value != "")
            {
                completeString += "\nPosition Type: " + this.JobType.ToString();
            }
            else
            {
                completeString += "\nPosition Type: Data not available";
            }
            if (this.JobCoreCompetency.Value != null && this.JobCoreCompetency.Value != "")
            {
                completeString += "\nCore Competency: " + this.JobCoreCompetency.ToString() + "\n";
            }
            else
            {
                completeString += "\nCore Competency: Data not available" + "\n";
            }
            //if (this.Name == null && this.EmployerName == null && this.EmployerLocation == null && this.JobType == null && this.JobCoreCompetency == null)
            //{
            //    return "OOPS!  This job does not seem to exist.";
            //}
            return completeString;
            
        }

    }
}