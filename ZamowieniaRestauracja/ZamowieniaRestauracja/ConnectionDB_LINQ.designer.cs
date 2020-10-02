﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZamowieniaRestauracja
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database_of_Restaurants")]
	public partial class ConnectionDB_LINQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertZamowienia(Zamowienia instance);
    partial void UpdateZamowienia(Zamowienia instance);
    partial void DeleteZamowienia(Zamowienia instance);
    partial void InsertProdukty(Produkty instance);
    partial void UpdateProdukty(Produkty instance);
    partial void DeleteProdukty(Produkty instance);
    #endregion
		
		public ConnectionDB_LINQDataContext() : 
				base(global::ZamowieniaRestauracja.Properties.Settings.Default.Database_of_RestaurantsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectionDB_LINQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectionDB_LINQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectionDB_LINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectionDB_LINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Zamowienia> Zamowienia
		{
			get
			{
				return this.GetTable<Zamowienia>();
			}
		}
		
		public System.Data.Linq.Table<Produkty> Produkty
		{
			get
			{
				return this.GetTable<Produkty>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Zamowienia")]
	public partial class Zamowienia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _zm_id;
		
		private int _zm_nr_zamowienia;
		
		private System.DateTime _zm_data_zamowienia;
		
		private float _zm_koszt;
		
		private string _zm_email;
		
		private EntitySet<Produkty> _Produkty;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onzm_idChanging(int value);
    partial void Onzm_idChanged();
    partial void Onzm_nr_zamowieniaChanging(int value);
    partial void Onzm_nr_zamowieniaChanged();
    partial void Onzm_data_zamowieniaChanging(System.DateTime value);
    partial void Onzm_data_zamowieniaChanged();
    partial void Onzm_kosztChanging(float value);
    partial void Onzm_kosztChanged();
    partial void Onzm_emailChanging(string value);
    partial void Onzm_emailChanged();
    #endregion
		
		public Zamowienia()
		{
			this._Produkty = new EntitySet<Produkty>(new Action<Produkty>(this.attach_Produkty), new Action<Produkty>(this.detach_Produkty));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zm_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int zm_id
		{
			get
			{
				return this._zm_id;
			}
			set
			{
				if ((this._zm_id != value))
				{
					this.Onzm_idChanging(value);
					this.SendPropertyChanging();
					this._zm_id = value;
					this.SendPropertyChanged("zm_id");
					this.Onzm_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zm_nr_zamowienia", DbType="Int NOT NULL")]
		public int zm_nr_zamowienia
		{
			get
			{
				return this._zm_nr_zamowienia;
			}
			set
			{
				if ((this._zm_nr_zamowienia != value))
				{
					this.Onzm_nr_zamowieniaChanging(value);
					this.SendPropertyChanging();
					this._zm_nr_zamowienia = value;
					this.SendPropertyChanged("zm_nr_zamowienia");
					this.Onzm_nr_zamowieniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zm_data_zamowienia", DbType="DateTime NOT NULL")]
		public System.DateTime zm_data_zamowienia
		{
			get
			{
				return this._zm_data_zamowienia;
			}
			set
			{
				if ((this._zm_data_zamowienia != value))
				{
					this.Onzm_data_zamowieniaChanging(value);
					this.SendPropertyChanging();
					this._zm_data_zamowienia = value;
					this.SendPropertyChanged("zm_data_zamowienia");
					this.Onzm_data_zamowieniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zm_koszt", DbType="Real NOT NULL")]
		public float zm_koszt
		{
			get
			{
				return this._zm_koszt;
			}
			set
			{
				if ((this._zm_koszt != value))
				{
					this.Onzm_kosztChanging(value);
					this.SendPropertyChanging();
					this._zm_koszt = value;
					this.SendPropertyChanged("zm_koszt");
					this.Onzm_kosztChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zm_email", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string zm_email
		{
			get
			{
				return this._zm_email;
			}
			set
			{
				if ((this._zm_email != value))
				{
					this.Onzm_emailChanging(value);
					this.SendPropertyChanging();
					this._zm_email = value;
					this.SendPropertyChanged("zm_email");
					this.Onzm_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Zamowienia_Produkty", Storage="_Produkty", ThisKey="zm_id", OtherKey="zm_id")]
		public EntitySet<Produkty> Produkty
		{
			get
			{
				return this._Produkty;
			}
			set
			{
				this._Produkty.Assign(value);
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
		
		private void attach_Produkty(Produkty entity)
		{
			this.SendPropertyChanging();
			entity.Zamowienia = this;
		}
		
		private void detach_Produkty(Produkty entity)
		{
			this.SendPropertyChanging();
			entity.Zamowienia = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Produkty")]
	public partial class Produkty : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pr_id;
		
		private string _pr_nazwa;
		
		private float _pr_cena;
		
		private int _zm_id;
		
		private EntityRef<Zamowienia> _Zamowienia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpr_idChanging(int value);
    partial void Onpr_idChanged();
    partial void Onpr_nazwaChanging(string value);
    partial void Onpr_nazwaChanged();
    partial void Onpr_cenaChanging(float value);
    partial void Onpr_cenaChanged();
    partial void Onzm_idChanging(int value);
    partial void Onzm_idChanged();
    #endregion
		
		public Produkty()
		{
			this._Zamowienia = default(EntityRef<Zamowienia>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pr_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pr_id
		{
			get
			{
				return this._pr_id;
			}
			set
			{
				if ((this._pr_id != value))
				{
					this.Onpr_idChanging(value);
					this.SendPropertyChanging();
					this._pr_id = value;
					this.SendPropertyChanged("pr_id");
					this.Onpr_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pr_nazwa", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string pr_nazwa
		{
			get
			{
				return this._pr_nazwa;
			}
			set
			{
				if ((this._pr_nazwa != value))
				{
					this.Onpr_nazwaChanging(value);
					this.SendPropertyChanging();
					this._pr_nazwa = value;
					this.SendPropertyChanged("pr_nazwa");
					this.Onpr_nazwaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pr_cena", DbType="Real NOT NULL")]
		public float pr_cena
		{
			get
			{
				return this._pr_cena;
			}
			set
			{
				if ((this._pr_cena != value))
				{
					this.Onpr_cenaChanging(value);
					this.SendPropertyChanging();
					this._pr_cena = value;
					this.SendPropertyChanged("pr_cena");
					this.Onpr_cenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zm_id", DbType="Int NOT NULL")]
		public int zm_id
		{
			get
			{
				return this._zm_id;
			}
			set
			{
				if ((this._zm_id != value))
				{
					if (this._Zamowienia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onzm_idChanging(value);
					this.SendPropertyChanging();
					this._zm_id = value;
					this.SendPropertyChanged("zm_id");
					this.Onzm_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Zamowienia_Produkty", Storage="_Zamowienia", ThisKey="zm_id", OtherKey="zm_id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Zamowienia Zamowienia
		{
			get
			{
				return this._Zamowienia.Entity;
			}
			set
			{
				Zamowienia previousValue = this._Zamowienia.Entity;
				if (((previousValue != value) 
							|| (this._Zamowienia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Zamowienia.Entity = null;
						previousValue.Produkty.Remove(this);
					}
					this._Zamowienia.Entity = value;
					if ((value != null))
					{
						value.Produkty.Add(this);
						this._zm_id = value.zm_id;
					}
					else
					{
						this._zm_id = default(int);
					}
					this.SendPropertyChanged("Zamowienia");
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
}
#pragma warning restore 1591