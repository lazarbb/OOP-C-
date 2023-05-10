using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class ColectionChecker
    {
        public static bool HasDuplicate(YouTubeVideo[] videos)
        {
            int i, j, br=0;

            for (i = 0; i < videos.Length; i++)
            {
                for (j = i + 1; j < videos.Length; j++)
                {
                    if (videos[i] == videos[j]) { br++; }

                }
            }

            if (br > 0) return true;
            return false;
        }
    }
}
