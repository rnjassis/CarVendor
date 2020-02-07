using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace vega.Model
{
    [Table("VehicleFeature")]
    public class VehicleFeature
    {

        public int VehicleId { get; set; }
        public int FeatureId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Feature Feature { get; set; }
        public ICollection<VehicleFeature> Features { get; set; }
        public VehicleFeature()
        {
            Features = new Collection<VehicleFeature>();
        }
    }
}
