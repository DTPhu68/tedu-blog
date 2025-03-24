using Microsoft.EntityFrameworkCore;
using TeduBlog.Core.Domain.Content;
using TeduBlog.Core.Repositories;
using TeduBlog.Data.SeedWorks;

namespace TeduBlog.Data.Repositories
{
  public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
  {    
    public PostRepository(TeduBlogContext context) : base(context)
    {
    }

    public Task<List<Post>> GetPopularPostsAsync(int count)
    {
      return _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
    }
  }
}
