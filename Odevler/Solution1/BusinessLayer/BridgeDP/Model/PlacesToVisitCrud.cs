using DatabaseBusiness.Context;
using DatabaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BridgeDP.Model
{
    public class PlacesToVisitCrud : IBridgeImplemente<PlacesToVisit>
    {
        TurkeyProvincesContext dbContext = new TurkeyProvincesContext();

        public void Add(PlacesToVisit t)
        {
            dbContext.placesToVisit.Add(t);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var visitDelete = (from visit in dbContext.placesToVisit
                               where visit.PlaceToVisitID == id
                               select visit).First();
            dbContext.placesToVisit.Remove(visitDelete);
            dbContext.SaveChanges();

        }

        public List<PlacesToVisit> List()
        {
            return dbContext.placesToVisit.ToList();
        }

        public void Update(PlacesToVisit t)
        {
            var visitUpdate = (from visit in dbContext.placesToVisit
                               where visit.PlaceToVisitID == t.PlaceToVisitID
                               select visit).First();
            visitUpdate.PlaceToVisitID = t.PlaceToVisitID;
            visitUpdate.PlaceToVisit = t.PlaceToVisit;
            //visitUpdate.Provinces = t.Provinces;
            dbContext.SaveChanges();
        }
    }
}
