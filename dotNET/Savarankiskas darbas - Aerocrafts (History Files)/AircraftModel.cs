using Aeroplanes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplanes.Models
{
    public class AircraftModel
    {
        public int aircraftModelId;
        public string aircraftModelType;
        public string aircraftModelName;

        public AircraftModel(string type, string name)
        {
            aircraftModelId = (AircraftModelRepository.aircraftModels.Count > 0) ? AircraftModelRepository.aircraftModels.Last().aircraftModelId + 1 : 1;
            aircraftModelType = type;
            aircraftModelName = name;
        }
    }
}
