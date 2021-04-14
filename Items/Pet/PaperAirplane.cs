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

			//Traduções
			DisplayName.AddTranslation(GameCulture.Portuguese, "Aviãozinho de papel");
			Tooltip.AddTranslation(GameCulture.Portuguese, "Evoque um avião de papel magico que te seguirá para sempre");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ZephyrFish);							// Clona o comportamento do ZephyrFish
			item.shoot = ProjectileType<Projectiles.Pets.PaperAirplane>();	// O pet é um disparo, seta o proprio pet
			item.buffType = BuffType<Buffs.PaperAirplane>();				// Adiciona o buff do pet pra remover o pet quando precisar
			
			item.value = Item.sellPrice(platinum: 1);						// Valor de venda
			item.value = Item.buyPrice(platinum: 100);						// Valor de compra

		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);				// Gera uma receita para o item atual.
			recipe.AddIngredient(ItemType<MagicPaper>(),25);	// Aponta 1 ingrediente e sua quantidade, por ser um ingrediente do mod fassa-se o chamado assim
			recipe.AddTile(TileID.WorkBenches);					// Adiciona o lugar que será criado o item, no saco será na bancada de trabalho
			recipe.SetResult(this);								// Seta o resultado seguido da quantidade, no caso é esta mesma classe seguido por 1 dele
			recipe.AddRecipe();									// Finaliza a receita

			// Apartir de agora o item MagicPaper terá uma tag de material e o guia terá a criação.

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
