namespace Testing
{
    using DataModel.Models;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class MedicalTreatmentTests
    {

        private MedicalTreatment medicalTreatment;

        [SetUp]
        public void SetUp()
        {
            medicalTreatment = new MedicalTreatment();
        }

        [Test(Description = "When the MedicalTreatment constructor by default is called the return a object not null.")]
        public void TestConstructorCallByDefaultThenReturnObject()
        {
            // Default object value.
            Assert.AreNotEqual(null, medicalTreatment);

            // Default initialization values

            Assert.AreEqual(0, medicalTreatment.MedicalTreatmentId);
            Assert.AreEqual(null, medicalTreatment.Medicine);
            Assert.AreEqual(0, medicalTreatment.Days);
            Assert.AreEqual(0, medicalTreatment.PatientId);
            Assert.AreEqual(null, medicalTreatment.Patient);
        }
    }
}
