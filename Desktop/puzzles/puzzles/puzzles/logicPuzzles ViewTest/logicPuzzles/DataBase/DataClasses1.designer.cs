﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.296
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace logicPuzzles.DataBase
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
	
	
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void Inserttest(test instance);
    partial void Updatetest(test instance);
    partial void Deletetest(test instance);
    partial void Inserttask(task instance);
    partial void Updatetask(task instance);
    partial void Deletetask(task instance);
    partial void Insertcomp(comp instance);
    partial void Updatecomp(comp instance);
    partial void Deletecomp(comp instance);
    partial void Insertlinks(links instance);
    partial void Updatelinks(links instance);
    partial void Deletelinks(links instance);
    partial void Insertpic(pic instance);
    partial void Updatepic(pic instance);
    partial void Deletepic(pic instance);
    #endregion
		
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
		
		public System.Data.Linq.Table<test> test
		{
			get
			{
				return this.GetTable<test>();
			}
		}
		
		public System.Data.Linq.Table<task> task
		{
			get
			{
				return this.GetTable<task>();
			}
		}
		
		public System.Data.Linq.Table<comp> comp
		{
			get
			{
				return this.GetTable<comp>();
			}
		}
		
		public System.Data.Linq.Table<links> links
		{
			get
			{
				return this.GetTable<links>();
			}
		}
		
		public System.Data.Linq.Table<pic> pic
		{
			get
			{
				return this.GetTable<pic>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class test : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _nid;
		
		private string _tname;
		
		private EntitySet<task> _task;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnidChanging(int value);
    partial void OnnidChanged();
    partial void OntnameChanging(string value);
    partial void OntnameChanged();
    #endregion
		
		public test()
		{
			this._task = new EntitySet<task>(new Action<task>(this.attach_task), new Action<task>(this.detach_task));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nid", DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true)]
		public int nid
		{
			get
			{
				return this._nid;
			}
			set
			{
				if ((this._nid != value))
				{
					this.OnnidChanging(value);
					this.SendPropertyChanging();
					this._nid = value;
					this.SendPropertyChanged("nid");
					this.OnnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tname", CanBeNull=false)]
		public string tname
		{
			get
			{
				return this._tname;
			}
			set
			{
				if ((this._tname != value))
				{
					this.OntnameChanging(value);
					this.SendPropertyChanging();
					this._tname = value;
					this.SendPropertyChanged("tname");
					this.OntnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="test_task", Storage="_task", ThisKey="nid", OtherKey="ntest")]
		public EntitySet<task> task
		{
			get
			{
				return this._task;
			}
			set
			{
				this._task.Assign(value);
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
		
		private void attach_task(task entity)
		{
			this.SendPropertyChanging();
			entity.test = this;
		}
		
		private void detach_task(task entity)
		{
			this.SendPropertyChanging();
			entity.test = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class task : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _nid;
		
		private int _ntest;
		
		private string _tname;
		
		private int _npos;
		
		private EntitySet<comp> _comp;
		
		private EntitySet<links> _links;
		
		private EntityRef<test> _test;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnidChanging(int value);
    partial void OnnidChanged();
    partial void OnntestChanging(int value);
    partial void OnntestChanged();
    partial void OntnameChanging(string value);
    partial void OntnameChanged();
    partial void OnnposChanging(int value);
    partial void OnnposChanged();
    #endregion
		
		public task()
		{
			this._comp = new EntitySet<comp>(new Action<comp>(this.attach_comp), new Action<comp>(this.detach_comp));
			this._links = new EntitySet<links>(new Action<links>(this.attach_links), new Action<links>(this.detach_links));
			this._test = default(EntityRef<test>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nid", IsPrimaryKey=true)]
		public int nid
		{
			get
			{
				return this._nid;
			}
			set
			{
				if ((this._nid != value))
				{
					this.OnnidChanging(value);
					this.SendPropertyChanging();
					this._nid = value;
					this.SendPropertyChanged("nid");
					this.OnnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ntest")]
		public int ntest
		{
			get
			{
				return this._ntest;
			}
			set
			{
				if ((this._ntest != value))
				{
					if (this._test.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnntestChanging(value);
					this.SendPropertyChanging();
					this._ntest = value;
					this.SendPropertyChanged("ntest");
					this.OnntestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tname", CanBeNull=false)]
		public string tname
		{
			get
			{
				return this._tname;
			}
			set
			{
				if ((this._tname != value))
				{
					this.OntnameChanging(value);
					this.SendPropertyChanging();
					this._tname = value;
					this.SendPropertyChanged("tname");
					this.OntnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_npos")]
		public int npos
		{
			get
			{
				return this._npos;
			}
			set
			{
				if ((this._npos != value))
				{
					this.OnnposChanging(value);
					this.SendPropertyChanging();
					this._npos = value;
					this.SendPropertyChanged("npos");
					this.OnnposChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="task_comp", Storage="_comp", ThisKey="nid", OtherKey="ntask")]
		public EntitySet<comp> comp
		{
			get
			{
				return this._comp;
			}
			set
			{
				this._comp.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="task_links", Storage="_links", ThisKey="nid", OtherKey="ntask")]
		public EntitySet<links> links
		{
			get
			{
				return this._links;
			}
			set
			{
				this._links.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="test_task", Storage="_test", ThisKey="ntest", OtherKey="nid", IsForeignKey=true)]
		public test test
		{
			get
			{
				return this._test.Entity;
			}
			set
			{
				test previousValue = this._test.Entity;
				if (((previousValue != value) 
							|| (this._test.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._test.Entity = null;
						previousValue.task.Remove(this);
					}
					this._test.Entity = value;
					if ((value != null))
					{
						value.task.Add(this);
						this._ntest = value.nid;
					}
					else
					{
						this._ntest = default(int);
					}
					this.SendPropertyChanged("test");
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
		
		private void attach_comp(comp entity)
		{
			this.SendPropertyChanging();
			entity.task = this;
		}
		
		private void detach_comp(comp entity)
		{
			this.SendPropertyChanging();
			entity.task = null;
		}
		
		private void attach_links(links entity)
		{
			this.SendPropertyChanging();
			entity.task = this;
		}
		
		private void detach_links(links entity)
		{
			this.SendPropertyChanging();
			entity.task = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class comp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ntask;
		
		private bool _bkomp;
		
		private string _tname;
		
		private string _nid;
		
		private EntityRef<task> _task;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnntaskChanging(int value);
    partial void OnntaskChanged();
    partial void OnbkompChanging(bool value);
    partial void OnbkompChanged();
    partial void OntnameChanging(string value);
    partial void OntnameChanged();
    partial void OnnidChanging(string value);
    partial void OnnidChanged();
    #endregion
		
		public comp()
		{
			this._task = default(EntityRef<task>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ntask")]
		public int ntask
		{
			get
			{
				return this._ntask;
			}
			set
			{
				if ((this._ntask != value))
				{
					if (this._task.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnntaskChanging(value);
					this.SendPropertyChanging();
					this._ntask = value;
					this.SendPropertyChanged("ntask");
					this.OnntaskChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bkomp")]
		public bool bkomp
		{
			get
			{
				return this._bkomp;
			}
			set
			{
				if ((this._bkomp != value))
				{
					this.OnbkompChanging(value);
					this.SendPropertyChanging();
					this._bkomp = value;
					this.SendPropertyChanged("bkomp");
					this.OnbkompChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tname", CanBeNull=false)]
		public string tname
		{
			get
			{
				return this._tname;
			}
			set
			{
				if ((this._tname != value))
				{
					this.OntnameChanging(value);
					this.SendPropertyChanging();
					this._tname = value;
					this.SendPropertyChanged("tname");
					this.OntnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nid", CanBeNull=false, IsPrimaryKey=true)]
		public string nid
		{
			get
			{
				return this._nid;
			}
			set
			{
				if ((this._nid != value))
				{
					this.OnnidChanging(value);
					this.SendPropertyChanging();
					this._nid = value;
					this.SendPropertyChanged("nid");
					this.OnnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="task_comp", Storage="_task", ThisKey="ntask", OtherKey="nid", IsForeignKey=true)]
		public task task
		{
			get
			{
				return this._task.Entity;
			}
			set
			{
				task previousValue = this._task.Entity;
				if (((previousValue != value) 
							|| (this._task.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._task.Entity = null;
						previousValue.comp.Remove(this);
					}
					this._task.Entity = value;
					if ((value != null))
					{
						value.comp.Add(this);
						this._ntask = value.nid;
					}
					else
					{
						this._ntask = default(int);
					}
					this.SendPropertyChanged("task");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class links : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ntask;
		
		private int _npic;
		
		private string _tname;
		
		private int _nid;
		
		private EntityRef<pic> _pic;
		
		private EntityRef<task> _task;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnntaskChanging(int value);
    partial void OnntaskChanged();
    partial void OnnpicChanging(int value);
    partial void OnnpicChanged();
    partial void OntnameChanging(string value);
    partial void OntnameChanged();
    partial void OnnidChanging(int value);
    partial void OnnidChanged();
    #endregion
		
		public links()
		{
			this._pic = default(EntityRef<pic>);
			this._task = default(EntityRef<task>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ntask")]
		public int ntask
		{
			get
			{
				return this._ntask;
			}
			set
			{
				if ((this._ntask != value))
				{
					if (this._task.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnntaskChanging(value);
					this.SendPropertyChanging();
					this._ntask = value;
					this.SendPropertyChanged("ntask");
					this.OnntaskChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_npic")]
		public int npic
		{
			get
			{
				return this._npic;
			}
			set
			{
				if ((this._npic != value))
				{
					if (this._pic.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnnpicChanging(value);
					this.SendPropertyChanging();
					this._npic = value;
					this.SendPropertyChanged("npic");
					this.OnnpicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tname", CanBeNull=false)]
		public string tname
		{
			get
			{
				return this._tname;
			}
			set
			{
				if ((this._tname != value))
				{
					this.OntnameChanging(value);
					this.SendPropertyChanging();
					this._tname = value;
					this.SendPropertyChanged("tname");
					this.OntnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nid", IsPrimaryKey=true)]
		public int nid
		{
			get
			{
				return this._nid;
			}
			set
			{
				if ((this._nid != value))
				{
					this.OnnidChanging(value);
					this.SendPropertyChanging();
					this._nid = value;
					this.SendPropertyChanged("nid");
					this.OnnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pic_links", Storage="_pic", ThisKey="npic", OtherKey="nid", IsForeignKey=true)]
		public pic pic
		{
			get
			{
				return this._pic.Entity;
			}
			set
			{
				pic previousValue = this._pic.Entity;
				if (((previousValue != value) 
							|| (this._pic.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._pic.Entity = null;
						previousValue.links.Remove(this);
					}
					this._pic.Entity = value;
					if ((value != null))
					{
						value.links.Add(this);
						this._npic = value.nid;
					}
					else
					{
						this._npic = default(int);
					}
					this.SendPropertyChanged("pic");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="task_links", Storage="_task", ThisKey="ntask", OtherKey="nid", IsForeignKey=true)]
		public task task
		{
			get
			{
				return this._task.Entity;
			}
			set
			{
				task previousValue = this._task.Entity;
				if (((previousValue != value) 
							|| (this._task.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._task.Entity = null;
						previousValue.links.Remove(this);
					}
					this._task.Entity = value;
					if ((value != null))
					{
						value.links.Add(this);
						this._ntask = value.nid;
					}
					else
					{
						this._ntask = default(int);
					}
					this.SendPropertyChanged("task");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class pic : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _nid;
		
		private byte[] _opic;
		
		private EntitySet<links> _links;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnidChanging(int value);
    partial void OnnidChanged();
    partial void OnopicChanging(byte[] value);
    partial void OnopicChanged();
    #endregion
		
		public pic()
		{
			this._links = new EntitySet<links>(new Action<links>(this.attach_links), new Action<links>(this.detach_links));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nid", IsPrimaryKey=true)]
		public int nid
		{
			get
			{
				return this._nid;
			}
			set
			{
				if ((this._nid != value))
				{
					this.OnnidChanging(value);
					this.SendPropertyChanging();
					this._nid = value;
					this.SendPropertyChanged("nid");
					this.OnnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opic", CanBeNull=false)]
		public byte[] opic
		{
			get
			{
				return this._opic;
			}
			set
			{
				if ((this._opic != value))
				{
					this.OnopicChanging(value);
					this.SendPropertyChanging();
					this._opic = value;
					this.SendPropertyChanged("opic");
					this.OnopicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pic_links", Storage="_links", ThisKey="nid", OtherKey="npic")]
		public EntitySet<links> links
		{
			get
			{
				return this._links;
			}
			set
			{
				this._links.Assign(value);
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
		
		private void attach_links(links entity)
		{
			this.SendPropertyChanging();
			entity.pic = this;
		}
		
		private void detach_links(links entity)
		{
			this.SendPropertyChanging();
			entity.pic = null;
		}
	}
}
#pragma warning restore 1591