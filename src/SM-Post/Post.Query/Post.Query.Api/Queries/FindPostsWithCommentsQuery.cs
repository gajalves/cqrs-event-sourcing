using CQRS.Core.Queries;

namespace Post.Query.Api.Queries
{
    public class FindPostsWithCommentsQuery : BaseQuery
    {
        public Guid Id { get; set; }
    }
}
