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
    public class Left : StoryboardObjectGenerator
    {
        public string stare = "sb/L/stare.png";
        public string main = "sb/L/main.png";
        public override void Generate()
        {
		    var bitmap = GetMapsetBitmap(stare);
            var s = GetLayer("").CreateSprite(stare, OsbOrigin.Centre);
            s.Scale(58405, 480.0f / bitmap.Height);
            s.Fade(58405 , 58405, 1,1);
            s.Fade(61469, 61469, 0, 0);
            //
            var bitmap2 = GetMapsetBitmap(main);
            var m = GetLayer("").CreateSprite(main, OsbOrigin.Centre);
            m.Scale(74171, 480.0f / bitmap2.Height);
            m.Move(74171,59.5,240);
            m.Fade(74171 , 74171, 1,1);
            m.Fade(75922, 75922, 0, 0);
            //
            m.Fade(81178 , 81178, 1,1);
            m.Fade(84681, 84681, 0, 0);
            //
            m.Move(84682,320,240);
            m.Fade(84682 , 84682, 1,1);
            m.Fade(85557, 85557, 0, 0);
            //
            m.Move(102419,59.5,240);
            m.Fade(102419 , 102419, 1,1);
            m.Fade(105703, 105703, 0, 0);
            //
            m.Scale(179281, (480.0f / bitmap.Height) * 1.2);
            m.Move(179281,320,320);
            m.Fade(182784 , 182784, 1,1);
            m.Fade(186287, 186287, 0, 0);
            
        }
    }
}
