

using zigit.Models;

namespace zigit.Data
{
    public interface IProjectRepo
    {
        public Project GetProjectById(int id);
    }
}
