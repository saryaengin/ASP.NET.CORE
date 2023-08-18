
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer.Abtract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinesLayer.Abtract;

public interface IAboutService : IGenericService<About>
{
    
}