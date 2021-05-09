namespace DataModel.Testing.DataSeeding
{
    using DataModel.DataSeeding;
    using NUnit.Framework;

    [TestFixture]
    public class PatientDataSeededTests
    {
        [Test(Description = "When GenerateRandomPatients is called it returns an array of patients.")]
        public void TestGenerateRandomPatients()
        {
            var data = PatientDataSeeded.GenerateRandomPatients();

            // Default object value.
            Assert.AreNotEqual(null, data);

            // Default initialization values
            Assert.AreEqual(SharedVariables.NumberOfPatients, data.Length);
        }
    }
}