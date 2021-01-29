using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IO___CodeFirst_EntFram.Models.Mapping;

namespace IO___CodeFirst_EntFram.Models
{
    public partial class NorthwindContext : DbContext
    {
        static NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        public NorthwindContext()
            : base("Name=NorthwindContext")
        {
        }

        public DbSet<Bolge> Bolges { get; set; }
        public DbSet<Bolgeler> Bolgelers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<MusteriDemographic> MusteriDemographics { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Nakliyeciler> Nakliyecilers { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Personeller> Personellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Alfabetik_Sirali_Urunler_Listesi> Alfabetik_Sirali_Urunler_Listesis { get; set; }
        public DbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; }
        public DbSet<Biten_Urunler_Listesi> Biten_Urunler_Listesis { get; set; }
        public DbSet<Category_Sales_for_1997> Category_Sales_for_1997 { get; set; }
        public DbSet<Current_Product_List> Current_Product_Lists { get; set; }
        public DbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Kategorilere_Gore_Urunler> Kategorilere_Gore_Urunlers { get; set; }
        public DbSet<Order_Details_Extended> Order_Details_Extendeds { get; set; }
        public DbSet<Order_Subtotal> Order_Subtotals { get; set; }
        public DbSet<Orders_Qry> Orders_Qries { get; set; }
        public DbSet<Ortalama_Maliyetin_Uzerindeki_Urunler> Ortalama_Maliyetin_Uzerindeki_Urunlers { get; set; }
        public DbSet<Product_Sales_for_1997> Product_Sales_for_1997 { get; set; }
        public DbSet<Products_Above_Average_Price> Products_Above_Average_Prices { get; set; }
        public DbSet<Products_by_Category> Products_by_Categories { get; set; }
        public DbSet<Sales_by_Category> Sales_by_Categories { get; set; }
        public DbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; set; }
        public DbSet<Satislar_Sorgusu> Satislar_Sorgusus { get; set; }
        public DbSet<Sehirlere_Gore_Musteri_ve_Tedarikciler> Sehirlere_Gore_Musteri_ve_Tedarikcilers { get; set; }
        public DbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarters { get; set; }
        public DbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Years { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BolgeMap());
            modelBuilder.Configurations.Add(new BolgelerMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerDemographicMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new MusteriDemographicMap());
            modelBuilder.Configurations.Add(new MusterilerMap());
            modelBuilder.Configurations.Add(new NakliyecilerMap());
            modelBuilder.Configurations.Add(new Order_DetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new PersonellerMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TedarikcilerMap());
            modelBuilder.Configurations.Add(new TerritoryMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
            modelBuilder.Configurations.Add(new Alfabetik_Sirali_Urunler_ListesiMap());
            modelBuilder.Configurations.Add(new Alphabetical_list_of_productMap());
            modelBuilder.Configurations.Add(new Biten_Urunler_ListesiMap());
            modelBuilder.Configurations.Add(new Category_Sales_for_1997Map());
            modelBuilder.Configurations.Add(new Current_Product_ListMap());
            modelBuilder.Configurations.Add(new Customer_and_Suppliers_by_CityMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new Kategorilere_Gore_UrunlerMap());
            modelBuilder.Configurations.Add(new Order_Details_ExtendedMap());
            modelBuilder.Configurations.Add(new Order_SubtotalMap());
            modelBuilder.Configurations.Add(new Orders_QryMap());
            modelBuilder.Configurations.Add(new Ortalama_Maliyetin_Uzerindeki_UrunlerMap());
            modelBuilder.Configurations.Add(new Product_Sales_for_1997Map());
            modelBuilder.Configurations.Add(new Products_Above_Average_PriceMap());
            modelBuilder.Configurations.Add(new Products_by_CategoryMap());
            modelBuilder.Configurations.Add(new Sales_by_CategoryMap());
            modelBuilder.Configurations.Add(new Sales_Totals_by_AmountMap());
            modelBuilder.Configurations.Add(new Satislar_SorgusuMap());
            modelBuilder.Configurations.Add(new Sehirlere_Gore_Musteri_ve_TedarikcilerMap());
            modelBuilder.Configurations.Add(new Summary_of_Sales_by_QuarterMap());
            modelBuilder.Configurations.Add(new Summary_of_Sales_by_YearMap());
        }
    }
}
