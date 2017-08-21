using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuEntity;

namespace VideoMenuBLL
{
    public interface IVideoService
    {
        Video Create(Video vid);

        List<Video> GetAll();
        Video Get(int Id);

        Video Update(Video vid);

        bool Delete(int Id);

    }
}
