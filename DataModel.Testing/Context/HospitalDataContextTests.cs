namespace DataModel.Testing.Context
{    
    using DataModel.Context;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class HospitalDataContextTests
    {

        private HospitalDataContext hospitalDataContext;

        [SetUp]
        public void SetUp()
        {
            hospitalDataContext = new HospitalDataContext();
        }

        [Test(Description = "When the HospitalDataContext constructor by default is called the return a object not null.")]
        public void TestConstructorCallByDefaultThenReturnObject()
        {
            // Default object value.
            Assert.AreNotEqual(null, hospitalDataContext);

            // Default initialization values

            Assert.AreNotEqual(null, hospitalDataContext.Doctors);
            Assert.AreNotEqual(null, hospitalDataContext.MedicalTreatments);
            Assert.AreNotEqual(null, hospitalDataContext.Patients);
        }
    }
}
