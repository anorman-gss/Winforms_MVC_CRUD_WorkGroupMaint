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
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ILogger _logger;

        private DB _databaseContext { get; }

        public InventoryRepository(ILogger logger)
        {
            _databaseContext = new DB();
            _logger = logger;
        }

        public async Task<Inventory.Parts> GetAll()
        {
            _logger.Info("Retrieving All Parts");

            var parts = new Inventory.Parts(_databaseContext);

            try
            {
                var status = await Task.Run(() => parts.Load(0, new object[0]));

                if (status != 0)
                    throw new Exception($"{typeof(Inventory.Parts).FullName}.Load failed with status {status}");
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString());
            }

            return parts;
        }

        public async Task<Inventory.Parts> GetPartsFromPartNumberRange(string startingPartNumber, string endingPartNumber)
        {
            _logger.Info($"Retrieving part range {startingPartNumber} to {endingPartNumber}");

            var parts = new Inventory.Parts(_databaseContext);

            try
            {
                var status = await Task.Run(() => parts.Load(1286, new object[] { startingPartNumber, string.Empty, endingPartNumber, new String('~', 4) }));

                if (status != 0)
                    throw new Exception($"{typeof(Inventory.Parts).FullName}.Load failed with status {status}");
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString());
            }

            return parts;
        }
    }
}

