﻿using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public interface IImageFileService
    {
        List<ImageFile> GetList();
    }
}
