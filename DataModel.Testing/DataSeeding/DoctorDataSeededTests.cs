namespace DataModel.Testing.DataSeeding
{
    using DataModel.DataSeeding;
    using NUnit.Framework;

    [TestFixture]
    public class DoctorDataSeededTests
    {
        [Test(Description = "When GenerateRandomDoctors is called it returns an array of doctors.")]
        public void TestGenerateRandomDoctors()
        {
            var data = DoctorDataSeeded.GenerateRandomDoctors();

            // Default object value.
            Assert.AreNotEqual(null, data);

            // Default initialization values
            Assert.AreEqual(SharedVariables.NumberOfDoctors, data.Length);
        }
    }
}
