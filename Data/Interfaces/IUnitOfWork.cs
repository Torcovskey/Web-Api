using Data.Entity;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Interfaces
{
    interface IUnitOfWork
    {
        void Save();
    }
}
