using ForumHCFE.Data.Models;
using System.Threading.Tasks;

namespace ForumHCFE.Data
{
    public interface IPostReply
    {
        PostReply GetById(int id);
        Task Edit(int id, string message);
        Task Delete(int id);
    }
}