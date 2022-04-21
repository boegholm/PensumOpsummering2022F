using Eksamen;
using System;
using Xunit;

namespace MyApp.Tests
{
    public class CalculatorTests { 
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(0,0,0)]
        [InlineData(1,0,1)]
        public void TestAddition(int a, int b, int expectedResult)
        {
            Calculator calculator = new Calculator();
            int k = calculator.Add(a, b);
            Assert.Equal(expectedResult, k);
        }
    }


    public class UserTest
    {
        [Fact]
        public void TestNameNotNull()
        {
            User u = new User();
            Assert.Throws<ArgumentNullException>(() =>
            {
                u.Navn = null;
            });
        }

        [Fact]
        public void TestNameCannotBeEmpty()
        {
            User u = new User();
            Assert.Throws<ArgumentException>(() =>
            {
                u.Navn = "";
            });
        }

        [Fact]
        public void TestUsernameSet()
        {
            var u = new User();
            u.Navn = "Thomas";
            Assert.Equal("Thomas", u.Navn);
        }

        [Theory]
        [InlineData("thomas")]
        [InlineData("thomas@@bøgholm.dk")]
        public void TestEmailValidationFails(string email)
        {
            User u = new User();
            Assert.Throws<EmailValidationException>(() =>
            {
                u.Email = email;
            });
        }


    }
}