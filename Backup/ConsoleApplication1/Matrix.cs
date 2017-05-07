using System;
using System.Text;

namespace HWDeffClass2
{
    public class Matrix<T>
    {
        private int _rows;
        private int _columns;

        public Matrix(int rows, int colls)
        {
            Validator(rows);
            this._rows = rows;

            Validator(colls);
            this._columns = colls;

            this.ma3x = new T[_rows, _columns];
        }

        public T[,] ma3x { get; private set; }

        public int Rows
        {
            get
            {
                return this._rows;
            }
            private set { }
        }

        public int Collumns
        {
            get
            {
                return this._columns;
            }
            private set { }
        }

        public T this[int rows, int columns]
        {
            get
            {
                return this.ma3x[rows, columns];
            }
            set
            {
                if (rows < 0 || rows > this._rows || columns < 0 || columns > this._columns)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.ma3x[rows, columns] = value;
            }
        }

        public void Add(T element, int row, int column)
        {
            if (row < 0 || row > this._rows || column < 0 || column > this._columns)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.ma3x[row, column] = element;
        }
        // Check the input for negative or zero values
        private void Validator(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Value must be greater than 0");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this._rows; i++)
            {
                for (int j = 0; j < this._columns; j++)
                {
                    sb.AppendFormat("{0} ", this.ma3x[i, j]);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public static Matrix<T> operator +(Matrix<T> M1, Matrix<T> M2)
        {
            if (M1.Rows != M2.Rows || M1.Collumns != M2.Collumns)
            {
                throw new ArgumentOutOfRangeException("Not possible to sum Matrix with unequal rows and columns");
            }
            Matrix<T> result = new Matrix<T>(M1.Rows, M1.Collumns);
            for (int i = 0; i < M1.Rows; i++)
            {
                for (int j = 0; j < M1.Collumns; j++)
                {
                    result[i, j] = (dynamic)M1[i, j] + M2[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> M1, Matrix<T> M2)
        {
            if (M1.Rows != M2.Rows || M1.Collumns != M2.Collumns)
            {
                throw new ArgumentOutOfRangeException("Not possible to substract Matrix with unequal rows and columns");
            }
            Matrix<T> result = new Matrix<T>(M1.Rows, M1.Collumns);
            for (int i = 0; i < M1.Rows; i++)
            {
                for (int j = 0; j < M1.Collumns; j++)
                {
                    result[i, j] = (dynamic)M1[i, j] - M2[i, j];
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> M1, Matrix<T> M2)
        {
            if (M1.Rows != M2.Collumns)
            {
                throw new ArithmeticException("Cannot multiply this Matrixes");
            }
            Matrix<T> result = new Matrix<T>(M1.Rows, M2.Collumns);
            for (int i = 0; i < M1.Rows; i++)
            {
                for (int j = 0; j < M1.Collumns; j++)
                {
                    result[i, j] = (dynamic)0;
                    for (int k = 0; k < M1.Rows; k++)
                    {
                        result[i, j] = result[i, j] + (dynamic)M1[i, k] * M2[k, j];
                    }
                }
            }
            return result;
        }
        public static bool operator true(Matrix<T> M)
        {
            for (int i = 0; i < M.Rows; i++)
            {
                for (int j = 0; j < M.Collumns; j++)
                {
                    if (M[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Added because it is not possible to define just true operator
        public static bool operator false(Matrix<T> M)
        {
            for (int i = 0; i < M.Rows; i++)
            {
                for (int j = 0; j < M.Collumns; j++)
                {
                    if (M[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}