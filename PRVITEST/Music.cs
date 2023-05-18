using System;
using System.Collections.Generic;
using System.Text;

namespace PRVITEST
{
    class Music : IPlayable
    {
        string musicGenre;
        string title;
        int length;

        public Music(string musicGenre, string title, int length)
        {
            this.musicGenre = musicGenre;
            this.title = title;
            if (length < 0) throw new LengthException(length, $"Length cannot be negative:{length}");
            this.length = length;
        }

        public string MusicGenre { get => musicGenre; }
        public string Title { get => title; }
        public int Length { get => length; }

        public string Play()
        {
            return $"{Title}{Length}{MusicGenre}";
        }
    }
}
