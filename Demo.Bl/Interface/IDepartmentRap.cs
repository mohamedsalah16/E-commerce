using Demo.Bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Bl.Interface
{
    public interface IDepartmentRap
    {
        IEnumerable<DepartmentVM> Get();
        
        DepartmentVM GetById(int id);

        void Create(DepartmentVM obj);
        void Edit(DepartmentVM obj);
        void Delete(int id);

    }
}
