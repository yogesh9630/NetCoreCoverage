namespace Testing
{
    using DataModel.Models;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PatientTests
    {

        private Patient patient;

        [SetUp]
        public void SetUp()
        {
            patient = new Patient();
        }

        [Test(Description = "When the Patient constructor by default is called the return a object not null.")]
        public void TestConstructorCallByDefaultThenReturnObject()
        {
            // Default object value.
            Assert.AreNotEqual(null, patient);

            // Default initialization values

            Assert.AreEqual(0, patient.PatientId);
            Assert.AreEqual(null, patient.Name);
            Assert.AreEqual(null, patient.Surname);
            Assert.AreEqual(new DateTime(), patient.DateBorn);
            Assert.AreEqual(0, patient.Age);
            Assert.AreEqual(null, patient.Patients);
            Assert.AreEqual(0, patient.DoctorId);
            Assert.AreEqual(null, patient.Doctor);
        }
    }
}
