using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruchinina_Lab1_63Var.rrr
{
    class Integer : Number
    {
        public int A { get; set; }
        public override Number Add(Number n)
        {
            Integer? chis = n as Integer;
            return new Integer() { A=this.A+chis!.A};
        }

        public override Number Div(Number n)
        {
            Integer? chis = n as Integer;
            return new Integer() { A = this.A / chis!.A };
        }

        public override Number Mult(Number n)
        {
            Integer? chis = n as Integer;
            return new Integer() { A = this.A * chis!.A };
        }

        public override Number Sub(Number n)
        {
            Integer? chis = n as Integer;
            return new Integer() { A = this.A - chis!.A };
        }

        public override string? ToString()
        {
            return A.ToString();
        }
    }
}
