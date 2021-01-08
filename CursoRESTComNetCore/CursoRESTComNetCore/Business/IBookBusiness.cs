using CursoRESTComNetCore.Data.VO;
using CursoRESTComNetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoRESTComNetCore.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
