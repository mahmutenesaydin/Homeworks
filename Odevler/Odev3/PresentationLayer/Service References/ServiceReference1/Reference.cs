﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayer.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/DataLayer")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryID {
            get {
                return this.CategoryIDField;
            }
            set {
                if ((this.CategoryIDField.Equals(value) != true)) {
                    this.CategoryIDField = value;
                    this.RaisePropertyChanged("CategoryID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/DataLayer")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> UnitPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> UnıtsInStockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> UnıtsInStock {
            get {
                return this.UnıtsInStockField;
            }
            set {
                if ((this.UnıtsInStockField.Equals(value) != true)) {
                    this.UnıtsInStockField = value;
                    this.RaisePropertyChanged("UnıtsInStock");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Supplier", Namespace="http://schemas.datacontract.org/2004/07/DataLayer")]
    [System.SerializableAttribute()]
    public partial class Supplier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SupplierIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactName {
            get {
                return this.ContactNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNameField, value) != true)) {
                    this.ContactNameField = value;
                    this.RaisePropertyChanged("ContactName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactTitle {
            get {
                return this.ContactTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactTitleField, value) != true)) {
                    this.ContactTitleField = value;
                    this.RaisePropertyChanged("ContactTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SupplierID {
            get {
                return this.SupplierIDField;
            }
            set {
                if ((this.SupplierIDField.Equals(value) != true)) {
                    this.SupplierIDField = value;
                    this.RaisePropertyChanged("SupplierID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceContract")]
    public interface IServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/AddCategory", ReplyAction="http://tempuri.org/IServiceContract/AddCategoryResponse")]
        void AddCategory(PresentationLayer.ServiceReference1.Category cat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/AddCategory", ReplyAction="http://tempuri.org/IServiceContract/AddCategoryResponse")]
        System.Threading.Tasks.Task AddCategoryAsync(PresentationLayer.ServiceReference1.Category cat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/UpdateCategory", ReplyAction="http://tempuri.org/IServiceContract/UpdateCategoryResponse")]
        void UpdateCategory(PresentationLayer.ServiceReference1.Category cat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/UpdateCategory", ReplyAction="http://tempuri.org/IServiceContract/UpdateCategoryResponse")]
        System.Threading.Tasks.Task UpdateCategoryAsync(PresentationLayer.ServiceReference1.Category cat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/DeleteCategory", ReplyAction="http://tempuri.org/IServiceContract/DeleteCategoryResponse")]
        void DeleteCategory(int cat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/DeleteCategory", ReplyAction="http://tempuri.org/IServiceContract/DeleteCategoryResponse")]
        System.Threading.Tasks.Task DeleteCategoryAsync(int cat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/ListCategory", ReplyAction="http://tempuri.org/IServiceContract/ListCategoryResponse")]
        PresentationLayer.ServiceReference1.Category[] ListCategory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/ListCategory", ReplyAction="http://tempuri.org/IServiceContract/ListCategoryResponse")]
        System.Threading.Tasks.Task<PresentationLayer.ServiceReference1.Category[]> ListCategoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/AddProduct", ReplyAction="http://tempuri.org/IServiceContract/AddProductResponse")]
        void AddProduct(PresentationLayer.ServiceReference1.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/AddProduct", ReplyAction="http://tempuri.org/IServiceContract/AddProductResponse")]
        System.Threading.Tasks.Task AddProductAsync(PresentationLayer.ServiceReference1.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/UpdateProduct", ReplyAction="http://tempuri.org/IServiceContract/UpdateProductResponse")]
        void UpdateProduct(PresentationLayer.ServiceReference1.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/UpdateProduct", ReplyAction="http://tempuri.org/IServiceContract/UpdateProductResponse")]
        System.Threading.Tasks.Task UpdateProductAsync(PresentationLayer.ServiceReference1.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/DeleteProduct", ReplyAction="http://tempuri.org/IServiceContract/DeleteProductResponse")]
        void DeleteProduct(int prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/DeleteProduct", ReplyAction="http://tempuri.org/IServiceContract/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(int prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/ListProduct", ReplyAction="http://tempuri.org/IServiceContract/ListProductResponse")]
        PresentationLayer.ServiceReference1.Product[] ListProduct();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/ListProduct", ReplyAction="http://tempuri.org/IServiceContract/ListProductResponse")]
        System.Threading.Tasks.Task<PresentationLayer.ServiceReference1.Product[]> ListProductAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/AddSupplier", ReplyAction="http://tempuri.org/IServiceContract/AddSupplierResponse")]
        void AddSupplier(PresentationLayer.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/AddSupplier", ReplyAction="http://tempuri.org/IServiceContract/AddSupplierResponse")]
        System.Threading.Tasks.Task AddSupplierAsync(PresentationLayer.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/UpateSupplier", ReplyAction="http://tempuri.org/IServiceContract/UpateSupplierResponse")]
        void UpateSupplier(PresentationLayer.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/UpateSupplier", ReplyAction="http://tempuri.org/IServiceContract/UpateSupplierResponse")]
        System.Threading.Tasks.Task UpateSupplierAsync(PresentationLayer.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/DeleteSupplier", ReplyAction="http://tempuri.org/IServiceContract/DeleteSupplierResponse")]
        void DeleteSupplier(int sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/DeleteSupplier", ReplyAction="http://tempuri.org/IServiceContract/DeleteSupplierResponse")]
        System.Threading.Tasks.Task DeleteSupplierAsync(int sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/ListSupplier", ReplyAction="http://tempuri.org/IServiceContract/ListSupplierResponse")]
        PresentationLayer.ServiceReference1.Supplier[] ListSupplier();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/ListSupplier", ReplyAction="http://tempuri.org/IServiceContract/ListSupplierResponse")]
        System.Threading.Tasks.Task<PresentationLayer.ServiceReference1.Supplier[]> ListSupplierAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/Login", ReplyAction="http://tempuri.org/IServiceContract/LoginResponse")]
        bool Login(string UserName, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/Login", ReplyAction="http://tempuri.org/IServiceContract/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string UserName, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceContractChannel : PresentationLayer.ServiceReference1.IServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceContractClient : System.ServiceModel.ClientBase<PresentationLayer.ServiceReference1.IServiceContract>, PresentationLayer.ServiceReference1.IServiceContract {
        
        public ServiceContractClient() {
        }
        
        public ServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCategory(PresentationLayer.ServiceReference1.Category cat) {
            base.Channel.AddCategory(cat);
        }
        
        public System.Threading.Tasks.Task AddCategoryAsync(PresentationLayer.ServiceReference1.Category cat) {
            return base.Channel.AddCategoryAsync(cat);
        }
        
        public void UpdateCategory(PresentationLayer.ServiceReference1.Category cat) {
            base.Channel.UpdateCategory(cat);
        }
        
        public System.Threading.Tasks.Task UpdateCategoryAsync(PresentationLayer.ServiceReference1.Category cat) {
            return base.Channel.UpdateCategoryAsync(cat);
        }
        
        public void DeleteCategory(int cat) {
            base.Channel.DeleteCategory(cat);
        }
        
        public System.Threading.Tasks.Task DeleteCategoryAsync(int cat) {
            return base.Channel.DeleteCategoryAsync(cat);
        }
        
        public PresentationLayer.ServiceReference1.Category[] ListCategory() {
            return base.Channel.ListCategory();
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.ServiceReference1.Category[]> ListCategoryAsync() {
            return base.Channel.ListCategoryAsync();
        }
        
        public void AddProduct(PresentationLayer.ServiceReference1.Product prod) {
            base.Channel.AddProduct(prod);
        }
        
        public System.Threading.Tasks.Task AddProductAsync(PresentationLayer.ServiceReference1.Product prod) {
            return base.Channel.AddProductAsync(prod);
        }
        
        public void UpdateProduct(PresentationLayer.ServiceReference1.Product prod) {
            base.Channel.UpdateProduct(prod);
        }
        
        public System.Threading.Tasks.Task UpdateProductAsync(PresentationLayer.ServiceReference1.Product prod) {
            return base.Channel.UpdateProductAsync(prod);
        }
        
        public void DeleteProduct(int prod) {
            base.Channel.DeleteProduct(prod);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(int prod) {
            return base.Channel.DeleteProductAsync(prod);
        }
        
        public PresentationLayer.ServiceReference1.Product[] ListProduct() {
            return base.Channel.ListProduct();
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.ServiceReference1.Product[]> ListProductAsync() {
            return base.Channel.ListProductAsync();
        }
        
        public void AddSupplier(PresentationLayer.ServiceReference1.Supplier sup) {
            base.Channel.AddSupplier(sup);
        }
        
        public System.Threading.Tasks.Task AddSupplierAsync(PresentationLayer.ServiceReference1.Supplier sup) {
            return base.Channel.AddSupplierAsync(sup);
        }
        
        public void UpateSupplier(PresentationLayer.ServiceReference1.Supplier sup) {
            base.Channel.UpateSupplier(sup);
        }
        
        public System.Threading.Tasks.Task UpateSupplierAsync(PresentationLayer.ServiceReference1.Supplier sup) {
            return base.Channel.UpateSupplierAsync(sup);
        }
        
        public void DeleteSupplier(int sup) {
            base.Channel.DeleteSupplier(sup);
        }
        
        public System.Threading.Tasks.Task DeleteSupplierAsync(int sup) {
            return base.Channel.DeleteSupplierAsync(sup);
        }
        
        public PresentationLayer.ServiceReference1.Supplier[] ListSupplier() {
            return base.Channel.ListSupplier();
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.ServiceReference1.Supplier[]> ListSupplierAsync() {
            return base.Channel.ListSupplierAsync();
        }
        
        public bool Login(string UserName, string Password) {
            return base.Channel.Login(UserName, Password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string UserName, string Password) {
            return base.Channel.LoginAsync(UserName, Password);
        }
    }
}