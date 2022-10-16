using ShippingHelper.Core.Data;
using ShippingHelper.Core.IRepository;
using ShippingHelper.Core.Repository;

namespace ShippingHelper.Core.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContext _context;
		private IAcceptOffersRepository _acceptOffersRepository;
		private IContactsRepository _contactsRepository;
		private IOffersRepository _offersRepository;
		private IProductOffersRepository _productOffersRepository;
		private IUsersRepository _usersRepository;

		public UnitOfWork(AppDbContext context)
		{
			_context = context;
		}

		public AppDbContext AppDbContext => _context;

		public IAcceptOffersRepository AcceptOffersRepository => _acceptOffersRepository ?? (_acceptOffersRepository = new AcceptOffersRepository(_context));

		public IContactsRepository ContactsRepository => _contactsRepository ?? (_contactsRepository = new ContactsRepository(_context));

		public IOffersRepository OffersRepository => _offersRepository ?? (_offersRepository = new OffersRepository(_context));

		public IProductOffersRepository ProductOffersRepository => _productOffersRepository ?? (_productOffersRepository = new ProductOffersRepository(_context));

		public IUsersRepository UsersRepository => _usersRepository ?? (_usersRepository = new UsersRepository(_context));

		public void Dispose()
		{
			_context.Dispose();
		}

		public async Task<int> SaveChanges()
		{
			return await _context.SaveChangesAsync();
		}
	}
}