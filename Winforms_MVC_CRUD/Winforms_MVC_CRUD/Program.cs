using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms_MVC_CRUD.Controllers;
using Winforms_MVC_CRUD.Services;
using Winforms_MVC_CRUD.Views;

namespace Winforms_MVC_CRUD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //PersonRepository personRepository = new PersonRepository();
            ILogger logger = new Logger();
            //PersonController personController = new PersonController(personRepository, logger );
            //InventoryRepository inventorycontroller = new InventoryRepository(logger);
            WorkGroupRepository workgroupcontroller = new WorkGroupRepository(logger);
            //Application.Run(new PersonView(personController));
            //Application.Run(new InventoryView(inventorycontroller));
            Application.Run(new gvWorkGroup(workgroupcontroller));
        }
    }
}
