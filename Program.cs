/*Desenvolva um algoritmo que calcule o reajuste salarial. Se o salário for abaixo de 1.700 o ajuste é 
de R$300.00, se maior de R$ 200.00. Para finalizar, exiba o novo salário na tela.
*/


namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {

            Double salary;

            Program p = new Program();

            Console.WriteLine("Por favor, digite seu salário para que possamos calcular o seu reajuste.");
            Console.Write("Digite aqui o seu salário. Não use ponto e nem vírgula: ");
            double.TryParse(Console.ReadLine(), out salary);

            Console.WriteLine();

            Console.WriteLine("Seu salário atual é de: {0}", salary);

            Console.WriteLine();

            Console.Write("Com o devido reajuste, o seu novo salário é de: ");
            salary = p.Calculator(salary);

            Console.Write(salary);

            Console.WriteLine();
            Console.ReadKey();
            

        }

        private double Calculator(double LEO)
        {

            double newSalary = 0;

            if(LEO < 1700)
            {
                newSalary = (LEO + 300);
            }
            else
            {
                newSalary = (LEO + 200);
            }
            LEO = 100;
            return newSalary;
        }
    }
}
