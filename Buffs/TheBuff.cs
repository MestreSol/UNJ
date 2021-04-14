using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
namespace UNJ.Buffs
{
    class TheBuff : ModBuff
    {
        public override void SetDefaults()
        {
            //Buff de teste que aplica todos os tipos de buff possiveis no jogo.

            DisplayName.SetDefault("O Buff");                                           // Nome Base
            Description.SetDefault("Hego olha pra voce com piedade");                   // Discrição base
            Main.debuff[Type] = false;                                                  // Garante que a nurse nao o remova
            canBeCleared = false;                                                       // Nao pode ser removido
            longerExpertDebuff = false;                                                 // Se verdadeiro, o buff ou debuff durará o dobro no modo expert

            //Traduções
            DisplayName.AddTranslation(GameCulture.English,"The Buff");
            Description.AddTranslation(GameCulture.English,"Hego see you with pity");   
            
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 2;              // Adiciona +2 de regenaração de vida
            player.statLifeMax2 += 15;          // Adiciona +15 de vida maxima
            player.meleeDamage += 0.08f;        // Mais dano magico
            player.magicDamage += 0.08f;        // Mais dano magico
            player.rangedDamage += 0.08f;       // Mais dano ranged
            player.thrownDamage += 0.08f;       // Mais dano rougue
            player.minionDamage += 0.08f;       // Mais dano summon
            player.meleeSpeed += 0.08f;         // Mais ataque speed
            player.moveSpeed += 0.08f;          // Mais move speed
            player.statDefense += 2;            // Mais defesa
            player.statManaMax2 += 35;          // Mais mana
            player.manaRegen += 2;              // Mais regeneração de mana    
            player.endurance += 1f;             // Quase imortal
            player.buffTime[buffIndex]= 50000;  // Define a duração do buff em segundos
        }
    }
}
