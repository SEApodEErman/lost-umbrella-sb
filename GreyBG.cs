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
    public class GreyBG : StoryboardObjectGenerator
    {
        public string BGPath = "sb/gray.png ";
        public override void Generate()
        {
		    var bitmap = GetMapsetBitmap(BGPath);
            var bg = GetLayer("").CreateSprite(BGPath, OsbOrigin.Centre);
            bg.Scale(0, 480.0f / bitmap.Height);
            bg.Fade(0 , 0, 1,1);
            bg.Fade(201178, 201178, 0, 0);

        }
    }
}
