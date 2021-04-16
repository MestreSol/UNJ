// Terraria
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

// Statics
using static Terraria.ModLoader.ModContent;

// Buff do Pet, usado para desativalo
namespace UNJ.Buffs
{
    class PaperAirplane : ModBuff
    {
		
		public override void SetDefaults()
		{
			// Padrao	
			DisplayName.SetDefault("Aviãozinho de papel");
			Description.SetDefault("Um exelente companheiro voador");
			
			// Defaults
			Main.buffNoTimeDisplay[Type] = true;	// Desabilita a vizualização de tempo
			Main.vanityPet[Type] = true;            // Diz que o Buff esta associado ao modulo de PET do inventario, Desativer este buff desativa a visualização do buff

			// Tradução Display
			DisplayName.AddTranslation(GameCulture.English,		"");	// Ingles
			DisplayName.AddTranslation(GameCulture.German,		"");	// Alemão
			DisplayName.AddTranslation(GameCulture.Italian,		"");	// Italiano
			DisplayName.AddTranslation(GameCulture.French,		"");	// Frances
			DisplayName.AddTranslation(GameCulture.Spanish,		"");	// Espanhol
			DisplayName.AddTranslation(GameCulture.Russian,		"");	// Russo
			DisplayName.AddTranslation(GameCulture.Chinese,		"");	// Chines simplificado
			DisplayName.AddTranslation(GameCulture.Portuguese,	"");	// Portugues
			DisplayName.AddTranslation(GameCulture.Polish,		"");	// Polones
			

		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[ProjectileType<Projectiles.Pets.PaperAirplane>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ProjectileType<Projectiles.Pets.PaperAirplane>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}
