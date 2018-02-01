using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib {
    public class Car : VehicleBase {
        public Car() {
            ØresundPriceDefault = 410;
            ØresundPriceBrobizz = 161;
        }

        public override int Price(string bridgeType, bool brobizz = false, bool weekend = false) { 
            int price = 240;
            if(weekend) {
                WeekendDiscount(price, bridgeType);
            }

            if(brobizz) {
                BrobizzDiscount(price, bridgeType);
            }
            return price;
        }

        public override string VehicleType(string bridgeType) {
            if(bridgeType == "Øresund") {
                return "Øresund Car";
            }
            return "Car";
        }

        public int WeekendDiscount(int price, string bridgeType) {
            if (VehicleType(bridgeType) != "Øresund MC") {
                double weekendPriceDouble = Convert.ToDouble(price);
                weekendPriceDouble = weekendPriceDouble * 0.80;
                price = (int)weekendPriceDouble;
            }
            return price;
        }
    }
}
