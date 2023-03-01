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

namespace WindowsFormsApp2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Demo")]
	public partial class DemoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPhongBan(PhongBan instance);
    partial void UpdatePhongBan(PhongBan instance);
    partial void DeletePhongBan(PhongBan instance);
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    #endregion
		
		public DemoDataContext() : 
				base(global::WindowsFormsApp2.Properties.Settings.Default.DemoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DemoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DemoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DemoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DemoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PhongBan> PhongBans
		{
			get
			{
				return this.GetTable<PhongBan>();
			}
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NhanVien_Update")]
		public int NhanVien_Update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string fullName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string homeTown, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDStudent", DbType="Int")] System.Nullable<int> iDStudent)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fullName, homeTown, iDStudent);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NhanVien_Delete")]
		public int NhanVien_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDStudent", DbType="Int")] System.Nullable<int> iDStudent)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDStudent);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NhanVien_Insert")]
		public int NhanVien_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string fullName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string homeTown, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fullName, homeTown, iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NhanVien_SelectID")]
		public ISingleResult<NhanVien_SelectIDResult> NhanVien_SelectID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<NhanVien_SelectIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PhongBan_Delete")]
		public int PhongBan_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PhongBan_Insert")]
		public int PhongBan_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Department", DbType="NVarChar(50)")] string department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), department);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PhongBan_SelectAll")]
		public ISingleResult<PhongBan_SelectAllResult> PhongBan_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<PhongBan_SelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PhongBan_Update")]
		public int PhongBan_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Department", DbType="NVarChar(50)")] string department, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), department, iD);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhongBan")]
	public partial class PhongBan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Department;
		
		private EntitySet<SinhVien> _SinhViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    #endregion
		
		public PhongBan()
		{
			this._SinhViens = new EntitySet<SinhVien>(new Action<SinhVien>(this.attach_SinhViens), new Action<SinhVien>(this.detach_SinhViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="NVarChar(50)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhongBan_SinhVien", Storage="_SinhViens", ThisKey="ID", OtherKey="ID")]
		public EntitySet<SinhVien> SinhViens
		{
			get
			{
				return this._SinhViens;
			}
			set
			{
				this._SinhViens.Assign(value);
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
		
		private void attach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.PhongBan = this;
		}
		
		private void detach_SinhViens(SinhVien entity)
		{
			this.SendPropertyChanging();
			entity.PhongBan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDStudent;
		
		private string _fullName;
		
		private string _homeTown;
		
		private System.Nullable<int> _ID;
		
		private EntityRef<PhongBan> _PhongBan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDStudentChanging(int value);
    partial void OnIDStudentChanged();
    partial void OnfullNameChanging(string value);
    partial void OnfullNameChanged();
    partial void OnhomeTownChanging(string value);
    partial void OnhomeTownChanged();
    partial void OnIDChanging(System.Nullable<int> value);
    partial void OnIDChanged();
    #endregion
		
		public SinhVien()
		{
			this._PhongBan = default(EntityRef<PhongBan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDStudent", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDStudent
		{
			get
			{
				return this._IDStudent;
			}
			set
			{
				if ((this._IDStudent != value))
				{
					this.OnIDStudentChanging(value);
					this.SendPropertyChanging();
					this._IDStudent = value;
					this.SendPropertyChanged("IDStudent");
					this.OnIDStudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="NVarChar(50)")]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this.OnfullNameChanging(value);
					this.SendPropertyChanging();
					this._fullName = value;
					this.SendPropertyChanged("fullName");
					this.OnfullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_homeTown", DbType="NVarChar(50)")]
		public string homeTown
		{
			get
			{
				return this._homeTown;
			}
			set
			{
				if ((this._homeTown != value))
				{
					this.OnhomeTownChanging(value);
					this.SendPropertyChanging();
					this._homeTown = value;
					this.SendPropertyChanged("homeTown");
					this.OnhomeTownChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._PhongBan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhongBan_SinhVien", Storage="_PhongBan", ThisKey="ID", OtherKey="ID", IsForeignKey=true, DeleteRule="CASCADE")]
		public PhongBan PhongBan
		{
			get
			{
				return this._PhongBan.Entity;
			}
			set
			{
				PhongBan previousValue = this._PhongBan.Entity;
				if (((previousValue != value) 
							|| (this._PhongBan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PhongBan.Entity = null;
						previousValue.SinhViens.Remove(this);
					}
					this._PhongBan.Entity = value;
					if ((value != null))
					{
						value.SinhViens.Add(this);
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("PhongBan");
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
	
	public partial class NhanVien_SelectIDResult
	{
		
		private int _IDStudent;
		
		private string _fullName;
		
		private string _homeTown;
		
		private System.Nullable<int> _ID;
		
		public NhanVien_SelectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDStudent", DbType="Int NOT NULL")]
		public int IDStudent
		{
			get
			{
				return this._IDStudent;
			}
			set
			{
				if ((this._IDStudent != value))
				{
					this._IDStudent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="NVarChar(50)")]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this._fullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_homeTown", DbType="NVarChar(50)")]
		public string homeTown
		{
			get
			{
				return this._homeTown;
			}
			set
			{
				if ((this._homeTown != value))
				{
					this._homeTown = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
	}
	
	public partial class PhongBan_SelectAllResult
	{
		
		private int _ID;
		
		private string _Department;
		
		public PhongBan_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="NVarChar(50)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this._Department = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
