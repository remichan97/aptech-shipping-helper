using ShippingHelper.Core.Data;
using ShippingHelper.Repository.IRepository;

namespace ShippingHelper.Repository.Infrastructure;

public interface IUnitOfWork : IDisposable
{
	public IAcceptOffersRepository AcceptOffersRepository { get; }
	public IContactsRepository ContactsRepository { get; }
	public IOffersRepository OffersRepository { get; }
	public IProductOffersRepository ProductOffersRepository { get; }
	public IUsersRepository UsersRepository { get; }
	public IReportMerchantsRepository ReportMerchantsRepository { get; }
	public ICitiesRepository CitiesRepository { get; }
    public AppDbContext AppDbContext { get; }

	Task<int> SaveChanges();
}