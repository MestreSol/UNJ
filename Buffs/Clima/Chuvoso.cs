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
    class Chuvoso : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Clima: Chuvoso");
            Description.SetDefault("A chuva te atrapalha um pouco");
            Main.debuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
            canBeCleared = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.jumpSpeedBoost -= 0.5f;
        }
    }
}
