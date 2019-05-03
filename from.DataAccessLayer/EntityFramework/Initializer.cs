using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using form.Entities;

namespace form.DataAccessLayer.EntityFramework
{
    public class Initializer:CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            formUser admin = new formUser()
            {
                ad="cihad",
                soyad="inan",
                sifre="123456",
                email="ebucihadinan@hotmail.com.tr",
                yas=24,
                adminMi=true
            };

            formUser standart = new formUser()
            {
                ad = "omer",
                soyad = "inan",
                sifre = "123456",
                email = "omerinan@hotmail.com.tr",
                yas = 30,
                adminMi = false
            };
            context.formUsers.Add(admin);
            context.formUsers.Add(standart);
            context.SaveChanges();

            //deneme formları
            for(int i=0;i<10;i++)
            {
                myform deneme = new myform()
                {
                    name = FakeData.NameData.GetFirstName(),
                    createdAt = FakeData.DateTimeData.GetDatetime(),
                    createdBy = FakeData.NumberData.GetNumber()%2+1,
                    description = FakeData.PlaceData.GetStreetName(),
                    
                };
                context.forms.Add(deneme);
                context.SaveChanges();
                
            }

        }
    }
}
