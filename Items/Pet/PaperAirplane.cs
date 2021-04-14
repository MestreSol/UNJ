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
using UNJ.Items.Materials;

namespace UNJ.Items.Pet
{
    class PaperAirplane : ModItem
    {
		public override void SetStaticDefaults()
		{
			// DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
			DisplayName.SetDefault("Aviãozinho de papel");
			Tooltip.SetDefault("Evoque um avião de papel magico que te seguirá para sempre");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = ProjectileType<Projectiles.Pets.PaperAirplane>();
			item.buffType = BuffType<Buffs.PaperAirplane>();
			
			item.value = Item.sellPrice(platinum: 1);
			item.value = Item.buyPrice(platinum: 100);

		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod); // Gera uma receita para o item atual.
			recipe.AddIngredient(ItemType<MagicPaper>(),25);
			recipe.AddTile(36);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}
