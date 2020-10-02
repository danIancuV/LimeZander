namespace Data.LimeZander.Persistence
{
    public abstract class BaseRepository
    {
        public readonly LimeZanderContext _context;

        public BaseRepository(LimeZanderContext context)
        {
            _context = context;
        }
    }
}
