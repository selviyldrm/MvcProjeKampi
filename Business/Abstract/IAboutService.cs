using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void AboutAdd(About category);
        About GetById(int id);
        void AboutDelete(About category);
        void AboutUpdate(About category);

    }
}
