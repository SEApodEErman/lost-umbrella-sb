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
    public class Middle : StoryboardObjectGenerator
    {
        public string main = "sb/m/main.png";
        public string dark = "sb/m/dark.png";
        public override void Generate()
        {
		    var bitmap = GetMapsetBitmap(main);
            var m = GetLayer("").CreateSprite(main, OsbOrigin.Centre);
            var bitmap2 = GetMapsetBitmap(dark);
            var d = GetLayer("").CreateSprite(dark, OsbOrigin.Centre);
            m.Scale(7164, 480.0f / bitmap.Height);
            //
            m.Move(7164,320,240);
            m.Fade(7164,7164,1,1);
            m.Fade(12857,49207,0, 0);
            //
            m.Fade(49208 ,1);
            m.Fade(58404,75922,0, 0);
            //
            m.Fade(75923 ,1);
            m.Fade(77675, 80739, 0, 0);
            //
            m.Fade(80740 ,1);
            m.Fade(84681, 85557, 0, 0);
            //
            m.Fade(85558 ,1);
            m.Fade(86433, 109427, 0, 0);
            //
            m.Fade(109427 ,1);
            m.Fade(116215, 186288, 0, 0);
            //
            d.Scale(133733, 480.0f / bitmap.Height);
            d.Fade(133733 , 133733, 1,1);
            d.Fade(144462, 144462, 1, 0);
            //
            m.Scale(186288, (480.0f / bitmap.Height) * 1.2);
            m.Move(186288,320,320);
            m.Fade(186288 , 0, 1,1);
            m.Fade(189792, 189792, 1, 0);
            //
            m.Scale(193295, (480.0f / bitmap.Height) * 0.5);
            m.Move(193295,320,240);
            m.Fade(193295 , 193295 ,1,1);
            m.Fade(195704, 195703, 1, 0);
        }
    }
}
