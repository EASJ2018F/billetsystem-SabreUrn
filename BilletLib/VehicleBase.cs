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
            set {
                if (value.Length > 7) {
                    throw new ArgumentException();
                }
                _licensePlate = value;
            }
        }
        public DateTime Date {
            get { return _date; }
            set { _date = value; }
        }

        public abstract int Price(bool brobizz = false);

        public abstract string VehicleType();
    }
}
