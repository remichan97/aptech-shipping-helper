using ShippingHelper.Core.Data;

namespace ShippingHelper.Core.Infrastructure;

public interface IUnitOfWork : IDisposable
{
	//public ICategoriesRepository CategoriesRepository { get; }
	//public IPostsRepository PostsRepository { get; }
	//public IPostTagRepository PostTagRepository { get; }
	//public ICommentsRepository CommentsRepository { get; }
	//public ITagsRepository TagsRepository { get; }
	public AppDbContext AppDbContext { get; }

	Task<int> SaveChanges();
}