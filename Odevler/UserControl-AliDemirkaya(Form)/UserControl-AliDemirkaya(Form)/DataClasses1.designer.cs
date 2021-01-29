﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserControl_AliDemirkaya_Form_
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TurkeyProvinces")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTown(Town instance);
    partial void UpdateTown(Town instance);
    partial void DeleteTown(Town instance);
    partial void InsertVillage(Village instance);
    partial void UpdateVillage(Village instance);
    partial void DeleteVillage(Village instance);
    partial void InsertPopulation(Population instance);
    partial void UpdatePopulation(Population instance);
    partial void DeletePopulation(Population instance);
    partial void InsertProvince(Province instance);
    partial void UpdateProvince(Province instance);
    partial void DeleteProvince(Province instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::UserControl_AliDemirkaya_Form_.Properties.Settings.Default.TurkeyProvincesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Town> Towns
		{
			get
			{
				return this.GetTable<Town>();
			}
		}
		
		public System.Data.Linq.Table<Village> Villages
		{
			get
			{
				return this.GetTable<Village>();
			}
		}
		
		public System.Data.Linq.Table<Population> Populations
		{
			get
			{
				return this.GetTable<Population>();
			}
		}
		
		public System.Data.Linq.Table<Province> Provinces
		{
			get
			{
				return this.GetTable<Province>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Town")]
	public partial class Town : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TownID;
		
		private string _TownName;
		
		private System.Data.Linq.Binary _Images;
		
		private System.Nullable<int> _ProvinceID;
		
		private System.Nullable<int> _PlaceToVisitID;
		
		private System.Nullable<int> _WhatFamousID;
		
		private System.Nullable<int> _PopulationID;
		
		private System.Nullable<int> _TransportationServiceID;
		
		private System.Nullable<int> _PartyID;
		
		private EntitySet<Village> _Villages;
		
		private EntityRef<Population> _Population;
		
		private EntityRef<Province> _Province;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTownIDChanging(int value);
    partial void OnTownIDChanged();
    partial void OnTownNameChanging(string value);
    partial void OnTownNameChanged();
    partial void OnImagesChanging(System.Data.Linq.Binary value);
    partial void OnImagesChanged();
    partial void OnProvinceIDChanging(System.Nullable<int> value);
    partial void OnProvinceIDChanged();
    partial void OnPlaceToVisitIDChanging(System.Nullable<int> value);
    partial void OnPlaceToVisitIDChanged();
    partial void OnWhatFamousIDChanging(System.Nullable<int> value);
    partial void OnWhatFamousIDChanged();
    partial void OnPopulationIDChanging(System.Nullable<int> value);
    partial void OnPopulationIDChanged();
    partial void OnTransportationServiceIDChanging(System.Nullable<int> value);
    partial void OnTransportationServiceIDChanged();
    partial void OnPartyIDChanging(System.Nullable<int> value);
    partial void OnPartyIDChanged();
    #endregion
		
		public Town()
		{
			this._Villages = new EntitySet<Village>(new Action<Village>(this.attach_Villages), new Action<Village>(this.detach_Villages));
			this._Population = default(EntityRef<Population>);
			this._Province = default(EntityRef<Province>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TownID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TownID
		{
			get
			{
				return this._TownID;
			}
			set
			{
				if ((this._TownID != value))
				{
					this.OnTownIDChanging(value);
					this.SendPropertyChanging();
					this._TownID = value;
					this.SendPropertyChanged("TownID");
					this.OnTownIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TownName", DbType="NVarChar(50)")]
		public string TownName
		{
			get
			{
				return this._TownName;
			}
			set
			{
				if ((this._TownName != value))
				{
					this.OnTownNameChanging(value);
					this.SendPropertyChanging();
					this._TownName = value;
					this.SendPropertyChanged("TownName");
					this.OnTownNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProvinceID", DbType="Int")]
		public System.Nullable<int> ProvinceID
		{
			get
			{
				return this._ProvinceID;
			}
			set
			{
				if ((this._ProvinceID != value))
				{
					if (this._Province.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProvinceIDChanging(value);
					this.SendPropertyChanging();
					this._ProvinceID = value;
					this.SendPropertyChanged("ProvinceID");
					this.OnProvinceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaceToVisitID", DbType="Int")]
		public System.Nullable<int> PlaceToVisitID
		{
			get
			{
				return this._PlaceToVisitID;
			}
			set
			{
				if ((this._PlaceToVisitID != value))
				{
					this.OnPlaceToVisitIDChanging(value);
					this.SendPropertyChanging();
					this._PlaceToVisitID = value;
					this.SendPropertyChanged("PlaceToVisitID");
					this.OnPlaceToVisitIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WhatFamousID", DbType="Int")]
		public System.Nullable<int> WhatFamousID
		{
			get
			{
				return this._WhatFamousID;
			}
			set
			{
				if ((this._WhatFamousID != value))
				{
					this.OnWhatFamousIDChanging(value);
					this.SendPropertyChanging();
					this._WhatFamousID = value;
					this.SendPropertyChanged("WhatFamousID");
					this.OnWhatFamousIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PopulationID", DbType="Int")]
		public System.Nullable<int> PopulationID
		{
			get
			{
				return this._PopulationID;
			}
			set
			{
				if ((this._PopulationID != value))
				{
					if (this._Population.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPopulationIDChanging(value);
					this.SendPropertyChanging();
					this._PopulationID = value;
					this.SendPropertyChanged("PopulationID");
					this.OnPopulationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransportationServiceID", DbType="Int")]
		public System.Nullable<int> TransportationServiceID
		{
			get
			{
				return this._TransportationServiceID;
			}
			set
			{
				if ((this._TransportationServiceID != value))
				{
					this.OnTransportationServiceIDChanging(value);
					this.SendPropertyChanging();
					this._TransportationServiceID = value;
					this.SendPropertyChanged("TransportationServiceID");
					this.OnTransportationServiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartyID", DbType="Int")]
		public System.Nullable<int> PartyID
		{
			get
			{
				return this._PartyID;
			}
			set
			{
				if ((this._PartyID != value))
				{
					this.OnPartyIDChanging(value);
					this.SendPropertyChanging();
					this._PartyID = value;
					this.SendPropertyChanged("PartyID");
					this.OnPartyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Town_Village", Storage="_Villages", ThisKey="TownID", OtherKey="TownID")]
		public EntitySet<Village> Villages
		{
			get
			{
				return this._Villages;
			}
			set
			{
				this._Villages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Population_Town", Storage="_Population", ThisKey="PopulationID", OtherKey="PopulationID", IsForeignKey=true)]
		public Population Population
		{
			get
			{
				return this._Population.Entity;
			}
			set
			{
				Population previousValue = this._Population.Entity;
				if (((previousValue != value) 
							|| (this._Population.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Population.Entity = null;
						previousValue.Towns.Remove(this);
					}
					this._Population.Entity = value;
					if ((value != null))
					{
						value.Towns.Add(this);
						this._PopulationID = value.PopulationID;
					}
					else
					{
						this._PopulationID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Population");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Province_Town", Storage="_Province", ThisKey="ProvinceID", OtherKey="ProvinceID", IsForeignKey=true)]
		public Province Province
		{
			get
			{
				return this._Province.Entity;
			}
			set
			{
				Province previousValue = this._Province.Entity;
				if (((previousValue != value) 
							|| (this._Province.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Province.Entity = null;
						previousValue.Towns.Remove(this);
					}
					this._Province.Entity = value;
					if ((value != null))
					{
						value.Towns.Add(this);
						this._ProvinceID = value.ProvinceID;
					}
					else
					{
						this._ProvinceID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Province");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Villages(Village entity)
		{
			this.SendPropertyChanging();
			entity.Town = this;
		}
		
		private void detach_Villages(Village entity)
		{
			this.SendPropertyChanging();
			entity.Town = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Village")]
	public partial class Village : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _VillageID;
		
		private string _VillageName;
		
		private System.Data.Linq.Binary _Images;
		
		private System.Nullable<int> _TownID;
		
		private System.Nullable<int> _PopulationID;
		
		private EntityRef<Town> _Town;
		
		private EntityRef<Population> _Population;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVillageIDChanging(int value);
    partial void OnVillageIDChanged();
    partial void OnVillageNameChanging(string value);
    partial void OnVillageNameChanged();
    partial void OnImagesChanging(System.Data.Linq.Binary value);
    partial void OnImagesChanged();
    partial void OnTownIDChanging(System.Nullable<int> value);
    partial void OnTownIDChanged();
    partial void OnPopulationIDChanging(System.Nullable<int> value);
    partial void OnPopulationIDChanged();
    #endregion
		
		public Village()
		{
			this._Town = default(EntityRef<Town>);
			this._Population = default(EntityRef<Population>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VillageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int VillageID
		{
			get
			{
				return this._VillageID;
			}
			set
			{
				if ((this._VillageID != value))
				{
					this.OnVillageIDChanging(value);
					this.SendPropertyChanging();
					this._VillageID = value;
					this.SendPropertyChanged("VillageID");
					this.OnVillageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VillageName", DbType="NVarChar(50)")]
		public string VillageName
		{
			get
			{
				return this._VillageName;
			}
			set
			{
				if ((this._VillageName != value))
				{
					this.OnVillageNameChanging(value);
					this.SendPropertyChanging();
					this._VillageName = value;
					this.SendPropertyChanged("VillageName");
					this.OnVillageNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TownID", DbType="Int")]
		public System.Nullable<int> TownID
		{
			get
			{
				return this._TownID;
			}
			set
			{
				if ((this._TownID != value))
				{
					if (this._Town.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTownIDChanging(value);
					this.SendPropertyChanging();
					this._TownID = value;
					this.SendPropertyChanged("TownID");
					this.OnTownIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PopulationID", DbType="Int")]
		public System.Nullable<int> PopulationID
		{
			get
			{
				return this._PopulationID;
			}
			set
			{
				if ((this._PopulationID != value))
				{
					if (this._Population.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPopulationIDChanging(value);
					this.SendPropertyChanging();
					this._PopulationID = value;
					this.SendPropertyChanged("PopulationID");
					this.OnPopulationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Town_Village", Storage="_Town", ThisKey="TownID", OtherKey="TownID", IsForeignKey=true)]
		public Town Town
		{
			get
			{
				return this._Town.Entity;
			}
			set
			{
				Town previousValue = this._Town.Entity;
				if (((previousValue != value) 
							|| (this._Town.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Town.Entity = null;
						previousValue.Villages.Remove(this);
					}
					this._Town.Entity = value;
					if ((value != null))
					{
						value.Villages.Add(this);
						this._TownID = value.TownID;
					}
					else
					{
						this._TownID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Town");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Population_Village", Storage="_Population", ThisKey="PopulationID", OtherKey="PopulationID", IsForeignKey=true)]
		public Population Population
		{
			get
			{
				return this._Population.Entity;
			}
			set
			{
				Population previousValue = this._Population.Entity;
				if (((previousValue != value) 
							|| (this._Population.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Population.Entity = null;
						previousValue.Villages.Remove(this);
					}
					this._Population.Entity = value;
					if ((value != null))
					{
						value.Villages.Add(this);
						this._PopulationID = value.PopulationID;
					}
					else
					{
						this._PopulationID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Population");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Population")]
	public partial class Population : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PopulationID;
		
		private string _Population1;
		
		private EntitySet<Town> _Towns;
		
		private EntitySet<Village> _Villages;
		
		private EntitySet<Province> _Provinces;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPopulationIDChanging(int value);
    partial void OnPopulationIDChanged();
    partial void OnPopulation1Changing(string value);
    partial void OnPopulation1Changed();
    #endregion
		
		public Population()
		{
			this._Towns = new EntitySet<Town>(new Action<Town>(this.attach_Towns), new Action<Town>(this.detach_Towns));
			this._Villages = new EntitySet<Village>(new Action<Village>(this.attach_Villages), new Action<Village>(this.detach_Villages));
			this._Provinces = new EntitySet<Province>(new Action<Province>(this.attach_Provinces), new Action<Province>(this.detach_Provinces));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PopulationID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PopulationID
		{
			get
			{
				return this._PopulationID;
			}
			set
			{
				if ((this._PopulationID != value))
				{
					this.OnPopulationIDChanging(value);
					this.SendPropertyChanging();
					this._PopulationID = value;
					this.SendPropertyChanged("PopulationID");
					this.OnPopulationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Population", Storage="_Population1", DbType="NVarChar(25)")]
		public string Population1
		{
			get
			{
				return this._Population1;
			}
			set
			{
				if ((this._Population1 != value))
				{
					this.OnPopulation1Changing(value);
					this.SendPropertyChanging();
					this._Population1 = value;
					this.SendPropertyChanged("Population1");
					this.OnPopulation1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Population_Town", Storage="_Towns", ThisKey="PopulationID", OtherKey="PopulationID")]
		public EntitySet<Town> Towns
		{
			get
			{
				return this._Towns;
			}
			set
			{
				this._Towns.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Population_Village", Storage="_Villages", ThisKey="PopulationID", OtherKey="PopulationID")]
		public EntitySet<Village> Villages
		{
			get
			{
				return this._Villages;
			}
			set
			{
				this._Villages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Population_Province", Storage="_Provinces", ThisKey="PopulationID", OtherKey="PopulationID")]
		public EntitySet<Province> Provinces
		{
			get
			{
				return this._Provinces;
			}
			set
			{
				this._Provinces.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Towns(Town entity)
		{
			this.SendPropertyChanging();
			entity.Population = this;
		}
		
		private void detach_Towns(Town entity)
		{
			this.SendPropertyChanging();
			entity.Population = null;
		}
		
		private void attach_Villages(Village entity)
		{
			this.SendPropertyChanging();
			entity.Population = this;
		}
		
		private void detach_Villages(Village entity)
		{
			this.SendPropertyChanging();
			entity.Population = null;
		}
		
		private void attach_Provinces(Province entity)
		{
			this.SendPropertyChanging();
			entity.Population = this;
		}
		
		private void detach_Provinces(Province entity)
		{
			this.SendPropertyChanging();
			entity.Population = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Province")]
	public partial class Province : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProvinceID;
		
		private string _ProvinceName;
		
		private System.Nullable<int> _PlateCode;
		
		private System.Data.Linq.Binary _Images;
		
		private System.Nullable<int> _PlaceToVisitID;
		
		private System.Nullable<int> _WhatFamousID;
		
		private System.Nullable<int> _PopulationID;
		
		private System.Nullable<int> _RegionID;
		
		private System.Nullable<int> _TransportationServiceID;
		
		private System.Nullable<int> _PartyID;
		
		private EntitySet<Town> _Towns;
		
		private EntityRef<Population> _Population;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProvinceIDChanging(int value);
    partial void OnProvinceIDChanged();
    partial void OnProvinceNameChanging(string value);
    partial void OnProvinceNameChanged();
    partial void OnPlateCodeChanging(System.Nullable<int> value);
    partial void OnPlateCodeChanged();
    partial void OnImagesChanging(System.Data.Linq.Binary value);
    partial void OnImagesChanged();
    partial void OnPlaceToVisitIDChanging(System.Nullable<int> value);
    partial void OnPlaceToVisitIDChanged();
    partial void OnWhatFamousIDChanging(System.Nullable<int> value);
    partial void OnWhatFamousIDChanged();
    partial void OnPopulationIDChanging(System.Nullable<int> value);
    partial void OnPopulationIDChanged();
    partial void OnRegionIDChanging(System.Nullable<int> value);
    partial void OnRegionIDChanged();
    partial void OnTransportationServiceIDChanging(System.Nullable<int> value);
    partial void OnTransportationServiceIDChanged();
    partial void OnPartyIDChanging(System.Nullable<int> value);
    partial void OnPartyIDChanged();
    #endregion
		
		public Province()
		{
			this._Towns = new EntitySet<Town>(new Action<Town>(this.attach_Towns), new Action<Town>(this.detach_Towns));
			this._Population = default(EntityRef<Population>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProvinceID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProvinceID
		{
			get
			{
				return this._ProvinceID;
			}
			set
			{
				if ((this._ProvinceID != value))
				{
					this.OnProvinceIDChanging(value);
					this.SendPropertyChanging();
					this._ProvinceID = value;
					this.SendPropertyChanged("ProvinceID");
					this.OnProvinceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProvinceName", DbType="NVarChar(50)")]
		public string ProvinceName
		{
			get
			{
				return this._ProvinceName;
			}
			set
			{
				if ((this._ProvinceName != value))
				{
					this.OnProvinceNameChanging(value);
					this.SendPropertyChanging();
					this._ProvinceName = value;
					this.SendPropertyChanged("ProvinceName");
					this.OnProvinceNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlateCode", DbType="Int")]
		public System.Nullable<int> PlateCode
		{
			get
			{
				return this._PlateCode;
			}
			set
			{
				if ((this._PlateCode != value))
				{
					this.OnPlateCodeChanging(value);
					this.SendPropertyChanging();
					this._PlateCode = value;
					this.SendPropertyChanged("PlateCode");
					this.OnPlateCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaceToVisitID", DbType="Int")]
		public System.Nullable<int> PlaceToVisitID
		{
			get
			{
				return this._PlaceToVisitID;
			}
			set
			{
				if ((this._PlaceToVisitID != value))
				{
					this.OnPlaceToVisitIDChanging(value);
					this.SendPropertyChanging();
					this._PlaceToVisitID = value;
					this.SendPropertyChanged("PlaceToVisitID");
					this.OnPlaceToVisitIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WhatFamousID", DbType="Int")]
		public System.Nullable<int> WhatFamousID
		{
			get
			{
				return this._WhatFamousID;
			}
			set
			{
				if ((this._WhatFamousID != value))
				{
					this.OnWhatFamousIDChanging(value);
					this.SendPropertyChanging();
					this._WhatFamousID = value;
					this.SendPropertyChanged("WhatFamousID");
					this.OnWhatFamousIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PopulationID", DbType="Int")]
		public System.Nullable<int> PopulationID
		{
			get
			{
				return this._PopulationID;
			}
			set
			{
				if ((this._PopulationID != value))
				{
					if (this._Population.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPopulationIDChanging(value);
					this.SendPropertyChanging();
					this._PopulationID = value;
					this.SendPropertyChanged("PopulationID");
					this.OnPopulationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegionID", DbType="Int")]
		public System.Nullable<int> RegionID
		{
			get
			{
				return this._RegionID;
			}
			set
			{
				if ((this._RegionID != value))
				{
					this.OnRegionIDChanging(value);
					this.SendPropertyChanging();
					this._RegionID = value;
					this.SendPropertyChanged("RegionID");
					this.OnRegionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransportationServiceID", DbType="Int")]
		public System.Nullable<int> TransportationServiceID
		{
			get
			{
				return this._TransportationServiceID;
			}
			set
			{
				if ((this._TransportationServiceID != value))
				{
					this.OnTransportationServiceIDChanging(value);
					this.SendPropertyChanging();
					this._TransportationServiceID = value;
					this.SendPropertyChanged("TransportationServiceID");
					this.OnTransportationServiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartyID", DbType="Int")]
		public System.Nullable<int> PartyID
		{
			get
			{
				return this._PartyID;
			}
			set
			{
				if ((this._PartyID != value))
				{
					this.OnPartyIDChanging(value);
					this.SendPropertyChanging();
					this._PartyID = value;
					this.SendPropertyChanged("PartyID");
					this.OnPartyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Province_Town", Storage="_Towns", ThisKey="ProvinceID", OtherKey="ProvinceID")]
		public EntitySet<Town> Towns
		{
			get
			{
				return this._Towns;
			}
			set
			{
				this._Towns.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Population_Province", Storage="_Population", ThisKey="PopulationID", OtherKey="PopulationID", IsForeignKey=true)]
		public Population Population
		{
			get
			{
				return this._Population.Entity;
			}
			set
			{
				Population previousValue = this._Population.Entity;
				if (((previousValue != value) 
							|| (this._Population.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Population.Entity = null;
						previousValue.Provinces.Remove(this);
					}
					this._Population.Entity = value;
					if ((value != null))
					{
						value.Provinces.Add(this);
						this._PopulationID = value.PopulationID;
					}
					else
					{
						this._PopulationID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Population");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Towns(Town entity)
		{
			this.SendPropertyChanging();
			entity.Province = this;
		}
		
		private void detach_Towns(Town entity)
		{
			this.SendPropertyChanging();
			entity.Province = null;
		}
	}
}
#pragma warning restore 1591