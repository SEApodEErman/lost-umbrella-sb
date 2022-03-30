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
    public class Loops : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var bitmap = GetMapsetBitmap("sb/loop/0.png");
		    var loop = GetLayer("").CreateAnimation("sb/loop/.png", 28,55,OsbLoopType.LoopForever,OsbOrigin.Centre);
            var end = GetLayer("").CreateSprite("sb/loop/0.png", OsbOrigin.Centre);

            loop.Scale(19427, 480.0f/bitmap.Height);
            loop.Fade(19427,33878,1,1);
            loop.Fade(33878,0);
            end.Scale(61908, 480.0f/bitmap.Height);
            end.Fade(61908,1);
            end.Fade(62018,0);

            loop.Fade(62018,72310,1,1);
            loop.Fade(72310,0);
            end.Fade(72310,1);
            end.Fade(74171,0);


            loop.Fade(145996,156507,1,1);
            loop.Fade(156507,0);
            end.Fade(156507,1);
            end.Fade(165225,0);
        
        }
    }
}
