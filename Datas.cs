using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDSalon
{
    public class Datas 
    {
        public const string registerComplete = "success";
        public const string registerAlreadyHave = "user already have";
        public const string registerOtherError = "register error";
        public const string loginComplete = "success";
        public const string loginUserNotFound = "user not found";
        public const string loginPassWrong = "password not match";
        public const string loginOtherError = "login error";
        public const string addOrderComplete = "complete";
        public const string addOrderError= "error";
        public const string addOrderNoTime = "no time";
        public const string removeOrderEmpty = "empty";
        public const string removeOrderCompletedSoCant = "completed, so cant remove";
        public const string removeOrderError = "remove error";
        public const string changeOrderCompleteComplete = "complete";
        public const string changeOrderCompleteNoOrder = "no order";
        public const string changeOrderCompleteError = "error";
        public const string deleteUserComplete ="complete";
        public const string deleteUserUserNotFound ="user not found";
        public const string deleteUserError ="error";


        public static List<SalonServiceType> serviceType = new List<SalonServiceType> {
            new SalonServiceType(0, "Uszasah", 1, 10000),
            new SalonServiceType(1, "Hums ynzlah", 1, 10000),
            new SalonServiceType(2, "Us budah", 3, 10000),
            new SalonServiceType(3, "Us ynzlah", 2, 10000),
            new SalonServiceType(4, "Massage", 3, 10000),
            new SalonServiceType(5, "Nuur ynzlah", 1, 10000),
        };
        public static string GetDateToday()
        {
            DateTime time = DateTime.Today;
            return time.Year + "." + (time.Month < 10 ? "0" : "") + time.Month + "." + (time.Day < 10 ? "0" : "") + time.Day;
        }

    }
    public class SalonServiceType
    {
        public int num;
        public string name;
        public int timeLong;
        public int price;
        public SalonServiceType(int n, string na, int t, int p)
        {
            num = n;
            name = na;
            timeLong = t;
            price = p;
        }
    }
}
