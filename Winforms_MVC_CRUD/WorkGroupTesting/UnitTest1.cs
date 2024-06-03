using Microsoft.VisualStudio.TestTools.UnitTesting;
using Winforms_MVC_CRUD.Models;
using Winforms_MVC_CRUD.Services;
using System.Collections.Generic;
using GSSEO;

namespace WorkGroupTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WorkGroupTest_GetAll()
        {
            ILogger logger = new Logger();
            WorkGroupRepository workgroupcontroller = new WorkGroupRepository(logger);

            List<WorkGroupModel> MyTestWkgrpList = workgroupcontroller.GetAll();
            Assert.IsTrue(MyTestWkgrpList.Count == 6);
            Assert.IsTrue(MyTestWkgrpList[0].WorkGroup.WorkgroupCode == "*AS0");
            Assert.IsTrue(MyTestWkgrpList[0].WorkGroupLines.Count == 1);
            Assert.IsTrue(MyTestWkgrpList[0].WorkGroupLines[0].WorkcenterCode == "AS01");
            Assert.IsTrue(MyTestWkgrpList[1].WorkGroup.WorkgroupCode == "*CL0");
            Assert.IsTrue(MyTestWkgrpList[1].WorkGroupLines.Count == 2);
            Assert.IsTrue(MyTestWkgrpList[1].WorkGroupLines[0].WorkcenterCode == "CL01");
            Assert.IsTrue(MyTestWkgrpList[1].WorkGroupLines[1].WorkcenterCode == "CL02");
            Assert.IsTrue(MyTestWkgrpList[2].WorkGroup.WorkgroupCode == "*CM0");
            Assert.IsTrue(MyTestWkgrpList[2].WorkGroupLines.Count == 2);
            Assert.IsTrue(MyTestWkgrpList[2].WorkGroupLines[0].WorkcenterCode == "CM01");
            Assert.IsTrue(MyTestWkgrpList[2].WorkGroupLines[1].WorkcenterCode == "CM02");
            Assert.IsTrue(MyTestWkgrpList[3].WorkGroup.WorkgroupCode == "*DB0");
            Assert.IsTrue(MyTestWkgrpList[3].WorkGroupLines.Count == 1);
            Assert.IsTrue(MyTestWkgrpList[3].WorkGroupLines[0].WorkcenterCode == "DB01");
            Assert.IsTrue(MyTestWkgrpList[4].WorkGroup.WorkgroupCode == "*QC0");
            Assert.IsTrue(MyTestWkgrpList[4].WorkGroupLines.Count == 1);
            Assert.IsTrue(MyTestWkgrpList[4].WorkGroupLines[0].WorkcenterCode == "QC01");
            Assert.IsTrue(MyTestWkgrpList[5].WorkGroup.WorkgroupCode == "*SW0");
            Assert.IsTrue(MyTestWkgrpList[5].WorkGroupLines.Count == 1);
            Assert.IsTrue(MyTestWkgrpList[5].WorkGroupLines[0].WorkcenterCode == "SW01");

            logger = null;
            workgroupcontroller = null;
        }

        [TestMethod]
        public void WorkGroupTest_GetWorkGroupByCode()
        {
            ILogger logger = new Logger();
            WorkGroupRepository workgroupcontroller = new WorkGroupRepository(logger);

            WorkGroupModel MyTestWkgrp = workgroupcontroller.GetByCode("*CL0");
            
            Assert.IsTrue(MyTestWkgrp.WorkGroup.WorkgroupCode == "*CL0");
            Assert.IsTrue(MyTestWkgrp.WorkGroupLines.Count == 2);
            Assert.IsTrue(MyTestWkgrp.WorkGroupLines[0].WorkcenterCode == "CL01");
            Assert.IsTrue(MyTestWkgrp.WorkGroupLines[1].WorkcenterCode == "CL02");
            
            logger = null;
            workgroupcontroller = null;
        }
        [TestMethod]
        public void WorkGroupTest_TestUpdate()
        {
            ILogger logger = new Logger();
            WorkGroupRepository workgroupcontroller = new WorkGroupRepository(logger);

            WorkGroupModel MyTestWkgrp = workgroupcontroller.GetByCode("*CL0");
            Manufacturing.Support.Workgroup mywkgrp = MyTestWkgrp.WorkGroup;
                        
            Assert.IsTrue(workgroupcontroller.Update(MyTestWkgrp));

            MyTestWkgrp = workgroupcontroller.GetByCode("*CLL");

            Assert.IsTrue(MyTestWkgrp.WorkGroup.WorkgroupCode == "*CLL");
            Assert.IsTrue(MyTestWkgrp.WorkGroupLines.Count == 2);
            Assert.IsTrue(MyTestWkgrp.WorkGroupLines[0].WorkcenterCode == "CL01");
            Assert.IsTrue(MyTestWkgrp.WorkGroupLines[1].WorkcenterCode == "CL02");

            logger = null;
            workgroupcontroller = null;
        }
    }
}
