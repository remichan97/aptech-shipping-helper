using ShippingHelper.Core.Data;
using ShippingHelper.Core.IRepository;
using ShippingHelper.Core.Repository;
using ShippingHelper.Repository.IRepository;
using ShippingHelper.Repository.Repository;

namespace ShippingHelper.Repository.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContext _context;
		private IAcceptOffersRepository _acceptOffersRepository;
		private IContactsRepository _contactsRepository;
		private IOffersRepository _offersRepository;
		private IProductOffersRepository _productOffersRepository;
		private IUsersRepository _usersRepository;
        private IReportMerchantsRepository _reportMerchantsRepository;

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

		public IReportMerchantsRepository ReportMerchantsRepository => _reportMerchantsRepository ?? (_reportMerchantsRepository = new ReportedMerchantsRepository(_context));

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