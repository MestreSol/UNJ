using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
namespace UNJ.Buffs.Clima
{
    class MuitoFrio : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Clima: Muito Frio");
            Description.SetDefault("O vento frio corta sua pele");
            Main.pvpBuff[Type] = true;
            Main.debuff[Type] = false;
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;

        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen = player.lifeRegen - 5;
            player.jumpSpeedBoost -= 0.9f;
            player.maxRunSpeed -= 0.9f;
            player.meleeSpeed -= 0.9f;
            player.moveSpeed -= 0.9f;

        }
    }
}
