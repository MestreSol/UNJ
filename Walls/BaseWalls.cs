using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;
using UNJ.Dusts;

namespace UNJ.Walls
{
    class BaseWalls : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            dustType = ModContent.DustType<BaseDust>();
            drop = ModContent.ItemType<Items.Placeable.Walls.BaseWall>();
        }
    }
}
