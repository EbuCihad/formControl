using form.DataAccessLayer.EntityFramework;
using form.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form.BusinessLayer
{
    public class myFormManager
    {
        private Repository<myform> repo_form = new Repository<myform>();
        public string _name;
        public string _description;

        public List<myform> GetAllMyForm()
        {
            return repo_form.List();
        }
        public myform getMyFormById(int id)
        {
            return repo_form.Find(x => x.id == id);
        }
    }
}
