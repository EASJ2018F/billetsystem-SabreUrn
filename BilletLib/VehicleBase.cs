using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib {
    public abstract class VehicleBase {
        private string _licensePlate;
        private DateTime _date;

        public string LicensePlate {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }
        public DateTime Date {
            get { return _date; }
            set { _date = value; }
        }

        public virtual int Price() {
            return 100;
        }

        public virtual string VehicleType() {
            return "";
        }
    }
}
