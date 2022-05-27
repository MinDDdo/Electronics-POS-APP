using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    static class ProductData
    {
        public static List<string> ProID = new List<string>();
        public static List<int> Proamount = new List<int>();
        public static List<int> amount = new List<int>();
        public static List<string> Proname = new List<string>();
        public static List<double> Proprice = new List<double>();
        public static List<int> amountBack = new List<int>();
        public static double ProTotal;

        public static void ClearData()
        {
            ProID.Clear();
            Proname.Clear();
            amountBack.Clear();
            amount.Clear();
            Proamount.Clear();
            Proprice.Clear();
        }
    }
}
