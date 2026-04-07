using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDSalon.Screens;
using Microsoft.Data.SqlClient;


namespace BDSalon
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Salon();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());



        }
    }

    public class Salon
    {
        public static Salon instance;
        public static Customer customer;
        private bool _isAdmin = false;
        public bool isAdmin
        {
            get
            {
                return _isAdmin;
            }
        }
        public static SqlConnection con = new SqlConnection(Server.IP);

        public Salon()
        {
            instance = this;
        }
        public string Register(Customer cus)
        {
            string result = "";
            con.Open();
            SqlDataReader reader = new SqlCommand("select email from Customer where email='" + cus.email + "'", con).ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                new SqlCommand("insert into Customer values ('" + cus.email + "','" + cus.pass + "','" + cus.firstName + "','" + cus.lastName + "'," + cus.age + "," + cus.phone + ")", con).ExecuteNonQuery();
                result = Datas.registerComplete;
            }
            else
            {
                reader.Close();
                result = Datas.registerAlreadyHave;
            }
            customer = cus;
            con.Close();
            return result;
        }
        public (string, Customer) Login(string email, string pass)
        {
            string result = "";
            con.Open();
            Customer cus = null;
            SqlDataReader reader = new SqlCommand("select * from Customer where email='" + email + "'", con).ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(1) == pass)
                {
                    result = Datas.loginComplete;
                    cus = new Customer(email, pass, reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                }
                else
                {
                    result = Datas.loginPassWrong;
                }
            }
            else
            {
                result = Datas.loginUserNotFound;
            }
            reader.Close();
            con.Close();
            if (cus != null)
            {


                _isAdmin = (cus.email == "hakuran@gmail.com");
                customer = cus;
            }
            return (result, cus);
        }

        public List<Customer> GetAlllCustomer()
        {
            List<Customer> cus = new List<Customer>();
            con.Open();
            SqlDataReader reader = new SqlCommand("select * from Customer order by email", con).ExecuteReader();
            while (reader.Read())
            {
                Customer cuss = new Customer(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                cus.Add(cuss);
            }
            reader.Close();
            con.Close();
            return cus;
        }
        public void Logout()
        {
            customer = null;
        }
        public string DeleteUserFormAdmin(string email)
        {
            string result = "";
            if (isAdmin)
            {
                con.Open();
                SqlDataReader reader = new SqlCommand("select count(*) from Customer where email='" + email + "'", con).ExecuteReader();
                reader.Read();
                int a = reader.GetInt32(0);
                reader.Close();
                if (a == 0)
                {
                    result = Datas.deleteUserUserNotFound;
                }
                else
                {
                    new SqlCommand("delete from Customer where email = '" + email + "'", con).ExecuteNonQuery();
                    result = Datas.deleteUserComplete;
                }
                con.Close();
            }
            return result;
        }
        public string AddOrder(string date, int time, int type)
        {
            string result = "";
            if (!isAdmin)
            {
                con.Open();
                CustomerTime cusTime = new CustomerTime(customer.email, date, 0);
                if (CanAddOrder(cusTime.time, time, Datas.serviceType[type].num))
                {
                    result = Datas.addOrderComplete;
                    new SqlCommand("insert into Orders values('" + customer.email + "', '" + date + "'," + time + " ," + type + ", 0 )", con).ExecuteNonQuery();
                }
                else
                {
                    result = Datas.addOrderNoTime;
                }
                con.Close();
            }
            return result;
        }
        public string RemoveOrder(string date, int time)
        {
            string result = "";
            if (!isAdmin)
            {
                con.Open();
                SqlDataReader reader = new SqlCommand("select count(*) from Orders where email='" + customer.email + "' and orderTime=" + time, con).ExecuteReader();
                reader.Read();
                int a = reader.GetInt32(0);
                reader.Close();
                if (a != 0)
                {
                    reader = new SqlCommand("select completed from Orders where email='" + customer.email + "' and orderTime=" + time, con).ExecuteReader();
                    reader.Read();
                    int comp = reader.GetInt32(0);
                    reader.Close();
                    if (comp == 0)
                    {
                        result = Datas.addOrderComplete;
                        new SqlCommand("delete from Orders where email='" + customer.email + "' and orderTime=" + time, con).ExecuteNonQuery();
                    }
                    else
                    {
                        result = Datas.removeOrderCompletedSoCant;
                    }

                }
                else
                {
                    result = Datas.removeOrderEmpty;
                }
                con.Close();
            }
            return result;
        }
        public string RemoveOrderForAdmin(string email, string date, int time)
        {
            string result = "";
            if (isAdmin)
            {
                con.Open();
                SqlDataReader reader = new SqlCommand("select count(*) from Orders where email='" + email + "' and orderTime=" + time, con).ExecuteReader();
                reader.Read();
                int a = reader.GetInt32(0);
                reader.Close();
                if (a != 0)
                {
                    result = Datas.addOrderComplete;
                    new SqlCommand("delete from Orders where email='" + email + "' and orderTime=" + time, con).ExecuteNonQuery();
                }
                else
                {
                    result = Datas.removeOrderEmpty;
                }
                con.Close();
            }
            return result;
        }
        public List<Order> GetAllOrderForCustomer()
        {
            con.Open();
            List<Order> orders = new List<Order>();
            SqlDataReader reader = new SqlCommand("select * from Orders where email='" + customer.email + "' order by orderDate, orderTime asc", con).ExecuteReader();
            while (reader.Read())
            {
                orders.Add(new Order(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4)));
            }
            reader.Close();
            con.Close();
            return orders;
        }
        public List<Order> GetAllOrderForCustomerInDay(string date)
        {
            con.Open();
            List<Order> orders = new List<Order>();
            SqlDataReader reader = new SqlCommand("select * from Orders where email='" + customer.email + "' and orderDate = '" + date + "' order by orderDate, orderTime asc", con).ExecuteReader();
            while (reader.Read())
            {
                orders.Add(new Order(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4)));
            }
            reader.Close();
            con.Close();
            return orders;
        }
        public List<Order> GetAllOrderForCustomerForAdmin(string email)
        {
            if (isAdmin)
            {
                con.Open();
                List<Order> orders = new List<Order>();
                SqlDataReader reader = new SqlCommand("select * from Orders where email='" + email + "' order by orderDate, orderTime asc", con).ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Order(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4)));
                }
                reader.Close();
                con.Close();
                return orders;
            }
            else
            {
                return new List<Order>();
            }
        }
        public List<Order> GetAllOrderForCustomerForAdminInDay(string email, string date)
        {
            if (isAdmin)
            {
                con.Open();
                List<Order> orders = new List<Order>();
                SqlDataReader reader = new SqlCommand("select * from Orders where email='" + email + "' and orderDate='" + date + "' order by orderDate, orderTime asc", con).ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Order(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4)));
                }
                reader.Close();
                con.Close();
                return orders;
            }
            else
            {
                return new List<Order>();
            }
        }
        public List<Order> GetAllOrderForAllCustomerForAdminInDay(string date)
        {
            if (isAdmin)
            {
                con.Open();
                List<Order> orders = new List<Order>();
                SqlDataReader reader = new SqlCommand("select * from Orders where orderDate='" + date + "' order by orderDate, orderTime asc", con).ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Order(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4)));
                }
                reader.Close();
                con.Close();
                return orders;
            }
            else
            {
                return new List<Order>();
            }
        }
        public List<Order> GetAllOrderForAllCustomerForAdmin()
        {
            if (isAdmin)
            {
                con.Open();
                List<Order> orders = new List<Order>();
                SqlDataReader reader = new SqlCommand("select * from Orders order by orderDate, orderTime asc", con).ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Order(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4)));
                }
                reader.Close();
                con.Close();
                return orders;
            }
            else
            {
                return new List<Order>();
            }
        }
        public string SetOrderComplete(string email, string date, int time, int comp)
        {
            string result = "";
            if (isAdmin)
            {
                con.Open();
                SqlDataReader reader = new SqlCommand("select count(*) from Orders where email='" + email + "' and orderDate = '" + date + "' and orderTime = " + time, con).ExecuteReader();
                reader.Read();
                int a = reader.GetInt32(0);
                reader.Close();
                if (a == 0)
                {
                    result = Datas.changeOrderCompleteNoOrder;
                }
                else
                {
                    new SqlCommand("update Orders set completed=" + comp + " where email='" + email + "' and orderDate = '" + date + "' and orderTime = " + time, con).ExecuteNonQuery();
                    result = Datas.changeOrderCompleteComplete;
                }
                con.Close();
            }
            return result;
        }
        bool CanAddOrder(bool[] b, int start, int end)
        {
            for (int i = start; i < start + end; i++)
            {
                if (b[i])
                {
                    return false;
                }
            }
            return true;
        }



        public int ViewAllMoney()
        {
            int num = 0;
            con.Open();
            SqlDataReader reader = new SqlCommand("select orderType from Orders where completed=1", con).ExecuteReader();
            while (reader.Read())
            {
                num += Datas.serviceType[reader.GetInt32(0)].price;
            }
            reader.Close();
            con.Close();
            return num;
        }
        TextBox textBox;
        public int ViewAllMoneyInDay(string date)
        {
            int num = 0;
            con.Open();
            SqlDataReader reader = new SqlCommand("select orderType from Orders where completed=1 and orderDate='" + date + "'", con).ExecuteReader();
            while (reader.Read())
            {
                num += Datas.serviceType[reader.GetInt32(0)].price;
            }
            reader.Close();
            con.Close();
            return num;
        }





        int initValue = 100;
        int currentValue;
        void ReadValue(){
            con.Open();
            SqlDataReader reader = new SqlCommand("select value from Test", con).ExecuteReader();
            reader.Read();
            currentValue = reader.GetInt32(0);
            reader.Close();
            con.Close();
        }
        void ResetData()
        {
            con.Open();
            currentValue = initValue;
            new SqlCommand("update Test set value="+initValue, con).ExecuteNonQuery();
            con.Close();
        }

        void Buy(int num){
            currentValue -= num;
            con.Open();
            new SqlCommand("update Test set value=" + currentValue, con).ExecuteNonQuery();
            con.Close();
        }
        public int GetValue(){
            return currentValue;
        }











    }
    public class CustomerTime
    {
        public bool[] time = new bool[24];
        public CustomerTime(string email, string date, int open = 1)
        {
            Load(email, date, open);
        }
        public void Load(string email, string date, int open)
        {
            if (open == 1)
                Salon.con.Open();
            SqlDataReader reader = new SqlCommand("select orderTime, orderType from Orders where email='" + email + "' and orderDate='" + date + "'", Salon.con).ExecuteReader();
            while (reader.Read())
            {
                int start = reader.GetInt32(0);
                int end = reader.GetInt32(1);
                for (int i = start; i < start + Datas.serviceType[end].timeLong; i++)
                {
                    time[i] = true;
                }
            }
            reader.Close();
            if (open == 1)
                Salon.con.Close();
        }
    }
    public class Customer
    {
        public string email;
        public string pass;
        public string firstName;
        public string lastName;
        public int age;
        public int phone;
        public Customer(string _email, string _pass, string _firstName, string _lastName, int _age, int _phone)
        {
            email = _email.ToLower();
            pass = _pass;
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            phone = _phone;
        }
    }
    public class Order
    {
        public string email;
        public string date;
        public int time;
        public int type;
        public int progress;
        public Order(string e, string d, int ti, int ty, int pro)
        {
            email = e;
            date = d;
            time = ti;
            type = ty;
            progress = pro;
        }
        public override string ToString()
        {
            return email + ", " + date + ", " + time + ", " + type;
        }
    }
}
