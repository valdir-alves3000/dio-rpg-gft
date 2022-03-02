namespace Rpg.src.Entities;

public class Ninja : Hero
{
  public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
  {}
  public override string Attack()
  {
    return $"{this.Name} Lançou poder ninja";
  }
  public string Attack(int stars)
  {
   if(stars > 1)
   {
      return $"{this.Name} Lançou {stars} estrelas de prata";
    }
    else
    {
       return $"{this.Name} Lançou {stars} estrela de prata";
    }
  }
}