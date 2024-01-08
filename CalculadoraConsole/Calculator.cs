namespace CalculadoraConsole
{
    public class Calculator : IOperations
    {
        public double N1 {  get; set; }    
        public double N2 { get; set; }

        public void Calcule(Func<double> operation)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Responsta é: {operation()}");
            Console.ResetColor();
        }
        public double Division()
        {
            if (N2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir nenhum número por 0!");

            }
            return N1 / N2;
        }

        public double Multiplication()
        {
            return N1 * N2;
        }

        public double Subtraction()
        {
            return N1 - N2;
        }

        public double Sum()
        {
            return N1 + N2;
        }
    }
}
