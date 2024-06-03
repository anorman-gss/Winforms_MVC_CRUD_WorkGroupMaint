using GSSEO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms_MVC_CRUD.Models;

namespace Winforms_MVC_CRUD.Services
{
    internal interface IInventoryRepository
    {
        Task<Inventory.Parts> GetAll();
        Task<Inventory.Parts> GetPartsFromPartNumberRange(string begin, string end);
    }
}
