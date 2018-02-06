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
    public class CursorFollow : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 1271;

        [Configurable]
        public int EndTime = 135165;

        [Configurable]
        public int BeatDivisor = 8;

        [Configurable]
        public int FadeTime = 200;
        
        [Configurable]
        public bool Color = true;
        
        [Configurable]
        public bool Horizontal = false;

        [Configurable]
        public string SpritePath = "sb/pl.png";
        public override void Generate()
        {
		    var CursorLayer = GetLayer("");
            var Cursor = CursorLayer.CreateSprite(SpritePath,OsbOrigin.Centre,new Vector2(320,240));
            Cursor.Fade(OsbEasing.None,StartTime,StartTime + 100,0,1);
            Cursor.Fade(OsbEasing.None,EndTime - 100,EndTime,1,0);
            if(Horizontal)
            {
                Cursor.Rotate(0,1.5708);
            }
            var beat = Beatmap.GetTimingPointAt(StartTime);
            var BeatDived = beat.Bpm / BeatDivisor;
            OsuHitObject previousHitobject = null;
            foreach (var currentHitobject in Beatmap.HitObjects)
            {
                if(currentHitobject.StartTime >= StartTime && currentHitobject.StartTime <= EndTime)
                {
                  if(previousHitobject == null)
                 {
                     var I = currentHitobject.StartTime;
                      if(Color)
                      {
                        Cursor.Color(I,currentHitobject.Color);
                      }
                     var beforeI = currentHitobject.StartTime;
                     Cursor.Move(OsbEasing.None,beforeI,I,currentHitobject.Position,currentHitobject.Position);
                    if(currentHitobject is OsuSlider)
                    {
                    var timestep = Beatmap.GetTimingPointAt((int)currentHitobject.StartTime).BeatDuration / BeatDivisor;
                    var startTime = currentHitobject.StartTime;
                    for(var i = currentHitobject.StartTime; i < currentHitobject.EndTime; i += timestep)
                    { 
                     var endTime = i + timestep;
                     var startPosition = Cursor.PositionAt(i);
                     Cursor.Move(i, endTime, startPosition, currentHitobject.PositionAtTime(endTime));
                    }
                 }
                 }
                 if (previousHitobject != null)
                {
                    var I = currentHitobject.StartTime;
                    
                    if(previousHitobject is OsuSlider){
                        
                    var beforeI = previousHitobject.EndTime;
                    if(Color)
                    {
                        Cursor.Color(OsbEasing.None,beforeI,I,previousHitobject.Color,currentHitobject.Color);
                    }
                    Cursor.Move(OsbEasing.None,beforeI,I,previousHitobject.EndPosition,currentHitobject.Position);
                    
                }else if(previousHitobject is OsuCircle){
                        var beforeI = previousHitobject.StartTime;
                    if(Color)
                    {
                        Cursor.Color(OsbEasing.None,beforeI,I,previousHitobject.Color,currentHitobject.Color);
                    }
                        Cursor.Move(OsbEasing.None,beforeI,I,previousHitobject.Position,currentHitobject.Position);
                    }
                    
                    if (currentHitobject is OsuSlider)
                    {
                    var timestep = Beatmap.GetTimingPointAt((int)currentHitobject.StartTime).BeatDuration / BeatDivisor;
                    var startTime = currentHitobject.StartTime;
                    for(var i = currentHitobject.StartTime; i < currentHitobject.EndTime; i += timestep)
                    { 
                     var endTime = i + timestep;
                     var startPosition = Cursor.PositionAt(i);
                     Cursor.Move(i, endTime, startPosition, currentHitobject.PositionAtTime(endTime));
                    }
                }
                
                 }
                 
                 previousHitobject = currentHitobject;
                }   
            } 
        }
    }
}
            
        
    

