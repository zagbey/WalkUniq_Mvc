using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkUniq.DataAccess.DbInitializer
{
    public interface IDbInitializer
    {
        //bu metod admin ve kullanıcı rolleri oluşturulmasından sorumlu 
        void Initialize();
    }
}
