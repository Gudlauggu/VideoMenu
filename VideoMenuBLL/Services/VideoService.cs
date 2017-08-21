using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoMenuDAL;
using VideoMenuEntity;

namespace VideoMenuBLL.Services
{
    class VideoService : IVideoService
    {
        public Video Create(Video vid)
        {
            Video newVideo;
            FakeDB.Videos.Add(newVideo = new Video()
            {
                Id = FakeDB.Id++,
                Name = vid.Name,
                Genre = vid.Genre
            });
            return newVideo;
        }

        public Video Delete(int Id)
        {
            var vid = Get(Id);
            FakeDB.Videos.Remove(vid);
            return vid;
        }

        public Video Get(int Id)
        {
            return FakeDB.Videos.FirstOrDefault(x => x.Id == Id);
        }

        public List<Video> GetAll()
        {
            return new List<Video>(FakeDB.Videos);
        }

        public Video Update(Video vid)
        {
            var videoFromDb = Get(vid.Id);
            if (videoFromDb == null)
            {
                throw new InvalidOperationException("Customer not found");
            }
            videoFromDb.Name = vid.Name;
            videoFromDb.Genre = vid.Genre;
            return videoFromDb;
        }
    }
}
