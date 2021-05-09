namespace DataModel.Testing.DataSeeding
{
    using DataModel.DataSeeding;
    using NUnit.Framework;

    [TestFixture]
    public class MedicalTreatmentDataSeededTests
    {
        [Test(Description = "When GenerateRandomMedicalTreatments is called it returns an array of medicalTreatments.")]
        public void TestGenerateRandomMedicalTreatments()
        {
            var data = MedicalTreatmentDataSeeded.GenerateRandomMedicalTreatments();

            // Default object value.
            Assert.AreNotEqual(null, data);

            // Default initialization values
            Assert.AreEqual(SharedVariables.NumberOfMedicalTreatments, data.Length);
        }
    }
}