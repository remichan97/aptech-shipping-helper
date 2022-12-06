using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Common.Methods
{
    public class MapHelper
    {
        public static string AppendToMapAddress(string address, string city)
        {
            return address.Replace(" ", "+") + "," + city;
        }
    }
}
