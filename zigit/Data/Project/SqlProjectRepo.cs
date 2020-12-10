

using zigit.Models;

namespace zigit.Data
{
    public class SqlProjectRepo : IProjectRepo
    {
        private readonly UserContext _context;
        public SqlProjectRepo(UserContext userContext)
        {
            _context = userContext;
        }
        public Project GetProjectById(int id)
        {
            return _context.Projects.Find(id);
        }
    }
}
