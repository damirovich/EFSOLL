using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _004TaskAllWebApi.Models;
using _004TaskAllWebApi.Repository;

namespace _004TaskAllWebApi.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly ContextDB context;
        public IEnumerable<Student> All(){
            var student = from st in context.Students select st;
            return student;
        }
        public StudentRepository(ContextDB context)
        {
            this.context = context;
        }
        public void Add(Student student) {
            context.Students.Add(student);
            context.SaveChanges();
        }
        public void Delete(Student student) {
            context.Students.Remove(student);
            context.SaveChanges();
        }
        public Student FindById(string Id) {
            throw new System.NotImplementedException();
        }
        public void Update(Student student) {
            context.Students.Update(student);
            context.SaveChanges();
        }
        public Student FindById(int Id) {
            return context.Students.FirstOrDefault(x => x.Id == Id);
        }
    }
}
