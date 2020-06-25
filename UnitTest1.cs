using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Rules_Engine_Console;


namespace Business_Rules_Engine_Console
{
    [TestClass]
    public class UnitTest1 
    {
        
        public UnitTest1()
        {
            //DataSetup Setup = new DataSetup();
        }

        [TestMethod]
        public void Bus_rules_Engine_Should_Generate_PackagingSlip_For_PhysicalProduct(int Order_num)
        {
            //Arrange
            
            Console.WriteLine("Entering Payment Transaction");
            DataSetup Setup = new DataSetup();
            Transaction Trans = new Transaction(Order_num);

            //Act
            bool result = Trans.Trans_status;
            //Assert
            Assert.AreEqual(result, true);
            Console.WriteLine("Bus_rules_Engine_Should_Generate_PackagingSlip_For_PhysicalProduct" + result);
        }

        [TestMethod]
        public void Bus_rules_Engine_Create_Duplicate_Packing_Slip(int Order_num)
        {
            //Arrange

            Console.WriteLine("Entering Payment Transaction");
            DataSetup Setup = new DataSetup();
            Transaction Trans = new Transaction(Order_num);

            //Act
            bool result = Trans.Trans_status;
            //Assert
            Assert.AreEqual(result, true);
            Console.WriteLine("Bus_rules_Engine_Create_Duplicate_Packing_Slip" + result);
        }

        [TestMethod]
        public void Bus_rules_Engine_ActivateMembership(int Order_num)
        {
            //Arrange

            Console.WriteLine("Entering Payment Transaction");
            DataSetup Setup = new DataSetup();
            Transaction Trans = new Transaction(Order_num);

            //Act
            bool result = Trans.Trans_status;
            //Assert
            Assert.AreEqual(result, true);
            Console.WriteLine("Bus_rules_Engine_ActivateMembership" + result);
        }

        [TestMethod]
        public void Bus_rules_Engine_Should_Upgrade_Membership(int Order_num)
        {
            //Arrange

            Console.WriteLine("Entering Payment Transaction");
            DataSetup Setup = new DataSetup();
            Transaction Trans = new Transaction(Order_num);

            //Act
            bool result = Trans.Trans_status;
            //Assert
            Assert.AreEqual(result, true);
            Console.WriteLine("Bus_rules_Engine_Should_Upgrade_Membership" + result);
        }

        [TestMethod]
        public void Bus_rules_Engine_Should_Generate_FreeVideoSlip(int Order_num)
        {
            //Arrange

            Console.WriteLine("Entering Payment Transaction");
            DataSetup Setup = new DataSetup();
            Transaction Trans = new Transaction(Order_num);

            //Act
            bool result = Trans.Trans_status;
            //Assert
            Assert.AreEqual(result, true);
            Console.WriteLine("Bus_rules_Engine_Should_Generate_FreeVideoSlip" + result);
        }

        [TestMethod]
        public void Bus_rules_Engine_Commission_Pymnt_For_Book_Physical_Product(int Order_num)
        {
            //Arrange

            Console.WriteLine("Entering Payment Transaction");
            DataSetup Setup = new DataSetup();
            Transaction Trans = new Transaction(Order_num);

            //Act
            bool result = Trans.Trans_status;
            //Assert
            Assert.AreEqual(result, true);
            Console.WriteLine("Bus_rules_Engine_Commission_Pymnt_For_Book_Physical_Product" + result);
        }

        [TestMethod]
        public void Bus_rules_Engine_Send_Email_Membership_Activation_Upgrade(int Order_num)
        {
            //Arrange

            Console.WriteLine("Entering Payment Transaction");
            DataSetup Setup = new DataSetup();
            Transaction Trans = new Transaction(Order_num);

            //Act
            bool result = Trans.Trans_status;
            //Assert
            Assert.AreEqual(result, true);
            Console.WriteLine("Bus_rules_Engine_Send_Email_Membership_Activation_Upgrade" + result);
        }

        [TestMethod]
        public void Bus_rules_Engine_Invalid_Order_Number(int Order_num)
        {
            //Arrange

            Console.WriteLine("Entering Payment Transaction");
            DataSetup Setup = new DataSetup();
            Transaction Trans = new Transaction(Order_num);

            //Act
            bool result = Trans.Trans_status;
            //Assert
            Assert.AreEqual(result, true);
            Console.WriteLine("Bus_rules_Engine_Invalid_Order_Number" + result);
        }
    }
    public class UnitTestMainClass
    {
        static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("-- Unit Testing Started --");
                UnitTest1 UnitTest = new UnitTest1();
                Console.WriteLine("-- Instance of unit test created --");
                UnitTest.Bus_rules_Engine_Should_Generate_PackagingSlip_For_PhysicalProduct(300);
                UnitTest.Bus_rules_Engine_Create_Duplicate_Packing_Slip(304);
                UnitTest.Bus_rules_Engine_ActivateMembership(303);
                UnitTest.Bus_rules_Engine_Should_Upgrade_Membership(305);
                UnitTest.Bus_rules_Engine_Should_Generate_FreeVideoSlip(301);
                UnitTest.Bus_rules_Engine_Commission_Pymnt_For_Book_Physical_Product(304);
                UnitTest.Bus_rules_Engine_Send_Email_Membership_Activation_Upgrade(303);
                UnitTest.Bus_rules_Engine_Invalid_Order_Number(400);
                Console.WriteLine("-- Unit Testing Ended   --");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadKey();
        }
    }

    
    
 }
