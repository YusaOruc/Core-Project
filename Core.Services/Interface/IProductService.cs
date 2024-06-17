using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Interface
{
    public interface IProductService
    {
        /// <summary>
        /// Product Ekleme
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task Add(int id);
    }
}
