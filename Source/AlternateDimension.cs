using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System;
using System.Linq;
using Terraria.ModLoader.IO;
namespace UNJ.Source
{
    class AlternateDimension : ModWorld
    {
       /* private const int WorldVersion = 0;
        List<Dimension> loadedDimensions = new List<Dimension>();
        List<Dimension> existsInWorldDimension = new List<Dimension>();
        internal Dimension curDimension;
        public void Load() {
            loadedDimensions.Clear();
        }
        public void Unload() { 
            
        }
        public override void Initialize()
        {
            if (Main.netMode == 1) // Quando multiplayer
            {
                Dimension vanila = existsInWorldDimension.FirstOrDefault(x => x.modName == "Vanila");
                if (vanila != null)
                {
                    SetSection(vanila);
                }
                else
                {

                }
            }
            else {
                //existsInWorldDimension();
            }
        }
        public override TagCompound Save()
        {
            if (existsInWorldDimension.Count == 0) {
                existsInWorldDimension.Add(new Dimension(0, "Vanila", "vanilaArea", new Rectangle(0, 0, 0, 0)));
            }
            TagCompound tag = new TagCompound
            {
                ["saveVersion"] = WorldVersion,
                ["Dimensions"] = existsInWorldDimension.Select(Dimension.Save).ToList(),
            };
            return tag;
        }

        public override void Load(TagCompound tag)
        {
            int version = tag.GetInt("saveVersion");
            existsInWorldDimension = new List<Dimension>(tag.GetList<TagCompound>("Dimensions").Select(Dimension.Load));
            Dimension vanilla = existsInWorldDimension.FirstOrDefault(x => x.modName == "Vanila");
            if (vanilla != null)
            {
                if (!Main.dedServ)
                {
                    SetSection(vanilla);
                }
            }
            else { 
            
            }
                }
        public void SetSection(Dimension section) {
            curDimension = section;
            if (Main.dedServ) { 
            
            }
            Main.leftWorld = section.Area.Left * 16;
            Main.rightWorld = section.Area.Right * 16;
            Main.topWorld = section.Area.Top * 16;
            Main.bottomWorld = section.Area.Bottom * 16;

            if (section.Area.Left == 0 || section.Area.Right == 0 || section.Area.Top == 0 || section.Area.Bottom == 0) {
                Main.leftWorld = 100 * 16;
                Main.rightWorld = 100 * 16;
                Main.topWorld = 100 * 16;
                Main.bottomWorld = 100 * 16;
            }
        }
        static bool debug = false;
        public static void DebugText(String Mensage) { 
            
        }
    }


    public class Dimension {
        public const int saveversion = 0;
        internal int index;
        internal string modName;
        internal string areaName;
        internal Rectangle Area;
        internal Action<Rectangle> generateCode;

        public Dimension(int index, string modname, string areaname, Rectangle area) {
            this.index = index;
            this.modName = modname;
            this.areaName = areaname;
            this.Area = area;
        }
        public Dimension(string modname,string areaname, Action<Rectangle> generatecode) {
            this.modName = modname;
            this.areaName = areaname;
            this.generateCode = generatecode;
        }
        public override string ToString()
        {
            return $"I:{index} MN:{modName} AN:{areaName} L:{Area.Left} R:{Area.Right} T:{Area.Top} B:{Area.Bottom}";
        }
        public static TagCompound Save(Dimension dimension) {
            var tag = new TagCompound();
            tag.Set("saveversion",Dimension.saveversion);
            tag.Set("index", dimension.index);
            tag.Set("modname", dimension.modName);
            tag.Set("areaname", dimension.areaName);
            tag.Set("area", dimension.Area);
            return tag;
        }
        public static Dimension Load(TagCompound tag) {
            int saveversion = tag.GetInt("saveversion");
            int index = tag.GetInt("index");
            string modname = tag.GetString("modname");
            string areaname = tag.GetString("areaname");
            Rectangle area = tag.Get<Rectangle>("area");
            Dimension result = new Dimension(index, modname,areaname,area);
            return result;
        }*/
    }
}

