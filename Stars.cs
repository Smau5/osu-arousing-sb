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
    public class Stars : StoryboardObjectGenerator
    {
        [Configurable]
        public string Path = "sb/star.png";

        [Configurable]
        public double StartTime;

        [Configurable]
        public double EndTime;
        [Configurable]
        public double duration = 500;

        public override void Generate()
        {
            //highbox
            Vector2 vector = new Vector2(-110,0);
            Vector2 vector2 = new Vector2(746,150);
            //lowbox
            Vector2 vector3 = new Vector2(21,150);
            Vector2 vector4 = new Vector2(523,213);
            var layer = GetLayer("stars");
            var pool =  new OsbSpritePool(layer, Path, OsbOrigin.Centre);
            for(double time = StartTime; time < EndTime; time = time + 100){
                var quantity = Random(5,10);
                for(int i = 0; i < quantity; i++){
                    double variance = Random(-200,200);
                    GenerateStars(time,duration + variance,pool,vector,vector2);
                    GenerateStars(time,duration + variance,pool,vector3,vector4);
                }
            }

        }
        public void GenerateStars(double time, double duration, OsbSpritePool pool, Vector2 vector, Vector2 vector2){
            List<OsbEasing> easing = new List<OsbEasing>();
            easing.Add(OsbEasing.InSine);
            easing.Add(OsbEasing.InCubic);
            easing.Add(OsbEasing.InQuad);
            var randX = Random(vector.X,vector2.X);
            var randY = Random(vector.Y,vector2.Y);
            var sprite = pool.Get(time,time + duration);
            var randScale = Random(0.03,0.07);
            var randIndex = Random(0,easing.Count);
            sprite.Fade(easing[randIndex],time,time + duration,1,0);
            sprite.Move(time,randX,randY);
            sprite.Scale(time,randScale);
            sprite.Rotate(time,Random(0,2));
        }
    }
}
