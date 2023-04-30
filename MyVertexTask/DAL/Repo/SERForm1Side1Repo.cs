using MyVertexTask.Domain.Models;
using System.Threading.Tasks;

namespace MyVertexTask.DAL.Repo
{
    public class SERForm1Side1Repo : ISERForm1Side1Repo
    {
        private readonly MyVertexTaskDBContext _dbContext = new MyVertexTaskDBContext();

        public void SaveForm(SERForm1Side1 form)
        {
            _dbContext.SERForm1Side1s.Add(form);
            _dbContext.SaveChangesAsync();
        }
    }
}