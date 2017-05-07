using System;

namespace FirstHWDeffClass
{
    public class Display
    {
        double _Size;
        int _NumberOfColors;
        public Display(double size = 3.2, int numberOfColors = 2)
        {
            this._Size = size;
            this._NumberOfColors = numberOfColors;
        }
        public int NumberOfColors
        {
            get
            {
                return this._NumberOfColors;
            }
            set
            {
                Validator(value, 5);
                this._NumberOfColors = value;
            }
        }

        public double Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                Validator(2, value);
                this._Size = value;
            }
        }

        public override string ToString()
        {
            return $"with {_NumberOfColors} colors and it's size is {_Size}";
        }

        private void Validator(int numberOfColors = 2, double size = 3.2)
        {
            if (numberOfColors <= 0 || size <= 0)
            {
                throw new ArgumentNullException("Please check your data");
            }
        }
    }
}
