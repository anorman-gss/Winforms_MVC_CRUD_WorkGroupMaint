using System;
using System.Collections.Generic;
using Xunit;
using Winforms_MVC_CRUD.Services;
using Winforms_MVC_CRUD.Models;


namespace WorkGroup_Tests
{
    public class WorkGroupTest1 : IDisposable
    {
        public void  WorkGroupTest1
        {

        }
    [Fact]
        public void Test_WorkGroup_GetAll()
        {
            ILogger logger = new Logger();
            WorkGroupRepository workgroupcontroller = new WorkGroupRepository(logger); 

            List<WorkGroupModel> MyTestWkgrpList = workgroupcontroller.GetAll();
            Assert.True(MyTestWkgrpList.Count == 5);
            Assert.True(MyTestWkgrpList[0].WorkGroup.WorkgroupCode == "*AS0");
            Assert.True(MyTestWkgrpList[0].WorkGroupLines.Count == 1);
            Assert.True(MyTestWkgrpList[0].WorkGroupLines[0].WorkcenterCode == "AS01");
            Assert.True(MyTestWkgrpList[1].WorkGroup.WorkgroupCode == "*CL0");
            Assert.True(MyTestWkgrpList[1].WorkGroupLines.Count == 2);
            Assert.True(MyTestWkgrpList[1].WorkGroupLines[0].WorkcenterCode == "CL01");
            Assert.True(MyTestWkgrpList[1].WorkGroupLines[1].WorkcenterCode == "CL02");
            Assert.True(MyTestWkgrpList[2].WorkGroup.WorkgroupCode == "*CM0");
            Assert.True(MyTestWkgrpList[2].WorkGroupLines.Count == 2);
            Assert.True(MyTestWkgrpList[2].WorkGroupLines[0].WorkcenterCode == "CM01");
            Assert.True(MyTestWkgrpList[2].WorkGroupLines[1].WorkcenterCode == "CM02");
            Assert.True(MyTestWkgrpList[3].WorkGroup.WorkgroupCode == "*DB0");
            Assert.True(MyTestWkgrpList[3].WorkGroupLines.Count == 1);
            Assert.True(MyTestWkgrpList[3].WorkGroupLines[0].WorkcenterCode == "DB01");
            Assert.True(MyTestWkgrpList[4].WorkGroup.WorkgroupCode == "*QC0");
            Assert.True(MyTestWkgrpList[4].WorkGroupLines.Count == 1);
            Assert.True(MyTestWkgrpList[4].WorkGroupLines[0].WorkcenterCode == "QC01");
            Assert.True(MyTestWkgrpList[5].WorkGroup.WorkgroupCode == "*SW0");
            Assert.True(MyTestWkgrpList[5].WorkGroupLines.Count == 1);
            Assert.True(MyTestWkgrpList[5].WorkGroupLines[0].WorkcenterCode == "SW01");

            logger = null;
            workgroupcontroller = null;
        }

        
    }
}
