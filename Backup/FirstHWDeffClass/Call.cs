using System;

namespace FirstHWDeffClass
{
    public class Call
    {
        private DateTime _DateofCall;
        private TimeSpan _TimeOfCall;
        private string _DialedPhoneNumber;
        private ulong _Duration;


        public Call(ulong duration, DateTime dateTime, string dialedNumber = null )
        {

            this._Duration = duration;
            this._DialedPhoneNumber = dialedNumber;
            this._DateofCall = dateTime.Date;
            this._TimeOfCall = dateTime.TimeOfDay;
        }
        public DateTime DateOfCall
        {
            get
            {
                return this._DateofCall + _TimeOfCall;

            }
            set
            {
                this._DateofCall = DateOfCall.Date;
                this._TimeOfCall = _DateofCall.TimeOfDay;
            }
        }

        public string dialedPhoneNumber
        {
            get
            {
                return this._DialedPhoneNumber;
            }
            set
            {
                this._DialedPhoneNumber = dialedPhoneNumber;
            }
        }
        public ulong callDuration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this._Duration = value;
            }
        }
        public override string ToString()
        {
            return $"Date of call {_DateofCall} , time of call: {_TimeOfCall}, DialedNumber{_DialedPhoneNumber}, duration {_Duration} s";
        }

    }
}


