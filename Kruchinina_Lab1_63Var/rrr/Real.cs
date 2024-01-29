using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruchinina_Lab1_63Var.rrr
{
    class Real : Number
    {
        public double A { get; set; }
        public override Number Add(Number n)
        {
            Real? chis = n as Real;
            return new Real() { A = this.A + chis!.A };
        }

        public override Number Div(Number n)
        {
            Real? chis = n as Real;
            return new Real() { A = this.A / chis!.A };
        }

        public override Number Mult(Number n)
        {
            Real? chis = n as Real;
            return new Real() { A = this.A * chis!.A };
        }

        public override Number Sub(Number n)
        {
            Real? chis = n as Real;
            return new Real() { A = this.A - chis!.A };
        }

        public override string? ToString()
        {
            return A.ToString("F2");
        }
    }
}