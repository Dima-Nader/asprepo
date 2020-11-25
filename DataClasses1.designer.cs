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

namespace bookdb
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="book")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertauthor(author instance);
    partial void Updateauthor(author instance);
    partial void Deleteauthor(author instance);
    partial void Insertauthorisbn(authorisbn instance);
    partial void Updateauthorisbn(authorisbn instance);
    partial void Deleteauthorisbn(authorisbn instance);
    partial void Inserttitle(title instance);
    partial void Updatetitle(title instance);
    partial void Deletetitle(title instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::bookdb.Properties.Settings.Default.bookConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<author> authors
		{
			get
			{
				return this.GetTable<author>();
			}
		}
		
		public System.Data.Linq.Table<authorisbn> authorisbns
		{
			get
			{
				return this.GetTable<authorisbn>();
			}
		}
		
		public System.Data.Linq.Table<title> titles
		{
			get
			{
				return this.GetTable<title>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.author")]
	public partial class author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _authorid;
		
		private string _fname;
		
		private string _lname;
		
		private EntitySet<authorisbn> _authorisbns;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnauthoridChanging(int value);
    partial void OnauthoridChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    #endregion
		
		public author()
		{
			this._authorisbns = new EntitySet<authorisbn>(new Action<authorisbn>(this.attach_authorisbns), new Action<authorisbn>(this.detach_authorisbns));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int authorid
		{
			get
			{
				return this._authorid;
			}
			set
			{
				if ((this._authorid != value))
				{
					this.OnauthoridChanging(value);
					this.SendPropertyChanging();
					this._authorid = value;
					this.SendPropertyChanged("authorid");
					this.OnauthoridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="author_authorisbn", Storage="_authorisbns", ThisKey="authorid", OtherKey="authorid")]
		public EntitySet<authorisbn> authorisbns
		{
			get
			{
				return this._authorisbns;
			}
			set
			{
				this._authorisbns.Assign(value);
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
		
		private void attach_authorisbns(authorisbn entity)
		{
			this.SendPropertyChanging();
			entity.author = this;
		}
		
		private void detach_authorisbns(authorisbn entity)
		{
			this.SendPropertyChanging();
			entity.author = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.authorisbn")]
	public partial class authorisbn : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _authorid;
		
		private int _isbn;
		
		private EntityRef<author> _author;
		
		private EntityRef<title> _title;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnauthoridChanging(int value);
    partial void OnauthoridChanged();
    partial void OnisbnChanging(int value);
    partial void OnisbnChanged();
    #endregion
		
		public authorisbn()
		{
			this._author = default(EntityRef<author>);
			this._title = default(EntityRef<title>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int authorid
		{
			get
			{
				return this._authorid;
			}
			set
			{
				if ((this._authorid != value))
				{
					if (this._author.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnauthoridChanging(value);
					this.SendPropertyChanging();
					this._authorid = value;
					this.SendPropertyChanged("authorid");
					this.OnauthoridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isbn", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int isbn
		{
			get
			{
				return this._isbn;
			}
			set
			{
				if ((this._isbn != value))
				{
					if (this._title.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnisbnChanging(value);
					this.SendPropertyChanging();
					this._isbn = value;
					this.SendPropertyChanged("isbn");
					this.OnisbnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="author_authorisbn", Storage="_author", ThisKey="authorid", OtherKey="authorid", IsForeignKey=true)]
		public author author
		{
			get
			{
				return this._author.Entity;
			}
			set
			{
				author previousValue = this._author.Entity;
				if (((previousValue != value) 
							|| (this._author.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._author.Entity = null;
						previousValue.authorisbns.Remove(this);
					}
					this._author.Entity = value;
					if ((value != null))
					{
						value.authorisbns.Add(this);
						this._authorid = value.authorid;
					}
					else
					{
						this._authorid = default(int);
					}
					this.SendPropertyChanged("author");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="title_authorisbn", Storage="_title", ThisKey="isbn", OtherKey="isbn", IsForeignKey=true)]
		public title title
		{
			get
			{
				return this._title.Entity;
			}
			set
			{
				title previousValue = this._title.Entity;
				if (((previousValue != value) 
							|| (this._title.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._title.Entity = null;
						previousValue.authorisbns.Remove(this);
					}
					this._title.Entity = value;
					if ((value != null))
					{
						value.authorisbns.Add(this);
						this._isbn = value.isbn;
					}
					else
					{
						this._isbn = default(int);
					}
					this.SendPropertyChanged("title");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.titles")]
	public partial class title : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _isbn;
		
		private string _title1;
		
		private System.Nullable<int> _edition_num;
		
		private System.Nullable<int> _copyright;
		
		private EntitySet<authorisbn> _authorisbns;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnisbnChanging(int value);
    partial void OnisbnChanged();
    partial void Ontitle1Changing(string value);
    partial void Ontitle1Changed();
    partial void Onedition_numChanging(System.Nullable<int> value);
    partial void Onedition_numChanged();
    partial void OncopyrightChanging(System.Nullable<int> value);
    partial void OncopyrightChanged();
    #endregion
		
		public title()
		{
			this._authorisbns = new EntitySet<authorisbn>(new Action<authorisbn>(this.attach_authorisbns), new Action<authorisbn>(this.detach_authorisbns));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isbn", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int isbn
		{
			get
			{
				return this._isbn;
			}
			set
			{
				if ((this._isbn != value))
				{
					this.OnisbnChanging(value);
					this.SendPropertyChanging();
					this._isbn = value;
					this.SendPropertyChanged("isbn");
					this.OnisbnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="title", Storage="_title1", DbType="VarChar(50)")]
		public string title1
		{
			get
			{
				return this._title1;
			}
			set
			{
				if ((this._title1 != value))
				{
					this.Ontitle1Changing(value);
					this.SendPropertyChanging();
					this._title1 = value;
					this.SendPropertyChanged("title1");
					this.Ontitle1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_edition_num", DbType="Int")]
		public System.Nullable<int> edition_num
		{
			get
			{
				return this._edition_num;
			}
			set
			{
				if ((this._edition_num != value))
				{
					this.Onedition_numChanging(value);
					this.SendPropertyChanging();
					this._edition_num = value;
					this.SendPropertyChanged("edition_num");
					this.Onedition_numChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_copyright", DbType="Int")]
		public System.Nullable<int> copyright
		{
			get
			{
				return this._copyright;
			}
			set
			{
				if ((this._copyright != value))
				{
					this.OncopyrightChanging(value);
					this.SendPropertyChanging();
					this._copyright = value;
					this.SendPropertyChanged("copyright");
					this.OncopyrightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="title_authorisbn", Storage="_authorisbns", ThisKey="isbn", OtherKey="isbn")]
		public EntitySet<authorisbn> authorisbns
		{
			get
			{
				return this._authorisbns;
			}
			set
			{
				this._authorisbns.Assign(value);
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
		
		private void attach_authorisbns(authorisbn entity)
		{
			this.SendPropertyChanging();
			entity.title = this;
		}
		
		private void detach_authorisbns(authorisbn entity)
		{
			this.SendPropertyChanging();
			entity.title = null;
		}
	}
}
#pragma warning restore 1591