using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;
using System.ServiceModel;
using DatabaseBusiness.BridgeDP.Models;

namespace ServiceTurkeyProvinces
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceCrud : IServiceCrud
    {
        PlacesToVisitCrud visitCrud = new PlacesToVisitCrud();
        RegionCrud regCrud = new RegionCrud();
        public void addPlacesToVisit(PlacesToVisit visit)
        {
            visitCrud.Add(visit);
        }

        public void addRegion(Region reg)
        {
            regCrud.Add(reg);
        }

        public List<Region> listRegion()
        {
            return regCrud.List();
        }

        public List<PlacesToVisit> listVisit()
        {
            return visitCrud.List();
        }

        public void updatePlacesToVisit(PlacesToVisit visit)
        {
            visitCrud.Update(visit);
        }

        public void updateRegion(Region reg)
        {
            regCrud.Update(reg);
        }

        public void deletePlacesToVisit(int visit)
        {
            visitCrud.Delete(visit);
        }
        
        public void deleteRegion(int reg)
        {
            regCrud.Delete(reg);
        }
    }
}
