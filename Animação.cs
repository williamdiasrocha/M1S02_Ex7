using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex7
{
    public static class Animação
    {
        public static void AnimaçãoNome()
        {
            Console.WriteLine("Animação Frozen");
        }

        public static void AnimaçãoNome(string nome)
        {
            Console.WriteLine("Animação " + nome);
        }

        static void Main()
        {
            AnimaçãoNome();
            AnimaçãoNome("Up");
            Console.ReadLine();
        }
    }
}
