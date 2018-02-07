using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System;
using System.Drawing;
using System.IO;
namespace StorybrewScripts
{
    public class Lyrics : StoryboardObjectGenerator
    {
        [Configurable]
        public string FontName = "Verdana";

        [Configurable]
        public string SpritesPath = "sb/L";

        [Configurable]
        public int FontSize = 60;

        [Configurable]
        public float FontScale = 0.5f;
        [Configurable]
        public Color4 FontColor = Color4.White;

        [Configurable]
        public FontStyle FontStyle = FontStyle.Regular;
        [Configurable]
        public int GlowRadius = 3;
        [Configurable]
        public Color4 GlowColor = new Color4(255, 255, 255, 100);
        [Configurable]
        public int OutlineThickness = 2;

        [Configurable]
        public Color4 OutlineColor = new Color4(24, 19, 19, 100);

        [Configurable]
        public int ShadowThickness = 0;

        [Configurable]
        public Color4 ShadowColor = new Color4(0, 0, 0, 100);

        [Configurable]
        public float PaddingX = 0;

        [Configurable]
        public float PaddingY = 0;
        [Configurable]
        public float spacing = 0;

        [Configurable]
        public bool Debug = false;


        [Configurable]
        public bool aaa = false;
        public override void Generate()
        {
            var font = LoadFont(SpritesPath, new FontDescription()
            {
                FontPath = FontName,
                FontSize = FontSize,
                Color = FontColor,
                Padding = new Vector2(PaddingX, PaddingY),
                FontStyle = FontStyle,
                EffectsOnly = false,
                Debug = Debug,
            },
            new FontGlow()
            {
                Radius = GlowRadius,
                Color = GlowColor,
            },
            new FontOutline()
            {
                Thickness = OutlineThickness,
                Color = OutlineColor,
            },
            new FontShadow()
            {
                Thickness = ShadowThickness,
                Color = ShadowColor,
            });
            generatePerCharacter(font, "遙か",1907 ,3248, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "永久に響け　arousing my soul",3751 ,5594, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "鮮やかに舞う不死鳥達の旋律",6097 ,9114, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "最果てへ",9617 ,12633, 320, 440, 3751 - 3583);

            generatePerCharacter(font, "踏み荒らされた大地",26544 ,28555, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "斬り拓け　先鋒のsoldier",28890 ,32075, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "【神話に印された 道標を携えて】",32577 ,36767, 320, 440, 3751 - 3583);

            generatePerCharacter(font, "混沌に抗い",37270 ,39281, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "希望（光）を見失わずに",39784 ,42801, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "【その鼓動に秘めた 証と、意味を、見せて】",43471 ,47494, 320, 440, 3751 - 3583);          

            generatePerCharacter(font, "迫る影の向こう",47996 ,49840, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "蜃気楼が揺らめく",50343 ,52522, 320, 440, 3751 - 3583);
            generatePerCharacter(font, "狂おしく甘やか",53192 ,55203, 320, 440, 3751 - 3583);     
            generatePerCharacter(font, "花蜜の香りの罠",55706 ,57885, 320, 440, 3751 - 3583);     
            generatePerCharacter(font, "囚われて呑まれた",58723 ,60566, 320, 440, 3751 - 3583);     
            generatePerCharacter(font, "幾多の魂たちよ",61069 ,64421, 320, 440, 3751 - 3583);     
            generatePerCharacter(font, "もう戻れない",64924 ,66265, 320, 440, 3751 - 3583);     

            generatePerCharacter(font, "絶望 薙ぎ払って",66767 ,68779, 320, 440, 3751 - 3583);     
            generatePerCharacter(font, "使命に今 向かおう",69281 ,71628, 320, 440, 3751 - 3583);     

            generatePerCharacter(font, "いつか誰もが辿り着ける",72801 ,75315, 320, 440, 3751 - 3583);     
            generatePerCharacter(font, "闇の果て　戦いの終焉",75818 ,78499, 320, 440, 3751 - 3583);    
            generatePerCharacter(font, "新しい時代が始まる",79170 ,83024, 320, 440, 3751 - 3583);   

            generatePerCharacter(font, "天空を貫き　紅く染める",83527 ,86041, 320, 440, 3751 - 3583);    
            generatePerCharacter(font, "勝利が翻す炎",86544 ,89226, 320, 440, 3751 - 3583);    
            generatePerCharacter(font, "護るべき未来（明日）を　革命を",89896 ,93415, 320, 440, 3751 - 3583);    

            generatePerCharacter(font, "この手に",94086 ,94756, 320, 440, 3751 - 3583);    
            generatePerCharacter(font, "抱き　その先へ",95091 ,98779, 320, 440, 3751 - 3583); 
            generatePerCharacter(font, "my soul",99449 ,102131, 320, 440, 3751 - 3583);   
        }
        public void generatePerCharacter(FontGenerator font, string lyric, double start, double end, double xPosition , double yPosition ,double delay)
        {  
            var layer = GetLayer("");
            var letterY = yPosition;
            float totalX = 0;
            for(int i = 0 ; i < lyric.Length ; i++){
                var texture = font.GetTexture(lyric[i].ToString()); 
                totalX += texture.BaseWidth * FontScale * 0.5f + spacing;
            }
            for(int i = 0 ; i < lyric.Length ; i++)
            {
                var texture = font.GetTexture(lyric[i].ToString());
                if (!texture.IsEmpty)
                {
                    double x = xPosition + texture.BaseWidth * FontScale * 0.5f + spacing - totalX;
                    double y = yPosition + Math.Sin(MathHelper.DegreesToRadians(30) *i) *5 + Random(-3,3);
                    var sprite = layer.CreateSprite(texture.Path, OsbOrigin.Centre,new Vector2((float)x ,(float)y));
                    
                    sprite.Scale(start - delay,FontScale);
                    sprite.Fade(start - delay,start ,0, 1);
                    sprite.Fade(end  ,end + delay,1,0);
                    var ran = Random(-4,4);
                    var rand = Random(-2,2);
                    sprite.Move(start  ,end + delay ,sprite.PositionAt(start),new Vector2(sprite.PositionAt(start).X + rand,sprite.PositionAt(start).Y + rand));
                    
                }
                xPosition += texture.BaseWidth * FontScale;
            }
        }
    }
}
