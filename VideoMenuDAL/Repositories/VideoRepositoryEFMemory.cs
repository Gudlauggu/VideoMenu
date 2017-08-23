﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoMenuDAL.Context;
using VideoMenuEntity;

namespace VideoMenuDAL.Repositories
{
    class VideoRepositoryEFMemory : IVideoRepository
    {
        InMemoryContext context;

        public VideoRepositoryEFMemory(InMemoryContext context)
        {
            this.context = context;
        }

        public Video Create(Video vid)
        {
            this.context.Videos.Add(vid);
            this.context.SaveChanges();
            return vid;

        }

        public Video Delete(int Id)
        {
            var vid = Get(Id);
            this.context.Videos.Remove(vid);
            this.context.SaveChanges();
            return vid;
        }

        public Video Get(int Id)
        {
            return this.context.Videos.FirstOrDefault(x => x.Id == Id);
        }

        public List<Video> GetAll()
        {
            return this.context.Videos.ToList();
        }
    }
}
