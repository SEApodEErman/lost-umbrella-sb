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
    public class MiddleAnimation : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var bitmap = GetMapsetBitmap("sb/m/anim/1.png");
		    var middle = GetLayer("").CreateAnimation("sb/m/anim/.png", 10,55,OsbLoopType.LoopOnce,OsbOrigin.Centre);
            var first = GetLayer("").CreateSprite("sb/m/anim/0.png", OsbOrigin.Centre);
            first.Scale(19427,480.0f/bitmap.Height);
            first.Fade(19427,1);
            first.Fade(19974,0);

            middle.Scale(19974, 480.0f/bitmap.Height);
            middle.Fade(19974,33879,1,1);
            
        }
    }
}
