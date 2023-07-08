namespace WebApi.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAdministrateurRepository Administrateur { get; }

        Task CompleteAsync();
    }
}
