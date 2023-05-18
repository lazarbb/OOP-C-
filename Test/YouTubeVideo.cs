using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class YouTubeVideo
    {
        string id;
        string title;

        public YouTubeVideo(string id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public static bool operator ==(YouTubeVideo video1, YouTubeVideo video2)
        {
            if (video1.title == video2.title && video1.id == video2.id)
                return true;
            return false;
        }

        public static bool operator !=(YouTubeVideo video1, YouTubeVideo video2)
        {
            if (video1.title != video2.title && video1.id != video2.id)
                return true;
            return false;
        }
    }
}
