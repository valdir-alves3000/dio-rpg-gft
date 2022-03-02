namespace Rpg.src.Entities;
public class BlackWizard : Hero
{
  public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
  {}
  public override string Attack()
  {
    return $"{this.Name} Lançou Nuvem negra";
  }
}