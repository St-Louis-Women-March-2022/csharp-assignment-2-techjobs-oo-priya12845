using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOOAutograded;
using TechJobsOO;


namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod()
        {

        }

        [TestMethod]
        public void TestSettingJobId()
        {
            //Creating the new job objects.
            TechJob job1 = new TechJob(); //id = 1
            TechJob job2 = new TechJob(); //id= 2

           // Assert.IsFalse(job1.Equals(job2));//test for equality
            //Test if difference between Ids is 1.
            Assert.AreEqual(job2.Id - job1.Id, 1);
            Assert.IsFalse(job1.Id == job2.Id);

        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType type = new PositionType("Quality control");
            CoreCompetency competency = new CoreCompetency("Persistence");
            TechJob techJob1 = new TechJob("Product tester", employer, location, type, competency);
            TechJob techJob2 = new TechJob("Product tester", employer, location, type, competency);
            Assert.IsFalse(techJob1.Equals(techJob2));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positiontype = new PositionType("Quality control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            TechJob job = new TechJob("Product tester", employer, location, positiontype,coreCompetency);

            Assert.AreEqual(job.Name, "Product tester");
            Assert.AreEqual(job.EmployerName.Value, "ACME");
            Assert.AreEqual(job.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job.JobType.Value, "Quality control");
            Assert.AreEqual(job.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {

            Employer employer = new Employer();
            Location location = new Location();
            PositionType positionType = new PositionType();
            CoreCompetency competency = new CoreCompetency();

            TechJob job = new TechJob("", employer, location, positionType, competency);
            string expected = "\nID: " + job.Id + "\nName: Data not available" + "\nEmployer: Data not available" + "\nLocation: Data not available" + "\nPosition Type: Data not available" + "\nCore Competency: Data not available\n";
            //string expected = Environment.NewLine + "ID: " + job.Id + Environment.NewLine + "Name: Data not available" + Environment.NewLine + "Employer: Data not available" + Environment.NewLine + "Location: Data not available" + Environment.NewLine + "Position Type: Data not available" + Environment.NewLine + "Core Competency: Data not available";
            string actual = job.ToString();
            char text = actual[0];
            char lasttext = actual[actual.Length - 1];
            Assert.AreEqual(text,lasttext);
            //Assert.AreEqual(expected, job.ToString());
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType type = new PositionType("Quality control");
            CoreCompetency competency = new CoreCompetency("Persistence");
            string name = "Product tester";
            TechJob techJob1 = new TechJob(name, employer, location, type, competency);
//            string expected = "\nID: " + techJob1.Id + "\nName: " + techJob1.Name + "\nEmployer: " + employer.Value + "\nLocation: " + location.Value + "\nPosition Type: " + type.Value + "\nCore Competency: " + competency.Value;
            string expected = Environment.NewLine + "ID: " + techJob1.Id + Environment.NewLine + "Name: " + techJob1.Name + Environment.NewLine + "Employer: " + employer.Value + Environment.NewLine + "Location: " + location.Value + Environment.NewLine + "Position Type: " + type.Value + Environment.NewLine + "Core Competency: " + competency.Value + Environment.NewLine;

            techJob1.ToString().Equals(expected);
            //Assert.AreEqual(expected, techJob1.ToString());
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType type = new PositionType("Quality control");
            CoreCompetency competency = new CoreCompetency("");
            TechJob techJob1 = new TechJob("Product tester", employer, location, type, competency);
            string expected = Environment.NewLine + "ID: " + techJob1.Id + Environment.NewLine + "Name: Product tester" + Environment.NewLine + "Employer: ACME" + Environment.NewLine + "Location: Desert" + Environment.NewLine + "Position Type: Quality control" + Environment.NewLine + "Core Competency: Data not available" + Environment.NewLine;
            techJob1.ToString().Equals(expected);

        }
      
    }
}
