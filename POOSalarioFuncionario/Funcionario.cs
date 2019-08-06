using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace POOSalarioFuncionario
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public double imposto;

        public double SalComImp()
        {
            return salario - imposto;
        }
        public void Aumento(double porcentagem)
        {
                salario += (salario * porcentagem / 100.0);
        }
        public override string ToString()
        {
            return "Funcionario: "+nome + ", R$" + SalComImp().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
