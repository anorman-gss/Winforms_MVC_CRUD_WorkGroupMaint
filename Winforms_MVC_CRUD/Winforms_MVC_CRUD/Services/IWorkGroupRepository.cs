using System.Collections.Generic;
using Winforms_MVC_CRUD.Models;
using GSSEO;

namespace Winforms_MVC_CRUD.Services
{
    internal interface IWorkGroupRepository
    {
        bool Add(WorkGroupModel workgroupmodel);
        bool Delete(string workgroupcode);
        List<WorkGroupModel> GetAll();
        WorkGroupModel GetByCode(string workgroupcode);
        bool Update(WorkGroupModel workgroupmodel);
    }
}