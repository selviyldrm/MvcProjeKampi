using DataAccess.Abstract;
using DataAccess.Concreate.Repositories;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
   public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
