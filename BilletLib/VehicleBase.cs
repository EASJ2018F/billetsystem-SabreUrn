using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib {
    public abstract class VehicleBase {
        private string _licensePlate;
        private DateTime _date;
        private string _øresundType;
        private int _øresundPriceDefault;
        private int _øresundPriceBrobizz;

        public VehicleBase() {
        }

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

        public virtual string ØresundType {
            get { return _øresundType; }
            set { _øresundType = value; }
        }

        public int ØresundPriceDefault {
            get { return _øresundPriceDefault; }
            set { _øresundPriceDefault = value; }
        }

        public int ØresundPriceBrobizz {
            get { return _øresundPriceBrobizz; }
            set { _øresundPriceBrobizz = value; }
        }

        public abstract int Price(string bridgeType, bool brobizz = false, bool weekend = false);

        public abstract string VehicleType(string bridgeType);

        public int BrobizzDiscount(int price, string bridgeType) {
            if (bridgeType == "Øresund") {
                price = _øresundPriceDefault;
            } else {
                double brobizzPriceDouble = Convert.ToDouble(price);
                brobizzPriceDouble = brobizzPriceDouble * 0.95;
                price = (int)brobizzPriceDouble;
            }
            return price;
        }
    }
}