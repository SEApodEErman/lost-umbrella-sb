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
    public class Icons : StoryboardObjectGenerator
    {
        public string clouds = "sb/assets/clouds.png";
        public string droplets = "sb/assets/droplets.png";
        public string rain = "sb/assets/rain.png";
        public string sun = "sb/assets/sun.png";
        public string window = "sb/assets/window.png";
        public string umbrella = "sb/assets/umbrella.png";
        public string tears = "sb/assets/tears.png";
        public string ripple = "sb/assets/ripple.png";
        public override void Generate()
        {
		    var r = GetLayer("").CreateSprite(rain, OsbOrigin.Centre);
            r.Scale(33879,0.4);
            r.Fade(33879,33879,1,1);
            r.Fade(37382,37382,0,0);

            var c = GetLayer("").CreateSprite(clouds, OsbOrigin.Centre);
            c.Scale(37383,0.4);
            c.Fade(37383,37383,1,1);
            c.Fade(40885,40885,0,0);

            var s = GetLayer("").CreateSprite(sun, OsbOrigin.Centre);
            s.Scale(40886,0.4);
            s.Fade(40886,40886,1,1);
            s.Fade(44827,44827,0,0);

            var d = GetLayer("").CreateSprite(droplets, OsbOrigin.Centre);
            d.Scale(44828,0.4);
            d.Fade(44828,44828,1,1);
            d.Fade(48770,48770,0,0);

            var w = GetLayer("").CreateSprite(window, OsbOrigin.Centre);
            w.Scale(88186,0.4);
            w.Fade(88186,88186,1,1);
            w.Fade(102418,102418,0,0);

            var t = GetLayer("").CreateSprite(tears, OsbOrigin.Centre);
            t.Scale(123441,0.4);
            t.Fade(123441,123441,1,1);
            t.Fade(126944,126944,0,0);

            var rip = GetLayer("").CreateSprite(ripple, OsbOrigin.Centre);
            rip.Scale(144463,0.4);
            rip.Fade(144463,144463,1,1);
            rip.Fade(145995,145995,0,0);

            var u = GetLayer("").CreateSprite(umbrella, OsbOrigin.Centre);
            u.Scale(195704,0.4);
            u.Move(195704,400,350);
            u.Fade(195704,195704,1,1);
            u.Fade(201178,201178,0,0);
            
        }
    }
}
