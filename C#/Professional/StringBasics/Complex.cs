using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasics
{
    public struct Complex : IFormattable
    {
        private double real;
        private double imaginary;
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            var builder = new StringBuilder();
            if (format == "TEST")
            {
                builder.Append(this.GetType() + "\n");
                builder.AppendFormat(" действительная: \t{0}\n", real);
                builder.AppendFormat(" мнимая:\t\t{0}\n", imaginary);
            }
            else
            {
                builder.Append(" ( ");
                builder.Append(real.ToString(format, formatProvider));
                builder.Append(" : ");
                builder.Append(imaginary.ToString(format, formatProvider));
                builder.Append(" ) ");
            }
            return builder.ToString();
        }
    }
}
