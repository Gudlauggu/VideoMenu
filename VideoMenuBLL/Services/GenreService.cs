using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuDAL;
using VideoMenuEntity;

namespace VideoMenuBLL.Services
{
    class GenreService : IGenreService
    {
        DALFacade facade;
        public GenreService(DALFacade facade)
        {
            this.facade = facade;
        }

        public Genre Create(Genre gen)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newGen = uow.GenreRepository.Create(gen);
                uow.Complete();
                return newGen;
            }
        }

        public List<Genre> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.GenreRepository.GetAll();
            }
        }

        public Genre Update(Genre gen)
        {
            throw new NotImplementedException();
        }
    }
}
