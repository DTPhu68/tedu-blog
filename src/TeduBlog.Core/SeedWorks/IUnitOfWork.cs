using System.Linq.Expressions;

namespace TeduBlog.Core.SeedWorks
{
  public interface IUnitOfWork
  {
    Task<int> CompleteAsync();
  }
}
