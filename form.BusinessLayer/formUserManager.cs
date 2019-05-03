using form.DataAccessLayer.EntityFramework;
using form.Entities;
using form.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form.BusinessLayer
{
    public class formUserManager
    {
        private Repository<formUser> repo_user = new Repository<formUser>();

        public BusinessLayerResult<formUser> RegisterUser(RegisterViewModel data)
        {
            formUser user = repo_user.Find(x => x.email == data.email);
            BusinessLayerResult<formUser> layerResult = new BusinessLayerResult<formUser>();

            if(user!=null)
            {
                if(user.email==data.email)
                {
                    layerResult.Errors.Add("kullanıcı emaili zaten var");
                }
            }
            else
            {
                int dbResult = repo_user.Insert(new formUser()
                {
                    ad=data.ad,
                    soyad=data.soyad,
                    email=data.email,
                    yas=data.yas,
                    sifre=data.sifre
                              
                });
                if(dbResult>0)
                {
                    layerResult.Result = repo_user.Find(x => x.email == data.email);
                }
            }
            return layerResult;

        }

        public BusinessLayerResult<formUser> loginUser(LoginViewModel data)
        {
            BusinessLayerResult<formUser> res = new BusinessLayerResult<formUser>();
            res.Result = repo_user.Find(x => x.email == data.email && x.sifre==data.sifre);

            if(res.Result!=null)
            {
               
            }
            else
            {
                res.Errors.Add("kullanıcının email yada şifresi uyuşmuyor");
            }
            return res;
        }
    }
}
