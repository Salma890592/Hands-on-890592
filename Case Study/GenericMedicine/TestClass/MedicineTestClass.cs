using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GenericMedicine;


namespace TestClass
{
    [TestFixture]
    public class MedicineTestClass
    {
        Program p;
        Medicine medicine;
        [OneTimeSetUp]
        public void Init()
        {
            p = new Program();
            medicine = new Medicine() { Name = "Ultracet", GenericMedicineName = "Pain Killers", Composition = "comp", ExpiryDate = DateTime.Now.AddYears(5), PricePerStrip = 10.00 };
        }







        ////////////////////test cases for Create Medicine details/////////////////////////
       


        [Test]
        [TestCase("Ultracet", "Pain killers", "comp", "12/5/2024", 5.00)]  //with all correct details provided
        public void TestMedicineAllObjectsCreated(string name, string genericMedicineName, string composition, DateTime Expyears, double price)
        {
            Medicine m = null;
            try
            {

                m = p.CreateMedicineDetail(name, genericMedicineName, composition, Expyears, price);

                Assert.IsNotNull(m);
                //Assert.AreEqual(name, m.Name);
                //Assert.AreEqual(genericMedicineName, m.GenericMedicineName);
                //Assert.AreEqual(composition, m.Composition);
                //Assert.AreEqual(Expyears, m.ExpiryDate);
                //Assert.AreEqual(price, m.PricePerStrip);
            }
            catch (Exception)
            {

                Assert.Fail("Medicine Object not created successfully");
            }



        }



        [Test]
        [TestCase("Ultracet", "", "comp", "12/5/2024", 5.00)]  //while the generic medicine name having empty value
        public void MedicineEmptyGenericStringException(string name, string genericMedicineName, string composition, DateTime Expyears, double price)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, Expyears, price));

            Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", exp.Message);

        }


        [Test]
        [TestCase("Ultracet", "Pain Killers", "comp", "12/5/2024", -10)]  //price of strip less than zero case
        public void MedicinePriceBelowZeroException(string name, string genericMedicineName, string composition, DateTime Expyears, double price)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, Expyears, price));

            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exp.Message);

        }


        [Test]
        [TestCase("Dolo-65", "Pain killers", "comp", "10/03/2019", 5.00)]  //date less than current date for expiry date parameter
        
        public void MedicineExpiryDateLessThanCurrentException(string name, string genericMedicineName, string composition, DateTime Expyears, double price)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, Expyears, price));

            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exp.Message);

        }










        //////////////////test cases for Carton detail///////////////////////////////////



       [Test]
        [TestCase(1, "10/04/2021", "Retailer address")]//with all right details provided
        public void CheckCortonObjectCreation(int count, DateTime launchYears, string address)
        {
            CartonDetail c = null;
            try
            {

                c = p.CreateCartonDetail(count, launchYears, address, medicine);
                Assert.IsNotNull(c);
            }
            catch
            {

                Assert.Fail("Corton Object not created successfully");
            }

        }


            [Test]

            [TestCase(12, "10/01/2020", "Retailer address")]  // launch date less than current date   

            public void CortonLaunchDateLessThanCurrentException(int count, DateTime launchYears, string address)
            {

                var exp = Assert.Throws<Exception>(() => p.CreateCartonDetail(count, launchYears, address, medicine));

                Assert.AreEqual("Incorrect launch date. Please provide valid value", exp.Message);



            }

            
            [Test]
            [TestCase(-1, "10/04/2021", "Retailer address")] //value less than 0 for medicine strip count
        public void TestCortonException(int count, DateTime launchYears, string address)
            {


                var exp = Assert.Throws<Exception>(() => p.CreateCartonDetail(count, launchYears, address, medicine));

                Assert.AreEqual("Incorrect strip count. Please check", exp.Message);


            }




            
            [Test]
            [TestCase(12, "10/01/2020", "Retailer address", null)] //Check if null value provided for Medicine object, then Null carton detail should be
//obtained

            public void CheckForNullCartonObject(int count, DateTime launchYears, string address, Medicine medi)
            {
                CartonDetail carton = p.CreateCartonDetail(count, launchYears, address, medi);

                Assert.IsNull(carton);



            }
        }
    }

    

