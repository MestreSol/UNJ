using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace UNJ.Items.Swords
{
    class BaseSword : ModItem
    {
		public override void SetStaticDefaults()
		{
			// Nome do item que aparecerá, sem essa definição o nome exibido será ClassName[ModName]
			DisplayName.SetDefault("A grande espada");

			// Descrição que aparece abaixo do item
			Tooltip.SetDefault("Uma espada forjada de metais rejeitados de testes fracaçados");

			
		}

		public override void SetDefaults()
		{
			//Definição geral
			item.damage = 800;              // Qual o dano do objeto?
			item.width = 100;               // Quais sao as dimençoes do objeto
			item.height = 50;
			item.useTime = 5;               // Tempo de espera para reutilizar o item
			item.useAnimation = 10;         // Duração da animação
			item.useStyle = 1;              // Estilo do ataque ou uso do objeto, Vide tabela
			item.knockBack = 6;             // Potencia do knockback
			item.rare = 2;                  // Rariadade
			item.UseSound = SoundID.Item1;  //Som do item
			item.autoReuse = true;          // Precionar para usar repetidamente

			//Definição de classe
			item.melee = true;              // O objeto é para Melee
			item.magic = false;             // O Objeto é para Mago?
			item.ranged = false;            // O Objeto é para Atirador?
			item.summon = false;            // O Objeto é para summon?

			//Definiçoes de compra e venda
			item.value = Item.buyPrice(platinum: 50, gold: 1, silver: 1, copper: 1); // Valor para compra
			item.value = Item.sellPrice(platinum: 0, gold: 0, silver: 0, copper: 1); // Valor para venda

			//Buffs
			item.buffTime = 50000;						// Duração do buff; +/- 13 min
			item.buffType = BuffType<Buffs.TheBuff>();	// Tipo do buff
		}

		//O item é criavel em uma estação de trabalho
		public override void AddRecipes()
		{

			ModRecipe recipe = new ModRecipe(mod);      // Inicia o contrutor de receitas
			recipe.AddIngredient(ItemID.DirtBlock, 10); // Adiciona o ingrediente, quantidade
			recipe.AddTile(TileID.WorkBenches);         // Adiciona em qual estação de trabalho voce deve estar para crialá
			recipe.SetResult(this);                     // Seta o resultado da receita
			recipe.AddRecipe();                         // Finaliza a construção

		}

    }

}
