using form.DataAccessLayer.EntityFramework;
using form.Entities;
using form.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form.BusinessLayer
{
    public class formManager
    {
        private Repository<myform> repo_form = new Repository<myform>();

        public void RegisterMyForm(myFormViewModel data)
        {
            
            BusinessLayerResult<myform> layerResult = new BusinessLayerResult<myform>();
            if(data!=null)
            {

                int dbResult = repo_form.Insert(new myform()
                {
                    name = data.name,
                    description = data.description,
                    createdBy = data.createdBy,
                    createdAt = DateTime.Now
                });
             }


           
        }
    }
}
