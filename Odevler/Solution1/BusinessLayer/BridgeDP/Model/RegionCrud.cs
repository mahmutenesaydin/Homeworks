using DatabaseBusiness.Context;
using DatabaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BridgeDP.Model
{
    public class RegionCrud : IBridgeImplemente<Region>
    {
        TurkeyProvincesContext dbContext = new TurkeyProvincesContext();

        public void Add(Region t)
        {
            dbContext.region.Add(t);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var regionDelete = (from reg in dbContext.region
                                where reg.RegionID == id
                                select reg).First();
            dbContext.region.Remove(regionDelete);
            dbContext.SaveChanges();
        }

        public List<Region> List()
        {
            return dbContext.region.ToList();
        }

        public void Update(Region t)
        {
            var regionUpdate = (from reg in dbContext.region
                                where reg.RegionID == t.RegionID
                                select reg).First();
            regionUpdate.RegionID = t.RegionID;
            regionUpdate.RegionName = t.RegionName;
            dbContext.SaveChanges();
        }
    }
}
