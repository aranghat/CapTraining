using OrderTracking;
using System;
using Xunit;

namespace ParcelTrackingTest
{
    public class ParcelNumberTest
    {
        //[Fact]
        //public void CheckParcelNumber_ValidData_ReturnsTrue()
        //{
        //    //Arrange
        //    var parcelNumber = "BLR123456";

        //    //Act
        //    var isValidParcel = ValidatePackage.Validate(parcelNumber);

        //    //Assert
        //    Assert.True(isValidParcel);
        //}


        //[Fact]
        //public void CheckParcelNumber_InValidData_ReturnsFalse()
        //{
        //    //Arrange
        //    var parcelNumber = "BL123456";

        //    //Act
        //    var isValidParcel = ValidatePackage.Validate(parcelNumber);

        //    //Assert
        //    Assert.False(isValidParcel);
        //}

        [Theory]
        [InlineData("BLR123456",true)]
        [InlineData("blr123456", true)]
        [InlineData("Blr123456", true)]
        [InlineData("BLR1", true)]
        [InlineData("BLR123456789102212", false)]
        [InlineData(" BLR123456", true)]
        public void CheckParcelNumber_ValidData_ReturnsExpectedResult(string parcelNumber
                        ,bool expectedOutput)
        {
            //Arrange

            //Act
            var isValidParcel = ValidatePackage.Validate(parcelNumber);

            //Assert
            Assert.Equal(expectedOutput, isValidParcel);    
        }
    }
}
