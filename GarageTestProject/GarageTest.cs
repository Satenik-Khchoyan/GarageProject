using GarageProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Xunit.Sdk;

namespace GarageTestProject
{
    [TestClass]
    public class GarageTest
    {
        [TestMethod]
        public void IsRegNoExist_Should_Return_False()
        {
            //Arrange
            const int capacity = 2;
            var garage = new Garage<Vehicle>(capacity);
            var car = new Car("ABC", "Car", "Black", 4, "gas");
            var bus = new Bus("DDD", "Bus", "Black", 4, 20);
            garage.AddVehicle(car);
            garage.AddVehicle(bus);
            
            
            Assert.AreEqual(false, garage.IsRegNoExist("BBB"));
        }

        [TestMethod]
        public void IsRegNoExist_Should_Return_True()
        {
            //Arrange
            const int capacity = 2;
            var garage = new Garage<Vehicle>(capacity);
            var car = new Car("ABC", "Car", "Black", 4, "gas");
            var bus = new Bus("DDD", "Bus", "Black", 4, 20);
            garage.AddVehicle(car);
            garage.AddVehicle(bus);


            Assert.AreEqual(true, garage.IsRegNoExist("ABC"));
        }

        [TestMethod]
        public void Get_Vehicle_Types()
        {
            //Arrange
            const int capacity = 2;
            var garage = new Garage<Vehicle>(capacity);
            var car = new Car("ABC", "Car", "Black", 4, "gas");
            garage.AddVehicle(car);
           
            List<string> actualTypeList = garage.GetVehicleTypes();

            ;
            Assert.AreEqual(true, actualTypeList.Contains("Car"));
        }
    }
}
