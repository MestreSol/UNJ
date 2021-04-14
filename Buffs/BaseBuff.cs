using Terraria.ModLoader;
using Terraria.Localization; // Pucha a localização de onde o jogo esta sendo executado para efetuar a tradução
using Terraria; // Usado para puchar o player, NPCs, etc...
namespace UNJ.Buffs
{
    class BaseBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Teste de Buff");                        // Nome do Buff
            Description.SetDefault("Apenas um teste de buff nada de mais"); // Descrição do buff
            DisplayName.AddTranslation(GameCulture.English, "Testing Buff");// Tradução do buff
        }

        //Clase que puxa os atributos do player
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 100;    // Adiciona regenração de vida
            player.statLifeMax2 += 75;  // Adiciona uma sobre vida
        }
    }
}
