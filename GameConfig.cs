using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;
namespace UNJ
{
    class GameConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        
        // Sempre utilizar o Default pois, quando o mod carrega os arquivos sao reescritos, deixar uma declaração direta pode causar o retorno da configuração todas as veses
        // Desse modo quando a configuração mudar ela nao retornará para as configurações iniciais
        [DefaultValue(false)]
        [Label("Utilizar lingua da historia")]
        public bool LinguagemDoJogo; 

        //Nunca colocar o valor como Private ou Internal pois ele nao será exibido na tela de configuração
    }
}
