using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyFoodSupply;


namespace TestLibrary
{
    [TestFixture]
    public class FoodSupplyTestClass
    {
        Program p;
        FoodDetail food;
        [OneTimeSetUp]
        public void Init()
        {
            p = new Program();
            food = new FoodDetail()
            {
                Name = "Biryani", DishType = FoodDetail.Category.MainDish, Price = 150.00, ExpiryDate = DateTime.Now.AddYears(3)
            };
        }



        [Test]
        [TestCase("Biryani",FoodDetail.Category.MainDish,150.00,"03/09/2022")]
        public void TestFoodDetailObjectsCreation(string name,int category, double price, DateTime expDate)
        {
            FoodDetail m = null;
            try
            {

                m = p.CreateFoodDetail(name,category,expDate,price);

                Assert.IsNotNull(m);
                
            }
            catch (Exception)
            {

                Assert.Fail("Food details Object not created successfully");
            }



        }
        [Test]
        [TestCase("", FoodDetail.Category.MainDish, 150.00, "03/09/2021")]  //while the food item value is  having empty value
        public void FoodItemEmptyGenericStringException(string name, int category, double price, DateTime expDate)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, category, expDate, price));

            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", exp.Message);

        }


        [Test]
        [TestCase("Biryani", FoodDetail.Category.MainDish,-100.00, "03/09/2021")]  //price of strip less than zero case
        public void FoodItemPriceBelowZeroException(string name, int category, double price, DateTime expDate)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, category, expDate, price));

            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", exp.Message);

        }


        [Test]
        [TestCase("Biryani", FoodDetail.Category.MainDish, 150.00, "01/09/2020")]  //date less than current date for expiry date parameter

        public void FoodItemExpiryDateLessThanCurrentException(string name, int category, double price, DateTime expDate)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, category, expDate, price));

            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exp.Message);

        }


        //////////////////////////////Testcases for supply detail///////////////////////
        ///


        [Test]
        [TestCase(12,"03/09/2023","TruYum",40.00)]//with all right details provided
        public void SupplyDetailObjectCreation(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            SupplyDetail c = null;
            try
            {

                c = p.CreateSupplyDetail(foodItemCount,requestDate,sellerName,packingCharge,food);
                Assert.IsNotNull(c);
            }
            catch
            {

                Assert.Fail("Supply details Object not created successfully");
            }

        }




        [Test]

        [TestCase(12, "01/09/2019", "TruYum", 40.00)]  // launch date less than current date   

        public void SupplyLaunchDateLessThanCurrentException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {

            var exp = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));

            Assert.AreEqual("Incorrect food request date. Please provide valid value", exp.Message);



        }


        [Test]
        [TestCase(-12, "01/09/2021", "TruYum", 40.00)] //value less than 0 for food item count
        public void SupplyItemCountlessthanZero(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {


            var exp = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));

            Assert.AreEqual("Incorrect food item count. Please check", exp.Message);


        }





        [Test]
        [TestCase(12, "03/09/2021", "TruYum", 40.00,null)]
        //Check if null value provided for food item object, then Null supply detail should be obtained
        


        public void CheckForNullSupplyObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge,FoodDetail food)
        {
            SupplyDetail supply = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food);

            Assert.IsNull(supply);



        }
    }
}





   
