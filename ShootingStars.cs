using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class ShootingStars : StoryboardObjectGenerator
    {
        [Configurable]
        public string Path = "sb/ShootingStar.png";

        [Configurable]
        public double StartTime;

        [Configurable]
        public double EndTime;
        

        public override void Generate()
        {
            double duration = 2000;
            Vector2 vector = new Vector2(325,-300);
            var layer = GetLayer("ShootingStar");
            var pool =  new OsbSpritePool(layer, Path, OsbOrigin.Centre);
            for(double time = StartTime; time < EndTime; time = time + 100){
                var quantity = Random(1,5);
                for(int i = 0; i < quantity; i++){
                    double variance = Random(-200,200);
                    GenerateStars(time,duration + variance,pool,vector);
                }
            }

        }
        public void GenerateStars(double time, double duration, OsbSpritePool pool, Vector2 vector){
            var sprite = pool.Get(time,time + duration);
            var randScale = Random(0.3,0.5);
            sprite.Fade(0,0);
            sprite.Fade(time + duration - 900,time + duration - 700,0,0.7);
            sprite.Fade(time + duration - 700,time + duration -200,0.7,0);
            var finalX = Random(-200,850);
            var finalY = Random(138,334);
            sprite.Move(time,time + duration,vector,new Vector2(finalX,finalY));
            sprite.Scale(time + duration - 900,time + duration -200,randScale,Random(0.6,1));
            var angleRadians = Math.Atan2(vector.Y - finalY,vector.X -  finalX);
            sprite.Rotate(time,angleRadians);
            
        }
    }
}
