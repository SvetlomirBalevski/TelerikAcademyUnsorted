using System;

namespace FirstHWDeffClass
{
    public class Battery
    {
        BatteryType _BatteryModel;
        double _IdleHours;
        double _HoursTalk;
        public Battery(BatteryType Model = BatteryType.LiON, double idleHours = 0, double hoursTalk = 0)
        {
            this._BatteryModel = Model;
            this._IdleHours = idleHours;
            this._HoursTalk = hoursTalk;
        }
        public double IdleHours
        {
            get
            {
                return _IdleHours;
            }
            set
            {
                Validator(value, 0);
                this._IdleHours = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return _HoursTalk;
            }
            set
            {
                Validator(0, value);
                this._HoursTalk = value;
            }
        }


        public BatteryType type
        {
            get
            {
                return _BatteryModel;
            }
            set
            {
                this._BatteryModel = value;
            }
        }

        public override string ToString()
        {

            return $"{_BatteryModel}. Idle Hours of this battery are {IdleHours} and the it is used for {HoursTalk} hours talking";
        }


        private void Validator(double idleHours, double hoursTalk)
        {
            if (idleHours < 0 || hoursTalk < 0)
            {
                throw new ArgumentNullException("Please check your data");
            }
        }

        public enum BatteryType
        {
            LiON,
            NiMH,
            NiCd,
            AAA

        }

    }
}
