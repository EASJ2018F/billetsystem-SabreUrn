using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib {
    public class Car : VehicleBase {
        public override int Price() {
            return 240;
        }

        public override string VehicleType() {
            return "Car";
        }
    }
}
