using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyLibraryTest.Unittest
{
    public class DemoClassTests
    {
        private readonly DemoClass _demo;
        public DemoClassTests()
        {
            _demo = new DemoClass();
        }
        #region Fact
        [Fact]
        public void AddNumbers_Pass9and14_returns23()
        {
            //Arrange
            DemoClass demo = new DemoClass();
            int n1 = 9, n2 = 14;
            //Act
            int actual = demo.AddNumbers(n1, n2);
            //Assert
            int expected = 23;
            Assert.Equal(expected, actual);

        }
        #endregion
        [Fact]
        
        public void DivideNumbers_Ifn2isZero_ReturnsDividebyzeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _demo.DivideNumber(9, 0));
        }
        [Theory]
        [InlineData(27,9,3)]
        [InlineData(56,14,4)]
        public void DivideNumbers_Passn1andn2_ReturnsDivisionoftheNumber(int n1,int n2,int expected)
        {
            int actual = _demo.DivideNumber(n1,n2);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(9,14,126)]
        [InlineData(10,10,100)]
        public void Multiply_Passaandb_ReturnsMultiplicationofaandb(int n1,int n2,int expected)
        {
            int actual = _demo.Multiply(n1, n2);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(16,"Invalid")]
        [InlineData(18,"Valid")]
        [InlineData(60, "Valid")]
        [InlineData(61, "Invalid")]
        [InlineData(-1, "Invalid")]
        [InlineData(100, "Invalid")]
        public void Validate_Age_Acceptage_Returnsvalidorinvalid(int age,string expected)
        {
            var actual = _demo.Validate(age);
            Assert.Contains(expected, actual);
        }
        [Theory]
        [InlineData("nishitha","nishitha@123",true)]
        [InlineData("admin","admin@123",false)]
        public void Validate_AcceptsuserIdandpassword_ReturnsvalidorInvalid(string userId,string password,bool expected)
        {
            var actual = _demo.Validate(userId, password);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Validate_IfuserIdandpasswordareEmpty_ReturnsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _demo.Validate("", ""));
        }



    }
}
