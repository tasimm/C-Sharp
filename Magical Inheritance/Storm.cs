// Storm class inherits from the Spell class and holds the information for creating a Storm object and outputting it

using System;

namespace MagicalInheritance
{
  class Storm : Spell
  {

    public Storm(string essence, string origin, bool isStrong, string caster)
    {
      Essence = essence;
      Origin = origin;
      IsStrong = isStrong;
      Caster = caster;
    }

    public override string Announce()
    {
      if (IsStrong)
      {
        return $"{Caster} of {Origin} cast a strong {Essence} storm!";
      }
      else
      {
        return $"{Caster} of {Origin} cast a weak {Essence} storm!";
      }
    }
  }
}
