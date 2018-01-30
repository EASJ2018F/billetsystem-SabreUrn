using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib {
    public class MC : VehicleBase {
        public override int Price(bool brobizz = false) {
            int price = 125;
            if (brobizz) {
                double doublePrice = Convert.ToDouble(price);
                doublePrice = doublePrice * 0.95;
                price = (int)doublePrice;
            }
            return price;
        }

        public override string VehicleType() {
            return "MC";
        }
    }
}
