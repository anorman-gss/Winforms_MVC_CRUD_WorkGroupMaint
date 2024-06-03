using GSSEO;
using System.Collections.Generic;
using System.Linq;
using Winforms_MVC_CRUD.Models;
using Winforms_MVC_CRUD.Services;

namespace Winforms_MVC_CRUD.Controllers
{
    internal class WorkGroupController
    {
        private IWorkGroupRepository _repository;
        private ILogger _logger;

        public WorkGroupController(IWorkGroupRepository workgroupRepository, ILogger logger)
        {
            _repository = workgroupRepository;
            _logger = logger;
        }

        public List<WorkGroupModel>  GetAllWorkGroups()
        {
            var workgroups = _repository.GetAll();

            if (workgroups == null || workgroups.Count == 0)
            {
                _logger.Info("No WorkGroups found");
            }

            return workgroups;
        }

        public WorkGroupModel GetWorkGroupByCode(string code)
        {
            var workgrp = _repository.GetByCode(code);

            if (workgrp == null)
            {
                _logger.Info($"No WorkGroup found for Code {code}");
            }

            return workgrp;
        }

        public void AddWorkGroup(WorkGroupModel workgrpmodel)
        {
            var isAdded = _repository.Add(workgrpmodel);

            if (!isAdded)
            {
                _logger.Error($"Unable to add Workgroup");
            }
        }

        public void UpdateWorkGroup(WorkGroupModel workgrpmodel)
        {
            var isUpdated = _repository.Update(workgrpmodel);

            if (!isUpdated)
            {
                _logger.Error($"Unabled to Update WorkGroup with Code {workgrpmodel.WorkGroup.WorkgroupCode}");
            }
        }

        public void DeleteWorkGroup(string workgroupcode)
        {
            var isDeleted = _repository.Delete(workgroupcode);

            if (!isDeleted)
            {
                _logger.Error($"Unabled to Update Person with Code {workgroupcode}");
            }
        }
    }
}
