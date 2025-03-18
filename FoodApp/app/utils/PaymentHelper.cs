using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.app.utils
{
    class Payment
    {
        public static String Menual = "Menual";
        public static String KHQR = "KHQR";
        public static String VisaCard = "Visa Card";
    }
    class PaymentHelper
    {
        public static List<string> GetAllPaymementMethods()
        {
            List<string> paymentMethods = new List<string>
            {
                Payment.Menual,
                Payment.KHQR,
                Payment.VisaCard
            };
            return paymentMethods;
        }
    }
}
