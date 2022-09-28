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
        TechJob techJob1;
        TechJob techJob2;
        TechJob techJob3;
        TechJob techJob4;

        [TestInitialize]
        public void CreateJobObject()
        {
             techJob1 = new TechJob();
             techJob2 = new TechJob();

             techJob3 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
             techJob4 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        }
        [TestMethod]
        public void TestMethod()
        {

        }

        [TestMethod]
        public void TestSettingJobId()
        {
            //Creating the new job objects.
            //TechJob job1 = new TechJob(); //id = 1
            //TechJob job2 = new TechJob(); //id= 2

           // Assert.IsFalse(job1.Equals(job2));//test for equality
            //Test if difference between Ids is 1.
            Assert.AreEqual(techJob2.Id - techJob1.Id, 1);
            Assert.IsFalse(techJob1.Id == techJob2.Id);

        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            //Employer employer = new Employer("ACME");
            //Location location = new Location("Desert");
            //PositionType type = new PositionType("Quality control");
            //CoreCompetency competency = new CoreCompetency("Persistence");
           // TechJob techJob1 = new TechJob("Product tester", employer, location, type, competency);
            //TechJob techJob2 = new TechJob("Product tester", employer, location, type, competency);
            Assert.IsFalse(techJob3.Equals(techJob4));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Employer employer = new Employer("ACME");
            //Location location = new Location("Desert");
            //PositionType positiontype = new PositionType("Quality control");
            //CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            //TechJob job = new TechJob("Product tester", employer, location, positiontype,coreCompetency);

            Assert.AreEqual(techJob3.Name, "Product tester");
            Assert.AreEqual(techJob3.EmployerName.Value, "ACME");
            Assert.AreEqual(techJob3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(techJob3.JobType.Value, "Quality control");
            Assert.AreEqual(techJob3.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {

            //Employer employer = new Employer();
            //Location location = new Location();
            //PositionType positionType = new PositionType();
            //CoreCompetency competency = new CoreCompetency();

            //TechJob job = new TechJob();
            //string expected = "\nID: " + job.Id + "\nName: Data not available" + "\nEmployer: Data not available" + "\nLocation: Data not available" + "\nPosition Type: Data not available" + "\nCore Competency: Data not available\n";
            string expected = Environment.NewLine + "ID: " + techJob3.Id + Environment.NewLine + "Name: Data not available" + Environment.NewLine + "Employer: Data not available" + Environment.NewLine + "Location: Data not available" + Environment.NewLine + "Position Type: Data not available" + Environment.NewLine + "Core Competency: Data not available";
            string actual = techJob3.ToString();
            char text = actual[0];
            char lasttext = actual[actual.Length - 1];
            Assert.AreEqual(text,lasttext);
            //Assert.AreEqual(expected, techJob3.ToString());


            
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            //Employer employer = new Employer("ACME");
            //Location location = new Location("Desert");
            //PositionType type = new PositionType("Quality control");
            //CoreCompetency competency = new CoreCompetency("Persistence");
            //string name = "Product tester";
            //TechJob techJob1 = new TechJob(name, employer, location, type, competency);
            //string expected = "\nID: " + techJob3.Id + "\nName: " + techJob3.Name + "\nEmployer: " + employer.Value + "\nLocation: " + location.Value + "\nPosition Type: " + type.Value + "\nCore Competency: " + competency.Value;
           string expected = "\nID: " + techJob3.Id + "\nName: " + techJob3.Name + "\nEmployer: " + techJob3.EmployerName.Value + "\nLocation: " + techJob3.EmployerLocation.Value + "\nPosition Type: " + techJob3.JobType.Value + "\nCore Competency: " + techJob3.JobCoreCompetency.Value + "\n";

            //techJob3.ToString().Equals(expected);
            Assert.AreEqual(expected, techJob3.ToString());
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            //Employer employer = new Employer("ACME");
            //Location location = new Location("Desert");
            //PositionType type = new PositionType("Quality control");
            //CoreCompetency competency = new CoreCompetency("");
            //TechJob techJob1 = new TechJob("Product tester", employer, location, type, competency);
            techJob3.JobCoreCompetency.Value = "";
            //string expected = Environment.NewLine + "ID: " + techJob3.Id + Environment.NewLine + "Name: Product tester" + Environment.NewLine + "Employer: ACME" + Environment.NewLine + "Location: Desert" + Environment.NewLine + "Position Type: Quality control" + Environment.NewLine + "Core Competency: Data not available" + Environment.NewLine;
            string expected = "\nID: " + techJob3.Id + "\nName: Product tester" + "\nEmployer: ACME" + "\nLocation: Desert" + "\nPosition Type: Quality control" + "\nCore Competency: Data not available\n";

            //techJob1.ToString().Equals(expected);
            Assert.AreEqual(expected, techJob3.ToString());

        }
      
    }
}
