using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuEntity;

namespace VideoMenuBLL
{
    public interface IGenreService
    {
        Genre Create(Genre gen);

        List<Genre> GetAll();
        Genre Update(Genre gen);

        
    }
}
