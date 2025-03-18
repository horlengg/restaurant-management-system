using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.app.utils
{
    class TableHelper
    {
        private static int TableCount = 40;
        public static List<string> GetTableList()
        {
            List<string> tableList = new List<string>();

            for (int i = 1; i <= TableCount; i++)
            {
                // Format the number with leading zeros (e.g., "001", "002", ..., "040")
                tableList.Add(i.ToString("D3"));
            }

            return tableList;
        }
    }
}
