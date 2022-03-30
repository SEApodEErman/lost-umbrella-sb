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
    public class LeftAnimation : StoryboardObjectGenerator
    {

        public override void Generate()
        {
            var bitmap = GetMapsetBitmap("sb/L/anim/left1.png");
		    var left = GetLayer("").CreateAnimation("sb/L/anim/left.png", 9,55,OsbLoopType.LoopForever,OsbOrigin.Centre);
            var first = GetLayer("").CreateSprite("sb/l/anim/left0.png", OsbOrigin.Centre);

            left.Scale(19427, 480.0f/bitmap.Height);
            left.Move(19427,65,240);
            left.Fade(19427,19919,1,1);
            left.Fade(19919,21288,0,0);
            //
            first.Scale(19919, 480.0f/bitmap.Height);
            first.Move(19919,65,240);
            first.Fade(19919,1);
            first.Fade(21288,1);
            //
            left.Fade(21288,23970,1,1);
            left.Fade(23970,24518,0,0);

            
        }
    }
}
