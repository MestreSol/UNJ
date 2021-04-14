using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace UNJ.Dusts
{
    class BaseDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            
            dust.velocity *= 0.8f;  // Velocidade de movimento da particula
            dust.noGravity = true;  // Particula sugeita a gravidade?
            dust.noLight = true;    // A particula emite Luz?
            dust.scale = 1.6f;      //  Scala da particula

        }

        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White;     // Cor da luz emitida
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;                     // Muda a possição 
            dust.rotation += dust.velocity.X * 0.5f;            // Rotaciona o objeto
            dust.scale *= 0.9f;                                 // Almenta a escala da particula
            var scale = (double)dust.scale;                     // VarDump da particula
            Lighting.AddLight(dust.position, 0.8f, 0.1f, 0.8f); // Adiciona a luz
            if ((double)dust.scale < 0.174999997019768)         // Some com o objeto apartir do tamanho
            {
                dust.active = false;                            // Some com a Dust
            }
            return false;                                       // Para a execução
        }

    }
}
