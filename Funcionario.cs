using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_funcionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            double salario = SalarioBruto - Imposto;

            return salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido();
        }
    }
}
