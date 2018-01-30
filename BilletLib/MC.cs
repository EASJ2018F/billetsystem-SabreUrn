using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib {
    public class MC : VehicleBase {
        public override int Price() {
            return 125;
        }

        public override string VehicleType() {
            return "MC";
        }
    }
}
