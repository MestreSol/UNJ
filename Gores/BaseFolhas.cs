using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
namespace UNJ.Gores
{
    //Efeito de folhas caindo de arvore
    class BaseFolhas : ModGore
    {

        public override void OnSpawn(Gore gore)
        {
            gore.velocity = new Vector2(Main.rand.NextFloat()-0.5f,Main.rand.NextFloat()*MathHelper.TwoPi); // Randomiza a velocidade de queda das folhas
            gore.numFrames = 8; // Quantidade de frames que tem na imagem
            gore.frame = (byte)Main.rand.Next(8); // Variação do frame inicial
            gore.frameCounter = (byte)Main.rand.Next(8);
            updateType = 910;   
        }

    }
}
