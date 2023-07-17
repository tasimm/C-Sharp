// Spell class
// Holds Essence, Origin, IsStrong, and Caster properties

using System;

namespace MagicalInheritance
{
  abstract class Spell
  {
    public string Essence
    { get; protected set; }

    public string Origin
    { get; protected set; }

    public bool IsStrong
    { get; protected set; }

    public string Caster
    { get; protected set; }

    public abstract string Announce();
  }
}
