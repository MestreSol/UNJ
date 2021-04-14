using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.ModLoader.ModContent;
namespace UNJ.Items.Materials
{
    class MagicPaper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pergaminho magico");
            Tooltip.SetDefault("Escritas antigas fazem com que este pergaminho emita uma força estranha.");

            //Tradução
            DisplayName.AddTranslation(GameCulture.English, "Magic papyrus");
            Tooltip.AddTranslation(GameCulture.English, "Ancient writing make this papyrus send a strange force.");
        }
        public override void SetDefaults()
        {
            item.material = false;
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.rare = 6;

            item.value = Item.sellPrice(platinum: 0, gold: 0, silver: 0, copper: 50);
            item.value = Item.buyPrice(platinum: 0, gold: 0, silver: 1, copper: 0);
        }
    }
}
