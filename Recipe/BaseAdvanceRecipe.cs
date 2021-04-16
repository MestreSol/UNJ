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
namespace UNJ.Recipe
{
    public class BaseAdvanceRecipe : ModRecipe
    {
        public int NeededNPCType;   // ID do NPC que preciza estar proximo
     
        private const int Range = 480; // Distancia que deve estar do NPC para criar o item
        // 30 Tiles -> 30*16
        
        // Cria um costrutor para facilitar o acesso
        public BaseAdvanceRecipe(Mod mod, int NeededNPC) : base(mod) {
            NeededNPCType = NeededNPC; // Passa o NPC necessario por parametro
        }

        // Verifica se a receita pode ser criada
        public override bool RecipeAvailable()
        {

            bool foundNPC = false;

            // Validação se o Boss foi derrotado, se ele não foi derrotado a receita estará indisponivel
            if (!NPC.downedBoss1) {
                return false;
            }
            foreach (NPC npc in Main.npc) {
                // Valida apenas se vc esta perto do NPC correto
                if (!npc.active || npc.type != NeededNPCType) {
                    continue;
                }
                if (Main.LocalPlayer.DistanceSQ(npc.Center) <= Range *Range) {
                    foundNPC = true;
                    break;
                }
            }
            return foundNPC;

        }
        // Quando criado
        public override void OnCraft(Item item)
        {
            Main.LocalPlayer.AddBuff(BuffID.OnFire, 120); // Adiciona chamas
        }
    }
    public class AdvancedRecipeItem : ModItem {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Item Teste, Receitas avançadas");
            Tooltip.SetDefault("Lorem Ipsum");
        }
        public override string Texture => "UNJ/Items/ExampleItem";

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            BaseAdvanceRecipe recipe = new BaseAdvanceRecipe(mod, NPCID.Guide);
            recipe.AddIngredient(ItemID.DirtBlock,5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
