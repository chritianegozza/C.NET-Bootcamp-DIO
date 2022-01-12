using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    public class Program
    {

        public delegate void Operacao(int x, int y);

        public static void Main(string[] args)
        {
        

            Matematica m  = new Matematica(10, 20);
            m.Somar();

            //Operacao op = Calculadora.Somar;  Outra forma de fazer o denegeate
            //op(10, 10);
            
            //Operacao op = new Operacao(Calculadora.Somar); 
            //op += Calculadora.Subtrair;


            //op.Invoke(10, 10);




            //const double pi = 3.14;
            //System.Console.WriteLine(pi);

            //Data data = new Data();
            //data.SetMes(2);
            
            //data.Mes = 12;
            //System.Console.WriteLine(data.Mes);

            //data.ApresentarMes();




            //programa Log.cs quando usar tirar o comentario
            //Log log = Log.GetInstance();

            //log.PropriedadeLog = "Teste instancia";

            //Log log2 = Log.GetInstance();
            //System.Console.WriteLine(log2.PropriedadeLog);


             // programa aluno.css e pessoa.cs
            //Aluno p1 = new Aluno("Christiane", "Gozza", "Matemática");
            //p1.Apresentar();
        }
    }
}


