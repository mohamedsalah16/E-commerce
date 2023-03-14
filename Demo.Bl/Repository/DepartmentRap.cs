using Demo.Bl.Interface;
using Demo.Bl.Models;
using Demo.Dal.Database;
using Demo.Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Bl.Repository
{
    public class DepartmentRap: IDepartmentRap
    {
        DemoContext db=new DemoContext();

       
        public IEnumerable<DepartmentVM> Get()
        {
            var data = GetDepartment();
            return data;
        }

        public DepartmentVM GetById(int id)
        {
            var data = db.Department
                .Where(a => a.Id==id).Select(a => new DepartmentVM
                {
                    Id = a.Id,
                    Name = a.Name,
                    Code = a.Code
                }).FirstOrDefault();
            return data;
        }

        public void Create(DepartmentVM obj)
        {
            Department d=new Department();
            d.Id = obj.Id;  
            d.Name = obj.Name;
            d.Code = obj.Code;

            db.Department.Add(d);
            db.SaveChanges();
        }

        public void Edit(DepartmentVM obj)
        {
            var oldData= db.Department.Find(obj.Id);



            
            oldData.Name = obj.Name;
            oldData.Code = obj.Code;

            db.SaveChanges();

        }


        public void Delete(int id)
        {
            var oldData = db.Department.Find(id);
            db.Department.Remove(oldData);  
            db.SaveChanges();

        }



































        private IEnumerable<DepartmentVM> GetDepartment()
        {
            return db.Department.Select(a => new DepartmentVM
            {
                Id = a.Id,
                Name = a.Name,
                Code = a.Code
            });
        }
    }
}
