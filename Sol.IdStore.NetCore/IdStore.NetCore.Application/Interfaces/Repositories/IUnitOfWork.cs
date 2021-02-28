using System;
using System.Collections.Generic;
using System.Text;

namespace IdStore.NetCore.Application.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
