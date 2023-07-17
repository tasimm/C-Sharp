// Archmage class

using System;

namespace MagicalInheritance
{
 class Archmage : Mage
 {
   public Archmage(string title) : base(title)
   {}

   public Archmage(string title, string origin) : base(title, origin)
   {}

   public override Storm CastRainStorm()
   {
     return new Storm("rain", Origin, true, Title);
   }

   public Storm CastLightningStorm()
   {
     return new Storm("lightning", Origin, true, Title);
   }
 }
}
