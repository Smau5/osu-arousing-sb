﻿using StorybrewCommon.Scripting;
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

            bg.Fade(58555, 1);
            bg.Fade(71963, 0);

            var bg1 = GetLayer("bg1").CreateSprite("sb/1.jpg",OsbOrigin.Centre);
            bg1.Scale(37103,480.0f / bitmap.Height);
            bg1.Fade(37103,1);
            bg1.Fade(OsbEasing.InCubic,43471,43807,1,0);

            bg1.Fade(57214,57885,0,0.5);
            bg1.Fade(57885,58555,0.5,0);
            bg1.Scale(57214,57885,480.0f / bitmap.Height,480.0f / bitmap.Height * 1.05);

            var bg2 = GetLayer("bg2").CreateSprite("sb/2.jpg",OsbOrigin.Centre);
            bg2.Scale(14309,480.0f / bitmap.Height);
            bg2.Fade(14309,1);
            bg2.Fade(16991,0);
            bg2.Fade(19170,1);
            bg2.Fade(19505,0);

            bg2.Fade(50008,50510,0,0.5);
            bg2.Fade(50510,51851,0.5,0);
            bg2.Scale(50008,50510,480.0f / bitmap.Height,480.0f / bitmap.Height * 1.05);

            var bg3 = GetLayer("bg3").CreateSprite("sb/3.jpg",OsbOrigin.Centre);
            bg3.Scale(26376,480.0f / bitmap.Height);
            bg3.Fade(26376,1);
            bg3.Fade(OsbEasing.InCubic,32745,33080,1,0);

            bg3.Fade(55203,55874,0,0.5);
            bg3.Fade(55874,57214,0.5,0);
            bg3.Scale(55203,55874,480.0f / bitmap.Height,480.0f / bitmap.Height * 1.05);

            var bg4 = GetLayer("bg4").CreateSprite("sb/4.jpg",OsbOrigin.Centre);
            bg4.Scale(19505,480.0f / bitmap.Height);
            bg4.Fade(19505,1);
            bg4.Fade(22354,0);

            bg4.Fade(23695,24030,0,1);
            bg4.Fade(24365,0);

            bg4.Fade(52522,53192,0,0.5);
            bg4.Fade(53192,54533,0.5,0);
            bg4.Scale(52522,53192,480.0f / bitmap.Height,480.0f / bitmap.Height * 1.05);


            var blackAndWhite = GetLayer("BlackAndWhite").CreateSprite("sb/BlackAndWhite.jpg",OsbOrigin.Centre);
            blackAndWhite.Scale(16991,480.0f / bitmap.Height);
            blackAndWhite.Fade(16991,1);
            blackAndWhite.Fade(19170,0);

            blackAndWhite.Fade(22354,1);
            blackAndWhite.Fade(24030,0);

            blackAndWhite.Fade(24365,25036,1,0);

            blackAndWhite.Fade(32745,33080,0,1);
            blackAndWhite.Fade(37103,0);

            blackAndWhite.Fade(43471,43807,0,1);
            blackAndWhite.Fade(47829,0);

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

            bgWhite.Fade(22354,23695,0.4,0);

            bgWhite.Fade(47829,50510,0.7,0);


            var zoom2 = GetLayer("zoom2").CreateSprite("sb/2.jpg",OsbOrigin.Centre);
            var redScale = 480.0f / bitmap.Height;

            zoom2.Scale(16320,16991, redScale * 1.15, redScale );
            zoom2.Fade(16320,16991,0.7,0);
            zoom2.Fade(16991,0);



            var bgBlur = GetLayer("Blur").CreateSprite("sb/BGBlur.jpg", OsbOrigin.Centre);
            var bitmapBlur = GetMapsetBitmap("sb/BGBlur.jpg");
            bgBlur.Scale(1572, 480.0f / bitmapBlur.Height);
            bgBlur.Fade(1572,3582, 0,0.9);
            bgBlur.Fade(3583,0);

            var zoom = GetLayer("zoom").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            var scale = 480.0f / bitmap.Height;
            zoom.Scale(12969,13304, scale * 1.1, scale );
            zoom.Fade(12969,13304,1,0);

            zoom.Scale(14309,15650, scale , scale * 1.2);
            zoom.Fade(14309,15650,0.7,0);

            zoom.Scale(19672,21013, scale , scale * 1.2);
            zoom.Fade(19672,21013,0.7,0);

            zoom.Scale(26376,27717, scale , scale * 1.2);
            zoom.Fade(26376,27717,0.7,0);

            zoom.Scale(37103,38443, scale , scale * 1.2);
            zoom.Fade(37103,38443,0.7,0);

            zoom.Scale(58555,59896, scale , scale * 1.2);
            zoom.Fade(58555,59896,0.7,0);
            
            var noise1 = GetLayer("noise").CreateSprite("sb/Noise1.jpg", OsbOrigin.Centre);
            var bitmapNoise1 = GetMapsetBitmap("sb/Noise1.jpg");
            noise1.Scale(13304,480.0f / bitmapNoise1.Height);
            noise1.Fade(0,0);

            var noise2 = GetLayer("noise").CreateSprite("sb/Noise2.jpg", OsbOrigin.Centre);
            var bitmapNoise2 = GetMapsetBitmap("sb/Noise2.jpg");
            noise2.Scale(13304,480.0f / bitmapNoise2.Height);
            noise2.Fade(13304,scale);
            noise2.Fade(0,0);

            List<OsbSprite> bgNoise = new List<OsbSprite>();

            bgNoise.Add(noise1);
            bgNoise.Add(noise2);

            
            GenerateNoise(13304,13974,bgNoise);
            GenerateNoise(16320,16991,bgNoise);
            GenerateNoise(21851,22354,bgNoise);

            //black and white noise
            List<OsbSprite> bgNoiseBlackAndWhite = new List<OsbSprite>();

            var noiseBlackAndWhite1 = GetLayer("noise").CreateSprite("sb/blackAndWhiteNoise1.jpg", OsbOrigin.Centre);
            var bitmapNoiseBlackAndWhite = GetMapsetBitmap("sb/blackAndWhiteNoise1.jpg");
            noiseBlackAndWhite1.Scale(32745,480.0f / bitmapNoiseBlackAndWhite.Height);
            noiseBlackAndWhite1.Fade(0,0);

            var noiseBlackAndWhite2 = GetLayer("noise").CreateSprite("sb/blackAndWhiteNoise2.jpg", OsbOrigin.Centre);
            noiseBlackAndWhite2.Scale(32745,480.0f / bitmapNoiseBlackAndWhite.Height);
            noiseBlackAndWhite2.Fade(0,0);

            bgNoiseBlackAndWhite.Add(noiseBlackAndWhite1);
            bgNoiseBlackAndWhite.Add(noiseBlackAndWhite2);

            GenerateNoiseIncrease (32745,37103,bgNoiseBlackAndWhite);
            GenerateNoiseIncrease (43471,47829,bgNoiseBlackAndWhite);

            var highlight = GetLayer("highlight").CreateSprite("sb/highlight.png",OsbOrigin.Centre);
            highlight.Fade(OsbEasing.InCubic,11293,12969,0,1);
            highlight.Scale(OsbEasing.InCubic,11293,12969,0.1,7);
            highlight.Move(11293,317,421);

            highlight.Fade(12969,0);

            var mask = GetLayer("mask").CreateSprite("sb/Border Mask.png",OsbOrigin.Centre);
            var maskBitmap = GetMapsetBitmap("sb/Border Mask.png");
            mask.Scale(14309,480.0f / maskBitmap.Height);
            mask.Fade(14309,0.4);
            mask.Fade(26376,0);

            var spotlight = GetLayer("spotlight").CreateSprite("sb/spotlight.png",OsbOrigin.Centre,new Vector2(320,-50));
            spotlight.Fade(23695,24030,0,1);
            spotlight.MoveY(23695,24030,-50,240);
            spotlight.ScaleVec(23695,24030,0.1,0.1,0.3,1);
            spotlight.ScaleVec(24030,24357,0.3,1,10,1);

            spotlight.Fade(24365,25036,1,0);

            var oldStyle = GetLayer("old").CreateSprite("sb/OldStyle.jpg",OsbOrigin.Centre);
            var bitmapOld = GetMapsetBitmap("sb/OldStyle.jpg");
            oldStyle.Scale(47829,480.0f / bitmapOld.Height);
            oldStyle.Fade(47829,1);
            oldStyle.Fade(58555,0);


            //0pieces
            //initialization
            List<OsbSprite> pieces0 = new List<OsbSprite>();

            var bitmapPiece = GetMapsetBitmap("sb/0pieces/0.jpg");

            pieces0.Add(GetLayer("pieces").CreateSprite("sb/0pieces/0.jpg",OsbOrigin.CentreLeft,new Vector2(-107,240)));
            pieces0.Add(GetLayer("pieces").CreateSprite("sb/1pieces/0.jpg",OsbOrigin.CentreLeft,new Vector2(-107,240)));
            pieces0.Add(GetLayer("pieces").CreateSprite("sb/2pieces/0.jpg",OsbOrigin.CentreLeft,new Vector2(-107,240)));
            pieces0.Add(GetLayer("pieces").CreateSprite("sb/3pieces/0.jpg",OsbOrigin.CentreLeft,new Vector2(-107,240)));
            pieces0.Add(GetLayer("pieces").CreateSprite("sb/4pieces/0.jpg",OsbOrigin.CentreLeft,new Vector2(-107,240)));

            List<OsbSprite> pieces1 = new List<OsbSprite>();

            pieces1.Add(GetLayer("pieces").CreateSprite("sb/0pieces/1.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height,240)));
            pieces1.Add(GetLayer("pieces").CreateSprite("sb/1pieces/1.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height,240)));
            pieces1.Add(GetLayer("pieces").CreateSprite("sb/2pieces/1.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height,240)));
            pieces1.Add(GetLayer("pieces").CreateSprite("sb/3pieces/1.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height,240)));
            pieces1.Add(GetLayer("pieces").CreateSprite("sb/4pieces/1.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height,240)));

            List<OsbSprite> pieces2 = new List<OsbSprite>();

            pieces2.Add(GetLayer("pieces").CreateSprite("sb/0pieces/2.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 2,240)));
            pieces2.Add(GetLayer("pieces").CreateSprite("sb/1pieces/2.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 2,240)));
            pieces2.Add(GetLayer("pieces").CreateSprite("sb/2pieces/2.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 2,240)));
            pieces2.Add(GetLayer("pieces").CreateSprite("sb/3pieces/2.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 2,240)));
            pieces2.Add(GetLayer("pieces").CreateSprite("sb/4pieces/2.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 2,240)));

            List<OsbSprite> pieces3 = new List<OsbSprite>();

            pieces3.Add(GetLayer("pieces").CreateSprite("sb/0pieces/3.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 3,240)));
            pieces3.Add(GetLayer("pieces").CreateSprite("sb/1pieces/3.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 3,240)));
            pieces3.Add(GetLayer("pieces").CreateSprite("sb/2pieces/3.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 3,240)));
            pieces3.Add(GetLayer("pieces").CreateSprite("sb/3pieces/3.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 3,240)));
            pieces3.Add(GetLayer("pieces").CreateSprite("sb/4pieces/3.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 3,240)));

            List<OsbSprite> pieces4 = new List<OsbSprite>();

            pieces4.Add(GetLayer("pieces").CreateSprite("sb/0pieces/4.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 4,240)));
            pieces4.Add(GetLayer("pieces").CreateSprite("sb/1pieces/4.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 4,240)));
            pieces4.Add(GetLayer("pieces").CreateSprite("sb/2pieces/4.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 4,240)));
            pieces4.Add(GetLayer("pieces").CreateSprite("sb/3pieces/4.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 4,240)));
            pieces4.Add(GetLayer("pieces").CreateSprite("sb/4pieces/4.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 4,240)));

            List<OsbSprite> pieces5 = new List<OsbSprite>();

            pieces5.Add(GetLayer("pieces").CreateSprite("sb/0pieces/5.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 5,240)));
            pieces5.Add(GetLayer("pieces").CreateSprite("sb/1pieces/5.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 5,240)));
            pieces5.Add(GetLayer("pieces").CreateSprite("sb/2pieces/5.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 5,240)));
            pieces5.Add(GetLayer("pieces").CreateSprite("sb/3pieces/5.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 5,240)));
            pieces5.Add(GetLayer("pieces").CreateSprite("sb/4pieces/5.jpg",OsbOrigin.CentreLeft,new Vector2(-107 + 320 * 480.0f / bitmap.Height * 5,240)));
  

            for(int i = 0 ; i > pieces0.Count; i++){
                pieces0[i].Scale(0,480.0f / bitmap.Height);
                pieces0[i].Fade(0,0);

                pieces1[i].Scale(0,480.0f / bitmap.Height);
                pieces1[i].Fade(0,0);

                pieces2[i].Scale(0,480.0f / bitmap.Height);
                pieces2[i].Fade(0,0);
                
                pieces3[i].Scale(0,480.0f / bitmap.Height);
                pieces3[i].Fade(0,0);

                pieces4[i].Scale(0,480.0f / bitmap.Height);
                pieces4[i].Fade(0,0);

                pieces5[i].Scale(0,480.0f / bitmap.Height);
                pieces5[i].Fade(0,0);
            }

            List<List<OsbSprite>> piecesList = new List<List<OsbSprite>>();

            piecesList.Add(pieces0);
            piecesList.Add(pieces1);
            piecesList.Add(pieces2);
            piecesList.Add(pieces3);
            piecesList.Add(pieces4);
            piecesList.Add(pieces5);

            for(int i = 0 ; i < piecesList.Count; i++){
                for(int j = 0 ; j < piecesList[0].Count; j++){
                    piecesList[i][j].Scale(0,480.0f / bitmap.Height);
                    piecesList[i][j].Fade(0,0);
                }
            }

            GeneratePewPew(16991,18918,piecesList);
            GeneratePewPew(22354,23862,piecesList);

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

        public void GenerateNoiseIncrease(double startTime, double endTime, List<OsbSprite> bgNoise){
            int turn = 0;
            double f = 0.3;
            var count = (endTime - startTime) / 30;

            for(double time = startTime; time < endTime; time = time + 30){
                bgNoise[turn].Fade(time,f);
                bgNoise[turn].Fade(time+30,0);
                turn++;
                f = f + 0.7 / count;
                if(turn>1){
                    turn = 0;
                    
                }
            }
        }

        public void GeneratePewPew(Double startTime,Double endtime,List<List<OsbSprite>> piecesList){
            var offset = (17326 - 16991) / 6;
            int i = 0;
            int color = Random(0,5);
            int count = 0;
            int s = 0;
            for(double time = startTime; time < endtime ; time = time + offset){
                piecesList[i][color].Fade(time,time + (17326 - 16991),1 - 0.1 * count,0);
                i++;
                color++;
                s++;
                if(i >= piecesList.Count){
                    i = 0;
                }
                if(color >= piecesList[0].Count){
                    color = 0;
                }
                if(s >= 6){
                    count++;
                    s = 0;
                }
            }


        }
    }
}
