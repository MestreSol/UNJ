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
    class Frio : ModBuff
    {
        public bool isActive;
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Clima: Frio");
            Description.SetDefault("O frio lhe deixa debilitado");
            Main.pvpBuff[Type] = true;
            Main.debuff[Type] = false;
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;

        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen = player.lifeRegen - 2;
            player.jumpSpeedBoost -= 0.5f;
            player.maxRunSpeed = 0.5f;
            player.meleeSpeed = 0.5f;
            player.moveSpeed = 0.5f;

        }
    }
}
