namespace Testing
{
    using DataModel.Models;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DoctorTests
    {

        private Doctor doctor;

        [SetUp]
        public void SetUp()
        {
            doctor = new Doctor();
        }

        [Test(Description="When the Doctor constructor by default is called the return a object not null.")]
        public void TestConstructorCallByDefaultThenReturnObject()
        {
            // Default object value.
            Assert.AreNotEqual(null, doctor);

            // Default initialization values

            Assert.AreEqual(0, doctor.DoctorID);
            Assert.AreEqual(null, doctor.Name);
            Assert.AreEqual(null, doctor.Surname);
            Assert.AreEqual(new DateTime(), doctor.DateBorn); 
            Assert.AreEqual(0, doctor.Age);
            Assert.AreEqual(null, doctor.Patients);
        }
    }
}
