using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlaylist
{
        public class Song
        {
            private string _album;
            public string Album // Pascal Case;
            {
                get { return _album; }
                set { _album = value; }
            }

            private string _title;      // the name field
            public string Title         // the Name property
            {
                get => _title;
                set => _title = value;
            }

            private string _description;

            public string Description
        {
            get => _description;
            set => _description = value;
        }
            private string _genre;
        public string Genre
        {
            get => _genre;
            set => _genre = value;
        }

            public Song(string album, string title, string description, string genre)
            {
                _album = album;
                _title = title;
                _description = description;
                _genre = genre;
            }
    }
}
