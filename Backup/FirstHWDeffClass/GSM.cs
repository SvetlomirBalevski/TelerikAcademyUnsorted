using System;
using System.Collections.Generic;

namespace FirstHWDeffClass
{
    public class GSM
    {
        private string _Model;
        private string _Manifacturer;
        private double _Price;
        private string _Owner;
        private Battery _Battery;
        private Display _Display;
        private List<Call> _CallHistory = new List<Call>();

        public static readonly GSM Iphone4 = new GSM("Iphone4s", "Apple", "Somebody owning Iphone", new Battery(Battery.BatteryType.LiON), new Display(3.2, 2), 1800);

        public string Model
        {
            get
            {
                return this._Model;
            }
        }

        public string Manifacturer { get; }

        public double Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("You should give money for it");
                }
                else
                {

                    this._Price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this._Owner;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Please enter owner's name");
                }
                else
                {
                    this._Owner = Owner;
                }
            }
        }

        public GSM(string model, string manifacturer)
        {
            if (model == string.Empty || manifacturer == string.Empty)
            {
                throw new ArgumentNullException("The GSM Should be manifacured somewhere by someone");
            }

            this._Model = model;
            this._Manifacturer = manifacturer;
            this._Battery = new Battery();
        }

        public GSM(string model, string manifacturer, string owner, Battery baterry, Display display, double price = 0.0)
            : this(model, manifacturer)
        {

            if (price < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            this._Price = price;
            this._Owner = owner;
            this._Display = display;
            //this._Battery.HoursTalk = baterry.HoursTalk;
            this._Battery = baterry;
        }


        public List<Call> CallHistory
        {
            get
            {
                return _CallHistory;
            }
        }

        public override string ToString()
        {
            string gsmInfo = "";
            gsmInfo = $"{_Owner} Phone is {_Manifacturer} {_Model} and it costs {_Price}. It's Battery is {_Battery.ToString()}. It's display is {_Display.ToString()}";
            return gsmInfo;
        }

        public void AddCall(Call call)
        {
            _CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            _CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            _CallHistory.Clear();
        }

        public double CalculateCallPrice(double callPrice)
        {
            double sum = 0;

            foreach (var calls in _CallHistory)
            {
                sum += calls.callDuration * callPrice;
            }
            return sum;
        }

    }
}
