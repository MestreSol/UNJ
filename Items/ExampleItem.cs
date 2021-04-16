using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
namespace UNJ.Items
{
    class ExampleItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Apenas um teste");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = ItemRarityID.Blue;
        }
    }
}
