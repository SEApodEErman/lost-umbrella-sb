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
    public class Right : StoryboardObjectGenerator
    {
         public string main = "sb/r/main.png";
         public string stare = "sb/r/stare.png";
        public override void Generate()
        {
		    var bitmap = GetMapsetBitmap(main);
            var m = GetLayer("").CreateSprite(main, OsbOrigin.Centre);
            var bitmap2 = GetMapsetBitmap(stare);
            var s = GetLayer("").CreateSprite(stare, OsbOrigin.Centre);
            //
            m.Scale(595, 480.0f / bitmap.Height);
            //
            m.Move(595,320,240);
            m.Fade(595 , 595, 1,1);
            m.Fade(7163, 7163, 0, 0);
            //
            m.Move(77675,575,240);
            m.Fade(77675 , 77675, 1,1);
            m.Fade(79426, 79426, 0, 0);
            //
            m.Fade(81178 , 81178, 1,1);
            m.Fade(84681, 84681, 0, 0);
            //
            m.Move(86434,320,240);
            m.Fade(86434 , 86434, 1,1);
            m.Fade(87310, 87310, 0, 0);
            //
            m.Move(105704,575,240);
            m.Fade(105704 , 105704, 1,1);
            m.Fade(109426, 109426, 0, 0);
            //
            s.Scale(126945, 480.0f / bitmap.Height);
            s.Move(126945,320,240);
            s.Fade(126945 , 126945, 1,1);
            s.Fade(132857, 132857, 0, 0);
            //
            s.Scale(179281, (480.0f / bitmap.Height) * 1.1);
            s.Move(179281,320,300);
            s.Fade(179281 , 179281, 1,1);
            s.Fade(182783, 182783, 0, 0);

        }
    }
}
