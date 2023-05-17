using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <IFlyable> voladores= new List <IFlyable>();
            voladores.Add(new Canario());
            voladores.Add(new Aguila());

            foreach (IFlyable item in voladores)
            {
                Console.WriteLine(item.volar());
                Animal item2 = (Animal)item;
                Console.WriteLine(item2.comunicarse());
            }

            List<IScrambleable> trepadores = new List<IScrambleable>();
            trepadores.Add(new Gato());
            trepadores.Add(new Mono());

            foreach (var item in trepadores)
            {
                Console.WriteLine(item.trepar());
                Animal item2 = (Animal)item;
                Console.WriteLine(item2.comunicarse());
            }
        }
    }
}
