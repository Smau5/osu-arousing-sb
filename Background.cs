using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Storyboarding.Util;
using System;
namespace StorybrewScripts
{
    public class Background : StoryboardObjectGenerator
    {

        public override void Generate()
        {
            var BackgroundPath = Beatmap.BackgroundPath;

            var bitmap = GetMapsetBitmap(BackgroundPath);
            var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            bg.Scale(3583, 480.0f / bitmap.Height);
            bg.Fade(3583, 1);
            bg.Fade(14309, 0);

            var bgRed = GetLayer("red").CreateSprite("sb/2.jpg",OsbOrigin.Centre);
            bgRed.Scale(14309,480.0f / bitmap.Height);
            bgRed.Fade(14309,1);
            bgRed.Fade(26376,0);
            

            var bgWhite = GetLayer("White").CreateSprite("sb/white.jpg", OsbOrigin.Centre);
            var bitmapWhite = GetMapsetBitmap("sb/white.jpg");
            bgWhite.Scale(3583, 480.0f / bitmapWhite.Height);
            bgWhite.Fade(3583,6265, 0.5,0);
            bgWhite.Fade(12969,13304, 0.5,0);


            bgWhite.Fade(12969,13304, 0.3,0);
            bgWhite.Fade(13304,13471,0.3,0);
            bgWhite.Fade(13639,13807,0.5,0);
            bgWhite.Fade(13807,13974,0.5,0);
            bgWhite.Fade(13974,14309,0.5,0);

            bgWhite.Fade(16153,16320,0,0.3);
            bgWhite.Fade(16320,16991,0.3,0);

            bgWhite.Fade(16991,18332,0.4,0);


            var zoomRed = GetLayer("zoomRed").CreateSprite("sb/2.jpg",OsbOrigin.Centre);
            var redScale = 480.0f / bitmap.Height;

            zoomRed.Scale(16320,16991, redScale * 1.15, redScale );
            zoomRed.Fade(16320,16991,0.7,0);
            zoomRed.Fade(16991,0);



            var bgBlur = GetLayer("Blur").CreateSprite("sb/BGBlur.png", OsbOrigin.Centre);
            var bitmapBlur = GetMapsetBitmap("sb/BGBlur.png");
            bgBlur.Scale(1572, 480.0f / bitmapBlur.Height);
            bgBlur.Fade(1572,3582, 0,0.9);
            bgBlur.Fade(3583,0);

            var zoom = GetLayer("zoom").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            var scale = 480.0f / bitmap.Height;
            zoom.Scale(12969,13304, scale * 1.1, scale );
            zoom.Fade(12969,13304,1,0);

            zoom.Scale(14309,15650, scale , scale * 1.2);
            zoom.Fade(14309,15650,0.7,0);



            var noise1 = GetLayer("noise").CreateSprite("sb/noise1.png", OsbOrigin.Centre);
            var bitmapNoise1 = GetMapsetBitmap("sb/noise1.png");
            noise1.Scale(13304,480.0f / bitmapNoise1.Height);
            noise1.Fade(0,0);

            var noise2 = GetLayer("noise").CreateSprite("sb/noise2.png", OsbOrigin.Centre);
            var bitmapNoise2 = GetMapsetBitmap("sb/noise2.png");
            noise2.Scale(13304,480.0f / bitmapNoise2.Height);
            noise2.Fade(13304,scale);
            noise2.Fade(0,0);

            List<OsbSprite> bgNoise = new List<OsbSprite>();

            bgNoise.Add(noise1);
            bgNoise.Add(noise2);
            GenerateNoise(13304,13974,bgNoise);
            GenerateNoise(16320,16991,bgNoise);

            var highlight = GetLayer("highlight").CreateSprite("sb/highlight.png",OsbOrigin.Centre);
            highlight.Fade(OsbEasing.InCubic,11293,12969,0,1);
            highlight.Scale(OsbEasing.InCubic,11293,12969,0.1,7);
            highlight.Move(11293,317,421);

            highlight.Fade(12969,0);

            var mask = GetLayer("mask").CreateSprite("sb/Border Mask.png",OsbOrigin.Centre);
            var maskBitmap = GetMapsetBitmap("sb/Border Mask.png");
            mask.Scale(14309,480.0f / maskBitmap.Height);
            mask.Fade(14309,1);
            mask.Fade(26376,0);

        }
        public void GenerateNoise(double startTime, double endTime, List<OsbSprite> bgNoise){
            int turn = 0;
            for(double time = startTime; time < endTime; time = time + 10){
                bgNoise[turn].Fade(time,0.5);
                bgNoise[turn].Fade(time+10,0);
                turn++;
                if(turn>1){
                    turn = 0;
                }
            }
        }
    }
}
