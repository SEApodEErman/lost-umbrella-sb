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
    public class RightAnimation : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var bitmap = GetMapsetBitmap("sb/r/anim/1.png");
		    var right = GetLayer("").CreateAnimation("sb/r/anim/.png", 10,55,OsbLoopType.LoopOnce,OsbOrigin.Centre);
            var first = GetLayer("").CreateSprite("sb/r/anim/1.png", OsbOrigin.Centre);
            first.Scale(19427,480.0f/bitmap.Height);
            first.Move(20631,575,240);
            first.Fade(19427,1);
            first.Fade(20631,0);

            right.Scale(20631, 480.0f/bitmap.Height);
            right.Move(20631,575,240);
            right.Fade(20631,33879,1,1);
            
        }
    }
}
