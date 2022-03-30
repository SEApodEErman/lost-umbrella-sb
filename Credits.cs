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
    public class Credits : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var title = GetLayer("").CreateSprite("sb/assets/title.png", OsbOrigin.Centre);
            var music = GetLayer("").CreateSprite("sb/assets/music.png", OsbOrigin.Centre);
            var credits = GetLayer("").CreateSprite("sb/assets/credits.png", OsbOrigin.Centre);
            var vocal = GetLayer("").CreateSprite("sb/assets/vocal.png", OsbOrigin.Centre);

            title.Scale(19427,0.25);
            title.Fade(19427,1);
            title.Fade(26872,0);

            music.Scale(26872,0.25);
            music.Fade(26872,1);
            music.Fade(33879,0);

            credits.Scale(168770,0.25);
            credits.Fade(170522,1);
            credits.Fade(172273,0);

            vocal.Scale(172273,0.25);
            vocal.Fade(172273,1);
            vocal.Fade(177529,0);
            
        }
    }
}
