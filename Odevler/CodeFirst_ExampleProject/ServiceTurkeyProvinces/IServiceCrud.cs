using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTurkeyProvinces
{
    [ServiceContract]
    public interface IServiceCrud
    {
        [OperationContract]
        void addPlacesToVisit(PlacesToVisit visit);
        [OperationContract]
        void addRegion(Region reg);
        [OperationContract]
        void updatePlacesToVisit(PlacesToVisit visit);
        [OperationContract]
        void updateRegion(Region reg);
        [OperationContract]
        void deletePlacesToVisit(int visit);
        [OperationContract]
        void deleteRegion(int reg);
        [OperationContract]
        List<PlacesToVisit> listVisit();
        [OperationContract]
        List<Region> listRegion();
    }
}
