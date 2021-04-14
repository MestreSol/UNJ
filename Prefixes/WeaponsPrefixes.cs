using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
namespace UNJ.Prefixes
{
    class NotFound : ModPrefix
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("404 - "); // 404 - A Grande espada
        }
        
        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult = 1.5f; 
            useTimeMult = 1.5f;
            shootSpeedMult = 1.5f;
            critBonus = 15;
        }
        public override PrefixCategory Category => PrefixCategory.AnyWeapon;
    }
}
