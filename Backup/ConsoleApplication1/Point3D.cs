using System.Text;

namespace HWDeffClass2
{
    public struct Point3D
    {
        private double _Xcord;
        private double _Ycord;
        private double _Zcord;

        public double Xcord
        {
            get
            {
                return this._Xcord;
            }
            set
            {
                this._Xcord = Xcord;
            }
        }
        public double Ycord
        {
            get
            {
                return this._Ycord;
            }
            set
            {
                this._Xcord = Ycord;
            }
        }
        public double Zcord
        {
            get
            {
                return this._Zcord;
            }
            set
            {
                this._Xcord = Zcord;
            }
        }

        private static readonly Point3D CordSystemZero;

        public static string GetCordZero()
        {
            return CordSystemZero.ToString();
        }

        public Point3D(double x = 0, double y = 0, double z = 0)
        {
            this._Xcord = x;
            this._Ycord = y;
            this._Zcord = z;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"X: {this.Xcord}; Y: {this.Ycord}; Z: {this.Zcord}");
            return sb.ToString();
        }


    }
}
