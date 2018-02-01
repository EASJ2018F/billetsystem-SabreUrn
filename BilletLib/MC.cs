using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib {
    public class MC : VehicleBase {
        public MC() {
            ØresundPriceDefault = 210;
            ØresundPriceBrobizz = 73;
        }

        public override int Price(string bridgeType, bool brobizz = false, bool weekend = false) {
            int price = 125;

            if(brobizz) {
                BrobizzDiscount(price, bridgeType);
            }
            return price;
        }

        public override string VehicleType(string bridgeType) {
            if(bridgeType == "Øresund") {
                return "Øresund MC";
            }
            return "MC";
        }
    }
}
