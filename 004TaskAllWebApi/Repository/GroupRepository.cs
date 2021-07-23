using _004TaskAllWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004TaskAllWebApi.Repository
{
    public class GroupRepository:IRepository<Group>
    {
        private readonly ContextDB context;
        public IEnumerable<Group> All() {
            var group = from gr in context.Groups select gr;
            return group;
        }
        public GroupRepository(ContextDB context) {
            this.context = context;  
        }
        public void Add(Group group) {
            context.Groups.Add(group);
            context.SaveChanges();
        } 
        public void Delete(Group group)
        {
            context.Groups.Remove(group);
            context.SaveChanges();
        }
        public Group FindById(string Id) {
            throw new System.NotImplementedException(); 
        }
        public void Update(Group group) {
            context.Groups.Update(group);
            context.SaveChanges();
        }
        public Group FindById(int Id) {
            return context.Groups.FirstOrDefault(x => x.Id == Id);
        }
    }
}
