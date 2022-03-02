namespace Rpg.src.Entities;
using static System.Console;
class Program
{
   static void Main(string[] args)
  {
    Knight arus = new Knight("Arus", 12,"knight");
    Wizard wizard = new Wizard("Jennica", 22,"Wizard");
    BlackWizard topapa = new BlackWizard("Topapa", 52, "Black Wizard");
    Ninja wedge = new Ninja("Wedge", 100, "Ninja");   

    WriteLine(arus.Attack());
    WriteLine(wizard.Attack(3));
    WriteLine(wizard.Attack(13));
    WriteLine(topapa.Attack());
    WriteLine(wedge.Attack());
    WriteLine(wedge.Attack(5));
    WriteLine(wedge.Attack(1));
  }
}
