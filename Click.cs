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
    public class Click : StoryboardObjectGenerator
    {
        [Configurable]
        public int FadeTime = 200;  
        [Configurable]
        public double scaleStart = 1;  
        [Configurable]
        public double scaleEnd = 1.5;  
        [Configurable]
        public string SpritePath = "sb/pl.png";
        [ConfigurableAttribute]
        public Color4 color = Color4.White;
        public override void Generate()
        {
		   
            List<double> startTimes = new List<double>(){
                25036
            };
            foreach (var hitobject in Beatmap.HitObjects)
            {
                for(int i = 0 ; i < startTimes.Count ; i++){

                    if (startTimes[i] == hitobject.StartTime)
                    {
                        var Cursor = GetLayer("").CreateSprite(SpritePath,OsbOrigin.Centre,new Vector2(320,240));
                        Cursor.Color(startTimes[i],color);
                        Cursor.Fade(startTimes[i],1);
                        Cursor.Scale(startTimes[i],startTimes[i] + FadeTime,scaleStart,scaleEnd);
                        Cursor.Fade(startTimes[i] + 1 , startTimes[i] + 1 + FadeTime, 1 ,0);
                        Cursor.Move(startTimes[i],hitobject.Position);
                        Cursor.Rotate(OsbEasing.OutCirc,startTimes[i],startTimes[i] + FadeTime , 0 , -40);
                    }
                    else{
                        continue;
                    }   
                }
            }

        }
    }
}
