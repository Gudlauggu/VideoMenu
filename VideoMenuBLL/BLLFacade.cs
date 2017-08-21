using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuBLL.Services;

namespace VideoMenuBLL
{
    public class BLLFacade
    {
        public IVideoService GetVideoService()
        {
            return new VideoService();
        }

        public IVideoService VideoService
        {
            get { return new VideoService();}
        }
    }
}
