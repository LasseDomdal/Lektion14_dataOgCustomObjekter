using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicCd : Product
    {
        public string Artist { get; set; }

        public string Label { get; set; }

        public short Released { get; set; }

        private List<string> tracks = new List<string>();
        public List<string> Tracks
        {
            get { return tracks; }
            set { tracks = value; }
        }
        
        private List<Track> trackList = new List<Track>();
        
        public List<Track> TrackList
        {
            get { return trackList; }
            set { trackList = value; }
        }

        public MusicCd(string title, decimal price, string imageUrl, string artist, string label, short released) : base(title, price, imageUrl)
        {
            Artist = artist;
            Label = label;
            Released = released;
        }

        public MusicCd(string title, decimal price, string artist, short released) : base(title, price)
        {
            Artist = artist;
            Released = released;
        }

        public void AddTrack(string track)
        {
            Tracks.Add(track);
        }
        
        public void AddTrack(Track track)
        {
            TrackList.Add(track);
        }

        public TimeSpan GetPlayingTIme()
        {
            TimeSpan tracksLenght = default;
            foreach (var track in TrackList)
            {
               tracksLenght += TimeSpan.Parse("00:0" + track.Lenght);
            }

            return tracksLenght;
        }
    }
}