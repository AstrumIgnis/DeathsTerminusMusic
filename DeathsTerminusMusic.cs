using Terraria;
using Terraria.ModLoader;

namespace DeathsTerminusMusic
{
	public class DeathsTerminusMusic : Mod
	{
        public override void Load()
        {
            if (!Main.dedServ)
            {
                //Add music boxes
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Lights_Aerial_Veil"), ItemType("MusicBox_Cata"), TileType("MusicBox_Cata"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/idolatrizeWorld"), ItemType("MusicBox_Astrum"), TileType("MusicBox_Astrum"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/synthesizedAngel"), ItemType("MusicBox_Turing"), TileType("MusicBox_Turing"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/centerPiercing"), ItemType("MusicBox_Terry"), TileType("MusicBox_Terry"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/demetori"), ItemType("MusicBox_ImmuneCell"), TileType("MusicBox_ImmuneCell"));
                
            }
        }
    }
}
