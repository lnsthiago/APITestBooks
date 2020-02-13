using Books.Domain.Interfaces.Repositories;
using Books.Domain.Models;
using Books.Infra.Data;

namespace Books.Infra.Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(Context dataContext) : base(dataContext)
        {
        }
    }
}
