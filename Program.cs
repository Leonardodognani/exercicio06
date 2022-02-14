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
            Console.Write(p.Calculator(newSalary));

            Console.ReadKey();
            

        }

        private double Calculator(double salary)
        {

            double newSalary = 0;

            if(salary < 1700)
            {
                newSalary = (salary + 300);
            }
            else
            {
                newSalary = (salary + 200);
            }
            return newSalary;
        }
    }
}
