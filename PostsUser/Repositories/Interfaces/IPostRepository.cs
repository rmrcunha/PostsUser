using PostsUser.Models;

namespace PostsUser.Repositories.Interfaces
{
    public interface IPostRepository : IRepository<PostModel>
    {
        Task<IEnumerable<PostModel>>
            GetPostByLocation(string location);

    }
}
