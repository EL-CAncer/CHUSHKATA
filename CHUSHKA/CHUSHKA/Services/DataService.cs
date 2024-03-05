namespace CHUSHKA.Services
{
    using CHUSHKA.Data;
    using Data;

    public abstract class DataService
    {
        protected readonly ChushkaDbContext context;

        protected DataService(ChushkaDbContext context)
        {
            this.context = context;
        }

        
    }
}