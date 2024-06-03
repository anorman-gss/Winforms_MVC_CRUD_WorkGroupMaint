using GSSEO;
using GSSEO.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms_MVC_CRUD.Models;

namespace Winforms_MVC_CRUD.Services
{
    public class WorkGroupRepository : IWorkGroupRepository
    {
        private readonly ILogger _logger;

        private DB _databaseContext { get; }

        public WorkGroupRepository(ILogger logger)
        {
            _databaseContext = new DB();
            _logger = logger;
        }

        public List<WorkGroupModel> GetAll()
        {
            _logger.Info("Retrieving All WorkGroups");
            int iReturn;
            var wrkgrpmodellist = new List<WorkGroupModel>();

            try
            {
                var wrkgrps = new Manufacturing.Support.Workgroups(_databaseContext);
                iReturn = wrkgrps.Load(0, new object[0]);

                if (iReturn != 0)
                    throw new Exception($"{typeof(Manufacturing.Support.Workgroups).FullName}.Load failed with status {iReturn}");
                else
                {
                    _logger.Info("Retrieving All WorkGroupLines by code");

                    foreach (var wrkgrp in wrkgrps)
                    {
                        var wrkgrpmodel = new WorkGroupModel();
                        wrkgrpmodel.WorkGroup = wrkgrp;

                        var wrkgrplines = new Manufacturing.Support.WorkgroupLines(_databaseContext);

                        try
                        {
                            iReturn = wrkgrplines.Load(1, new[] { wrkgrp.WorkgroupCode });

                            if (iReturn != 0)
                                throw new Exception($"{typeof(Manufacturing.Support.WorkgroupLines).FullName}.Load failed with status {iReturn}");
                            else
                            {
                                wrkgrpmodel.WorkGroupLines = wrkgrplines;
                                wrkgrpmodellist.Add(wrkgrpmodel);
                            }
                        }
                        catch (Exception e)
                        {
                            _logger.Error(e.ToString());
                        }

                    }
                }
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString());
            }
            
           return wrkgrpmodellist;
        }

        public bool Add(WorkGroupModel workgrpmodel)
        {
            _logger.Info("Adding WorkGroup");
           int iReturn = 0;
            try
            {
                if (workgrpmodel.WorkGroup.Db == null)
                    workgrpmodel.WorkGroup.Db = _databaseContext;
                iReturn = workgrpmodel.WorkGroup.Insert();
                                
                if (iReturn != 0)
                    throw new Exception($"{typeof(Manufacturing.Support.Workgroup).FullName}.Insert failed with status {iReturn}");
                else
                {
                    foreach (var wkgrpline in workgrpmodel.WorkGroupLines)
                    {
                        if (wkgrpline.Db == null)
                            wkgrpline.Db = _databaseContext;
                        iReturn = wkgrpline.Insert();
                        
                        if (iReturn != 0)
                            throw new Exception($"{typeof(Manufacturing.Support.Workgroup).FullName}.Insert failed with status {iReturn}");
                    }
                    
                };
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString());
            }

            return (iReturn == 0);
         }

        public bool Delete(string workgrpcode)
        {
            _logger.Info("Deleting WorkGroup");
            int iReturn = 0;
                       
            try
            {
                var wrkgrp = new Manufacturing.Support.Workgroup(_databaseContext);
                wrkgrp.WorkgroupCode = workgrpcode;
                iReturn = wrkgrp.Delete();
                
                if (iReturn != 0)
                    throw new Exception($"{typeof(Manufacturing.Support.Workgroup).FullName}.Delete failed with status {iReturn}");
                else
                {
                    _logger.Info("Deleting WorkGroupLines");
                    var wrkgrplines = new Manufacturing.Support.WorkgroupLines(_databaseContext);
                    try
                    {
                        iReturn = wrkgrplines.Load(1, new[] { wrkgrp.WorkgroupCode });

                        if (iReturn != 0)
                            throw new Exception($"{typeof(Manufacturing.Support.WorkgroupLines).FullName}.Load failed with status {iReturn}");
                        else
                        {
                            iReturn = wrkgrplines.Delete();
                        };

                     }
                    catch (Exception e)
                    {
                        _logger.Error(e.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString());
            }

            return (iReturn == 0) ;
        }

        public  WorkGroupModel GetByCode(string workgrpcode)
        {
            _logger.Info("Retrieving WorkGroup By Code");

            var wrkgrpmodel = new WorkGroupModel();
            
            try
            {
                var wrkgrp = new Manufacturing.Support.Workgroup(_databaseContext);
                wrkgrp.WorkgroupCode = workgrpcode;

                int iReturn = wrkgrp.Load(0);

                if (iReturn != 0)
                    throw new Exception($"{typeof(Manufacturing.Support.Workgroups).FullName}.Load failed with status {iReturn}");
                else
                {
                    wrkgrpmodel.WorkGroup = wrkgrp;
                    _logger.Info("Retrieving WorkGroupLines by Code");
                    var wrkgrplines = new Manufacturing.Support.WorkgroupLines(_databaseContext);
                    try
                    {
                        iReturn = wrkgrplines.Load(1, new[] { wrkgrp.WorkgroupCode });

                        if (iReturn != 0)
                            throw new Exception($"{typeof(Manufacturing.Support.WorkgroupLines).FullName}.Load failed with status {iReturn}");
                        else
                        {
                            wrkgrpmodel.WorkGroupLines = wrkgrplines;
                        };
                    }
                    catch (Exception e)
                    {
                        _logger.Error(e.ToString());
                    }

                }
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString());
            }

            return wrkgrpmodel;
        }

        public bool Update(WorkGroupModel workgrpmodel)
        {
            _logger.Info("Updating WorkGroup");
            int iReturn = 0;
            try
            {
                if (workgrpmodel.WorkGroup.Db == null)
                    workgrpmodel.WorkGroup.Db = _databaseContext;
                iReturn = workgrpmodel.WorkGroup.Update();
                
                if (iReturn != 0)
                    throw new Exception($"{typeof(Manufacturing.Support.Workgroup).FullName}.Update failed with status {iReturn}");
                else
                {
                    foreach (var wkgrpline in workgrpmodel.WorkGroupLines)
                    {
                        if (wkgrpline.Db == null)
                            wkgrpline.Db = _databaseContext;
                        iReturn = wkgrpline.Update();
                        
                        if (iReturn != 0)
                            throw new Exception($"{typeof(Manufacturing.Support.WorkgroupLines).FullName}.Insert failed with status {iReturn}");
                    }

                };
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString());
            }

            return (iReturn == 0);
        }
        public string GetWorkCenterDescription(string workcentercode)
        {
            _logger.Info("Getting WorkGroup Description");
            int iReturn = 0;
            try
            {
                Manufacturing.Support.Workcenter workcenterOb = new Manufacturing.Support.Workcenter(_databaseContext);
                workcenterOb.WorkcenterCode = workcentercode;
                iReturn = workcenterOb.Load(0);
                if (iReturn != 0)
                    return null;
                else
                    return workcenterOb.Information.Description;

            }
            catch (Exception e)
            {
                _logger.Error(e.ToString());
            }
            return null;
            
        }
    }
}

