namespace ex_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(); //criando a variavel da classe e instanciando

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumentarSal = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(aumentarSal);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}
