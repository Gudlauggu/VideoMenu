using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuEntity;

namespace VideoMenuDAL
{
    public interface IGenreRepository
    {
        Genre Create(Genre gen);

        List<Genre> GetAll();
        
    }
}
