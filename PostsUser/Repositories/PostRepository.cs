using Microsoft.AspNetCore.Http.HttpResults;
using PostsUser.Context;
using PostsUser.Models;
using PostsUser.Repositories.Interfaces;

namespace PostsUser.Repositories
{
    public class PostRepository :Repository<PostModel>, IPostRepository
    {
        
        public PostRepository(AppDbContext context) : base(context) { }
        public async Task<IEnumerable<PostModel>> GetPostByLocation(string location)
        {
            throw new Exception("Not implented yet :(" );
        }
        
    }
}
