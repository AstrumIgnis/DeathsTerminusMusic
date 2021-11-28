using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DeathsTerminusMusic.Items.Placeable
{
	public class MusicBox_Cata : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Cataclysmic Armageddon)");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("MusicBox_Cata");
			item.width = 30;
			item.height = 30;
			item.rare = 4;
			item.value = 100000;
			item.accessory = true;
		}
	}
}