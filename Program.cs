using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Business_Rules_Engine_Console
{
    class Customer
    {
        Int32 cust_id;
        string cust_name;
        Hashtable customer_ht;

        /// <summary>
        /// Setting up hard-coded values for simplicity. Else it can be expanded to be setup 
        /// from the console menu
        /// </summary>
        public Customer()
        {
            customer_ht = new Hashtable();
            Console.WriteLine("Setting up Customers");
            cust_id = 101;
            cust_name = "Customer 1";
            customer_ht.Add(cust_id, cust_name);
            cust_id = 102;
            cust_name = "Customer 2";
            customer_ht.Add(cust_id, cust_name);
            cust_id = 103;
            cust_name = "Customer 3";
            customer_ht.Add(cust_id, cust_name);
            cust_id = 0;
            cust_name = "";
        }        
    }
    class Product : Customer
    {
        protected string Product_Type;
        protected string Product_name;
        Hashtable Products_ht;
        //Int32 cust_id; // A product can be for a specific customer or all customers 

        /// <summary>
        /// Setting up hard-coded values for simplicity. Else it can be expanded to be setup 
        /// from the console menu
        /// </summary>
        public Product()
        {
            Console.WriteLine("===Setting up Products===");
            Products_ht = new Hashtable();
            Product_Type = "Physical_product";
            Product_name = "Sanitizer";
            Products_ht.Add(Product_Type, Product_name);
            Product_Type = "Book";
            Product_name = "Alice in Wonderland";
            Products_ht.Add(Product_Type, Product_name);
            Product_Type = "Membership1";
            Product_name = "Activate";
            Products_ht.Add(Product_Type, Product_name);
            Product_Type = "Membership2";
            Product_name = "Upgrade";
            Products_ht.Add(Product_Type, Product_name);
            Product_Type = "Video1";
            Product_name = "Learning to Ski";
            Products_ht.Add(Product_Type, Product_name);
            Product_Type = "Video2";
            Product_name = "First Aid";
            Products_ht.Add(Product_Type, Product_name);
            Product_Type = "Video3";
            Product_name = "Other Videos";
            Products_ht.Add(Product_Type, Product_name);
            Product_Type = "";
            Product_name = "";
        }
    }

    /// <summary>
    /// Even though adding orders are transactions and not setup, here for the sake of simplicity, 
    /// we are pre-configuring the orders
    /// </summary>
    class Order : Product
    {
        Int32 order_no; // For future - to be auto-generated
        //DateTime order_date;
        Int32 cust_id;
        protected string Product_type;
        protected string Product_name;

        protected Hashtable Orders_ht;

        public Order()
        {
            Console.WriteLine("===Setting up Orders (pre-configured for simplicity)===");
            Orders_ht = new Hashtable();
            order_no = 300;
            cust_id = 101;
            Product_type = "Physical_product";
            Product_name = "Sanitizer";
            string order_cust = String.Concat(Convert.ToString(order_no));
            string prod_type_name = String.Concat(Convert.ToString(cust_id), "/", Convert.ToString(Product_type), "/", Convert.ToString(Product_name));
            Orders_ht.Add(order_cust, prod_type_name);
            order_no = 301;
            cust_id = 102;
            Product_type = "Video1";
            Product_name = "Learning to Ski";
            order_cust = String.Concat(Convert.ToString(order_no));
            prod_type_name = String.Concat(Convert.ToString(cust_id), "/", Convert.ToString(Product_type), "/", Convert.ToString(Product_name));
            Orders_ht.Add(order_cust, prod_type_name);
            order_no = 302;
            cust_id = 102;
            Product_type = "Video3";
            Product_name = "Other Videos";
            order_cust = String.Concat(Convert.ToString(order_no));
            prod_type_name = String.Concat(Convert.ToString(cust_id), "/", Convert.ToString(Product_type), "/", Convert.ToString(Product_name));
            Orders_ht.Add(order_cust, prod_type_name);
            order_no = 303;
            cust_id = 103;
            Product_type = "Membership1";
            Product_name = "Activate";
            order_cust = String.Concat(Convert.ToString(order_no));
            prod_type_name = String.Concat(Convert.ToString(cust_id), "/", Convert.ToString(Product_type), "/", Convert.ToString(Product_name));
            Orders_ht.Add(order_cust, prod_type_name);
            order_no = 304;
            cust_id = 103;
            Product_type = "Book";
            Product_name = "Alice in Wonderland";
            order_cust = String.Concat(Convert.ToString(order_no));
            prod_type_name = String.Concat(Convert.ToString(cust_id), "/", Convert.ToString(Product_type), "/", Convert.ToString(Product_name));
            Orders_ht.Add(order_cust, prod_type_name);
            order_no = 305;
            cust_id = 103;
            Product_type = "Membership2";
            Product_name = "Upgrade";
            order_cust = String.Concat(Convert.ToString(order_no));
            prod_type_name = String.Concat(Convert.ToString(cust_id), "/", Convert.ToString(Product_type), "/", Convert.ToString(Product_name));
            Orders_ht.Add(order_cust, prod_type_name);
            order_no = 0;
            cust_id = 0;
        }
    }


    class Payment : Order
    {
        Int32 payment_id; // To be auto-generated
        Int32 cust_id;
        Int32 order_no;
        new string Product_Type;
        new string Product_name;
        Int32 qty;
        float line_amt;
        float grand_total;

        public Boolean ReturnStatus;

        public Payment()
        {
            ReturnStatus = false;
        }


        /// <summary>
        /// Core Business logic here 
        /// </summary>
        public Payment(Int32 order_no1)
        {
            //string Product_type1 = "";

            Console.WriteLine(" Payment to be processed for Order # -> " + order_no1);
            Console.WriteLine("=== Entering and Processing Payment ===");
            /*ICollection keys = Orders_ht.Keys;
            
            foreach (String k in keys)
            {
                int hashcode = Orders_ht[k].GetHashCode();
                Console.WriteLine(hashcode + "/" + Orders_ht[k]);
                //Console.ReadKey();
            }*/
            bool match_found = Orders_ht.ContainsKey(Convert.ToString(order_no1));

            Console.WriteLine("match_found " + match_found);

            if (match_found == true)
            {
                ICollection keys = Orders_ht.Keys;

                foreach (String k in keys)
                {
                    Console.WriteLine(Orders_ht[k]);
                    //Console.ReadKey();
                }
                int i = 0;
                // foreach (String k in keys)
                //{
                string Order_cust = Orders_ht[Convert.ToString(order_no1)].ToString();
                string[] custnum = Order_cust.Split("/");
                string cust_num1 = custnum[0];
                Product_type = custnum[1];
                string Product_name1 = custnum[2];
                //}

                //order_no1 = 300;
                //Product_type = "Physical_product";
                switch (Product_type)
                {
                    case "Physical_product":
                        PackSlip pack1 = new PackSlip(Product_type, Product_name1);
                        Console.WriteLine("Product_type1 " + Product_type);
                        Commission_Payment commpay1 = new Commission_Payment();
                        Console.WriteLine("Return True - Transaction Successful");
                        ReturnStatus = true;
                        break;
                    case "Book":
                        PackSlip pack2 = new PackSlip(Product_type, Product_name1);
                        Console.WriteLine("Product_type1 " + Product_type);
                        Commission_Payment commpay2 = new Commission_Payment();
                        Console.WriteLine("Return True - Transaction Successful");
                        ReturnStatus = true;
                        break;
                    case "Membership1":
                        Membership memb1 = new Membership("Activate");
                        Console.WriteLine("Return True - Transaction Successful");
                        ReturnStatus = true;
                        break;
                    case "Membership2":
                        Membership memb2 = new Membership("Upgrade");
                        Console.WriteLine("Return True - Transaction Successful");
                        ReturnStatus = true;
                        break;
                    case "Video1":
                        PackSlip pack3 = new PackSlip(Product_type, Product_name1);
                        Console.WriteLine("Return True - Transaction Successful");
                        ReturnStatus = true;
                        break;
                    case "Video2":
                        PackSlip pack4 = new PackSlip(Product_type, Product_name1);
                        Console.WriteLine("Return True - Transaction Successful");
                        ReturnStatus = true;
                        break;
                    case "Video3":
                        PackSlip pack5 = new PackSlip(Product_type, Product_name1);
                        Console.WriteLine("Return True - Transaction Successful");
                        ReturnStatus = true;
                        break;
                    default:
                        Console.WriteLine("Product Type Undefined");
                        Console.WriteLine("Return True - Transaction Successful");
                        ReturnStatus = true;
                        break;
                }

            }
            else
            {
                Console.WriteLine("Matching Order number not found in the system.");
                ReturnStatus = true;
            }
            
        }
    }
    class Commission_Payment : Payment
    {
        public Commission_Payment()
        {
            if (Product_type.Equals("Book") || Product_type.Equals("Physical_product"))
            {
                Console.WriteLine("Commission Payment Generated for the agent");                
            }
        }
    }
    class PackSlip : Payment
    {
        Int32 packing_id;
        //Int32 payment_id;
        //Int32 cust_id;
        //Int32 order_no;
        //DateTime order_date;        
        //string Product_Type;
        //string Product_name;
        //Int32 qty;

        public PackSlip()
        {
        }

        public PackSlip(string Product_type1, string Product_name1)
        {
            Console.WriteLine("PackSlip Generated and Product added to packslip");
            Console.WriteLine("Product_type inside packslip constructor" + Product_type1);
            if (Product_type1.Equals("Book"))
            {
                Console.WriteLine("Duplicate PackSlip Generated for Royalty Department");
            }
            if (Product_type1.Equals("Video1"))
            {
                if (Product_name1.Equals("Learning to Ski"))
                {
                    Console.WriteLine("Free First Aid video added to Packing slip");
                }
            }            
        }

    }
    class Membership : Payment
    {
        public Membership()
        {
        }
        public Membership(string Product_name1)
        {
            Console.Write("Membership - ");
            Console.WriteLine(Product_name1 + "d");
            Console.WriteLine("... Email sent to owner that Membership has been - " + Product_name1);            
        }

    }
    class Rules : PackSlip
    {
        //Int32 rule_id;
        string rulename;
        //string description;
        //Int32 packing_id;
        //Int32 payment_id;
        //string Product_Type;
        int action_id;
        string action_descr;
        protected Hashtable Rules_ht;

        public Rules()
        {

            Console.WriteLine("===Setting up Orders (pre-configured for simplicity)===");
            Rules_ht = new Hashtable();
            rulename = "PYMNT_PHY_PROD";
            action_id = 1;
            action_descr = "Generate Pack Slip for Shipping";
            String rule_action = String.Concat(Convert.ToString(action_id), "_", action_descr);
            Rules_ht.Add(rulename, rule_action);

            ICollection keys = Rules_ht.Keys;

            foreach (String k in keys)
            {
                int hashcode = Rules_ht[k].GetHashCode();
                Console.WriteLine(hashcode + "/" + Rules_ht[k]);
                //Console.ReadKey();
            }

        }
    }
    public class DataSetup
    {
        public DataSetup()
        {
            Console.WriteLine("Calling customer class to setup customer data");
            Customer cust = new Customer();
            Console.WriteLine("Calling Product class to setup Product data");
            Product prod = new Product();
            Console.WriteLine("Calling Orders class to setup Pre-configured Orders data");
            Order order1 = new Order();
            Console.WriteLine("Calling Rules class to setup Pre-configured Rules data");
            Rules rules1 = new Rules();

        }
    }
    public class Transaction : DataSetup
    {
        public bool Trans_status = false;
        public Transaction()
        {
            Trans_status = false;
            Console.WriteLine("Entering Payment Transaction");
            string Order_num_str = Console.ReadLine();
            int Order_num = Convert.ToInt32(Order_num_str);
            Console.WriteLine("You entered Order number -> " + Order_num);
            Payment Pymnt = new Payment(Order_num);
            Trans_status = Pymnt.ReturnStatus;
            Console.WriteLine("Transaction status -> " + Trans_status);
        }
        public Transaction(int Order_num_str)
        {
            Console.WriteLine("Entering Payment Transaction");
            //string Order_num_str = Console.ReadLine();
            int Order_num = Convert.ToInt32(Order_num_str);
            Console.WriteLine("You entered Order number -> " + Order_num);
            Payment Pymnt = new Payment(Order_num);
            Trans_status = Pymnt.ReturnStatus;
            Console.WriteLine("Transaction status -> " + Trans_status);
        }
    }

    public class ConsoleMenu
    {

        public void Displaymenu()
        {
            Console.WriteLine("! =====              XYZ Company              ===== ! ");
            Console.WriteLine("! ===== Supply Chain Management and Logistics ===== ! ");
            Console.WriteLine("! =====       Business Rules Engine           ===== ! ");
            Console.WriteLine("Choose an option - 1 -> Setup ; 2 -> Payment Transaction ; 3 -> Exit ");
        }
        public ConsoleMenu()
        {

            string Option1;


            do
            {
                Displaymenu();
                Option1 = Console.ReadLine();
                //Option1 = Convert.ToInt32(val);
                Console.WriteLine("You selected option -> " + Option1);

                switch (Option1)
                {
                    case "1":
                        DataSetup setup1 = new DataSetup();
                        //Console.ReadKey();
                        break;

                    case "2":
                        Transaction trans = new Transaction();
                        //Console.ReadKey();
                        break;
                    case "3":
                        //Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("No function defined");
                        //Console.ReadKey();
                        break;
                }
                //Console.ReadLine();
                Console.WriteLine("! =====              XYZ Company              ===== ! ");
                Console.WriteLine("! ===== Supply Chain Management and Logistics ===== ! ");
                Console.WriteLine("! =====       Business Rules Engine           ===== ! ");
                Console.WriteLine("Choose an option - 1 -> Setup ; 2 -> Payment Transaction ; 3 -> Exit ");

                Option1 = Console.ReadLine();
                //Option1 = Convert.ToInt32(val);
                Console.WriteLine("You selected option -> " + Option1);
            } while (!(Option1.Equals("3")));
        }


    }
    public class Program
    {

        static void Main(string[] args)
        {
            ConsoleMenu conmenu = new ConsoleMenu();
        }


    }
}
