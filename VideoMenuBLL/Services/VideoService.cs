using System;
using System.Collections.Generic;
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

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Video Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Video> GetAll()
        {
            throw new NotImplementedException();
        }

        public Video Update(Video vid)
        {
            throw new NotImplementedException();
        }
    }
}
