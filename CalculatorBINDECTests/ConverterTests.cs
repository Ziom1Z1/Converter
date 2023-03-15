using CalculatorBINDEC;

namespace CalculatorBINDECTests
{
    public class Tests
    {
        Converter converter = null;

        [SetUp]
        public void Setup()
        {
            converter = new Converter();
        }
        
        [TestCase("10","2",2)]
        [TestCase("31", "25", 8)]
        [TestCase("AB", "171", 16)]
        public void CheckIfValueToDecimalIsValid(string input, string output, int baseSystem)
        {
            converter.Value = input;
            converter.ToDecimal(baseSystem);

            Assert.That(output, Is.EqualTo(converter.Value));
        }

        [TestCase("1010", 2)]
        [TestCase("12", 8)]
        [TestCase("a", 16)]
        public void CheckIfValueFromDecimalIsValid(string output, int baseSystem)
        {
            converter.Value = "10";
            converter.ToSystem(baseSystem);

            Assert.That(output, Is.EqualTo(converter.Value));
        }

        [TestCase("1101011","6b", 2, 16)]
        [TestCase("321", "11010001", 8, 2)]
        [TestCase("7abf", "75277", 16, 8)]
        public void CheckIfConversionIsValid(string input, string output, int fromBaseSystem, int toBaseSystem)
        {
            converter.Value = input;
            converter.ToDecimal(fromBaseSystem);
            converter.ToSystem(toBaseSystem);

            Assert.That(output, Is.EqualTo(converter.Value));
        }
    }
}