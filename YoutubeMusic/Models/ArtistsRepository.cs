namespace YoutubeMusic.Models
{
    public class ArtistsRepository
    {
        private static List<Artist> _artists = new List<Artist>()
        {
            new Artist {ArtistId = 1, Name = "Châu Thâm", Avatar = "https://y.qq.com/music/photo_new/T001R500x500M000003fA5G40k6hKc.jpg?max_age=2592000" },
            new Artist {ArtistId = 2, Name = "Hoàng Thi Phù", Avatar = "https://y.qq.com/music/photo_new/T001R300x300M0000000Z1MN2gkvI6_8.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "Trương Kiệt", Avatar = "https://y.qq.com/music/photo_new/T001R500x500M000002azErJ0UcDN6.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "Lý Dung Hạo", Avatar = "https://y.qq.com/music/photo_new/T001R500x500M000000aHmbL2aPXWH.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "G.E.M. Đặng Tử Kỳ", Avatar = "https://y.qq.com/music/photo_new/T001R500x500M000001fNHEf1SFEFN.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "Viên Á Duy", Avatar = "https://y.qq.com/music/photo_new/T001R300x300M00000472DR10Ytv83_5.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "Từ Giai Oánh", Avatar = "https://y.qq.com/music/photo_new/T001R300x300M000002LZVMH0zc8F4_4.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "Tống Á Hiên", Avatar = "https://y.qq.com/music/photo_new/T001R300x300M000003yal7K3fzAGl_4.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "Diệp Huyền Thanh", Avatar = "https://y.qq.com/music/photo_new/T001R300x300M000000mjQA01OD3Mp_4.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "Hồ Ngạn Bân", Avatar = "https://y.qq.com/music/photo_new/T001R300x300M0000022VU5J1D8BRP_3.jpg?max_age=2592000" },
            new Artist {ArtistId = 3, Name = "Ngải Thần", Avatar = "https://y.qq.com/music/photo_new/T001R300x300M000000985uR2CKS2P_6.jpg?max_age=2592000" },

        };
        public static void AddArtist(Artist artist)
        {
            var maxId = _artists.Max(x => x.ArtistId);
            artist.ArtistId = maxId + 1;
            _artists.Add(artist);
        }

        public static List<Artist> GetArtist() => _artists;

        public static Artist? GetArtistById(int artistId)
        {
            var artist = _artists.FirstOrDefault(x => x.ArtistId == artistId);
            if(artist != null)
            {
                return artist;
            }
            return null;
        }

        public static void UpdateArtist(int artistId,  Artist artist)
        {
            if (artistId != artist.ArtistId) return;
            var artistToUpdate = GetArtistById(artistId);
            if (artistToUpdate != null)
            {
                artistToUpdate.Name = artist.Name;
                artistToUpdate.Avatar = artist.Avatar;
            }
        }

        public static void DeleteArtist(int artistId)
        {
            var artistToDelete = _artists.FirstOrDefault(x => x.ArtistId == artistId);
            if( artistToDelete != null )
            {
                _artists.Remove(artistToDelete);
            }
        }

    }
}
