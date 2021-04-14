using Terraria;
using Terraria.ModLoader;

namespace UNJ.Buffs 
{
    class SolPurpura : ModBuff
    {
        public override void SetDefaults()
        {
            
            DisplayName.SetDefault("Sol Purpura");
            Description.SetDefault("A cor avermelhada do sol reluz sobre tudo que existe te deixando com medo");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; // Assim a enfermeira 
            canBeCleared = false; // Nao pode ser limpo

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense -= 12;
            player.statLifeMax -= 35;
        }
    }
}
