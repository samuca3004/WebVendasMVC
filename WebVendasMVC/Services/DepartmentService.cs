using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebVendasMVC.Models;

namespace WebVendasMVC.Services
{
    public class DepartmentService
    {
        private readonly WebVendasMVCContext _context;

        public DepartmentService(WebVendasMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
