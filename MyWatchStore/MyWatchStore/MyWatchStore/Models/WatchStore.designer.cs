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

namespace MyWatchStore.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WATCHDB")]
	public partial class WatchStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertADMIN(ADMIN instance);
    partial void UpdateADMIN(ADMIN instance);
    partial void DeleteADMIN(ADMIN instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertCHITIETDONDATHANG(CHITIETDONDATHANG instance);
    partial void UpdateCHITIETDONDATHANG(CHITIETDONDATHANG instance);
    partial void DeleteCHITIETDONDATHANG(CHITIETDONDATHANG instance);
    partial void InsertDONDATHANG(DONDATHANG instance);
    partial void UpdateDONDATHANG(DONDATHANG instance);
    partial void DeleteDONDATHANG(DONDATHANG instance);
    partial void InsertDONGHO(DONGHO instance);
    partial void UpdateDONGHO(DONGHO instance);
    partial void DeleteDONGHO(DONGHO instance);
    partial void InsertHANG(HANG instance);
    partial void UpdateHANG(HANG instance);
    partial void DeleteHANG(HANG instance);
    #endregion
		
		public WatchStoreDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WATCHDBConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WatchStoreDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WatchStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WatchStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WatchStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ADMIN> ADMINs
		{
			get
			{
				return this.GetTable<ADMIN>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<CHITIETDONDATHANG> CHITIETDONDATHANGs
		{
			get
			{
				return this.GetTable<CHITIETDONDATHANG>();
			}
		}
		
		public System.Data.Linq.Table<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this.GetTable<DONDATHANG>();
			}
		}
		
		public System.Data.Linq.Table<DONGHO> DONGHOs
		{
			get
			{
				return this.GetTable<DONGHO>();
			}
		}
		
		public System.Data.Linq.Table<HANG> HANGs
		{
			get
			{
				return this.GetTable<HANG>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ADMIN")]
	public partial class ADMIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public ADMIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="Char(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="Char(16) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenKH;
		
		private string _DiaChi;
		
		private string _SoDT;
		
		private string _Email;
		
		private string _TenDN;
		
		private string _MatKhau;
		
		private EntitySet<DONDATHANG> _DONDATHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSoDTChanging(string value);
    partial void OnSoDTChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnTenDNChanging(string value);
    partial void OnTenDNChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._DONDATHANGs = new EntitySet<DONDATHANG>(new Action<DONDATHANG>(this.attach_DONDATHANGs), new Action<DONDATHANG>(this.detach_DONDATHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDT", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string SoDT
		{
			get
			{
				return this._SoDT;
			}
			set
			{
				if ((this._SoDT != value))
				{
					this.OnSoDTChanging(value);
					this.SendPropertyChanging();
					this._SoDT = value;
					this.SendPropertyChanged("SoDT");
					this.OnSoDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDN", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string TenDN
		{
			get
			{
				return this._TenDN;
			}
			set
			{
				if ((this._TenDN != value))
				{
					this.OnTenDNChanging(value);
					this.SendPropertyChanging();
					this._TenDN = value;
					this.SendPropertyChanged("TenDN");
					this.OnTenDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NChar(16) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_DONDATHANGs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this._DONDATHANGs;
			}
			set
			{
				this._DONDATHANGs.Assign(value);
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
		
		private void attach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETDONDATHANG")]
	public partial class CHITIETDONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDatHang;
		
		private int _MaSanPham;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<int> _ThanhTien;
		
		private EntityRef<DONDATHANG> _DONDATHANG;
		
		private EntityRef<DONGHO> _DONGHO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDatHangChanging(int value);
    partial void OnMaDatHangChanged();
    partial void OnMaSanPhamChanging(int value);
    partial void OnMaSanPhamChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnThanhTienChanging(System.Nullable<int> value);
    partial void OnThanhTienChanged();
    #endregion
		
		public CHITIETDONDATHANG()
		{
			this._DONDATHANG = default(EntityRef<DONDATHANG>);
			this._DONGHO = default(EntityRef<DONGHO>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDatHang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDatHang
		{
			get
			{
				return this._MaDatHang;
			}
			set
			{
				if ((this._MaDatHang != value))
				{
					if (this._DONDATHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDatHangChanging(value);
					this.SendPropertyChanging();
					this._MaDatHang = value;
					this.SendPropertyChanged("MaDatHang");
					this.OnMaDatHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					if (this._DONGHO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Int")]
		public System.Nullable<int> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CHITIETDONDATHANG", Storage="_DONDATHANG", ThisKey="MaDatHang", OtherKey="MaDatHang", IsForeignKey=true)]
		public DONDATHANG DONDATHANG
		{
			get
			{
				return this._DONDATHANG.Entity;
			}
			set
			{
				DONDATHANG previousValue = this._DONDATHANG.Entity;
				if (((previousValue != value) 
							|| (this._DONDATHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONDATHANG.Entity = null;
						previousValue.CHITIETDONDATHANGs.Remove(this);
					}
					this._DONDATHANG.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONDATHANGs.Add(this);
						this._MaDatHang = value.MaDatHang;
					}
					else
					{
						this._MaDatHang = default(int);
					}
					this.SendPropertyChanged("DONDATHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONGHO_CHITIETDONDATHANG", Storage="_DONGHO", ThisKey="MaSanPham", OtherKey="MaDH", IsForeignKey=true)]
		public DONGHO DONGHO
		{
			get
			{
				return this._DONGHO.Entity;
			}
			set
			{
				DONGHO previousValue = this._DONGHO.Entity;
				if (((previousValue != value) 
							|| (this._DONGHO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONGHO.Entity = null;
						previousValue.CHITIETDONDATHANGs.Remove(this);
					}
					this._DONGHO.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONDATHANGs.Add(this);
						this._MaSanPham = value.MaDH;
					}
					else
					{
						this._MaSanPham = default(int);
					}
					this.SendPropertyChanged("DONGHO");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONDATHANG")]
	public partial class DONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDatHang;
		
		private System.Nullable<bool> _TinhTrangThanhToan;
		
		private System.Nullable<bool> _TinhTrangGiao;
		
		private System.Nullable<System.DateTime> _NgayDat;
		
		private System.Nullable<System.DateTime> _NgayGiao;
		
		private int _MaKH;
		
		private EntitySet<CHITIETDONDATHANG> _CHITIETDONDATHANGs;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDatHangChanging(int value);
    partial void OnMaDatHangChanged();
    partial void OnTinhTrangThanhToanChanging(System.Nullable<bool> value);
    partial void OnTinhTrangThanhToanChanged();
    partial void OnTinhTrangGiaoChanging(System.Nullable<bool> value);
    partial void OnTinhTrangGiaoChanged();
    partial void OnNgayDatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDatChanged();
    partial void OnNgayGiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayGiaoChanged();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    #endregion
		
		public DONDATHANG()
		{
			this._CHITIETDONDATHANGs = new EntitySet<CHITIETDONDATHANG>(new Action<CHITIETDONDATHANG>(this.attach_CHITIETDONDATHANGs), new Action<CHITIETDONDATHANG>(this.detach_CHITIETDONDATHANGs));
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDatHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDatHang
		{
			get
			{
				return this._MaDatHang;
			}
			set
			{
				if ((this._MaDatHang != value))
				{
					this.OnMaDatHangChanging(value);
					this.SendPropertyChanging();
					this._MaDatHang = value;
					this.SendPropertyChanged("MaDatHang");
					this.OnMaDatHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrangThanhToan", DbType="Bit")]
		public System.Nullable<bool> TinhTrangThanhToan
		{
			get
			{
				return this._TinhTrangThanhToan;
			}
			set
			{
				if ((this._TinhTrangThanhToan != value))
				{
					this.OnTinhTrangThanhToanChanging(value);
					this.SendPropertyChanging();
					this._TinhTrangThanhToan = value;
					this.SendPropertyChanged("TinhTrangThanhToan");
					this.OnTinhTrangThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrangGiao", DbType="Bit")]
		public System.Nullable<bool> TinhTrangGiao
		{
			get
			{
				return this._TinhTrangGiao;
			}
			set
			{
				if ((this._TinhTrangGiao != value))
				{
					this.OnTinhTrangGiaoChanging(value);
					this.SendPropertyChanging();
					this._TinhTrangGiao = value;
					this.SendPropertyChanged("TinhTrangGiao");
					this.OnTinhTrangGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="DateTime2")]
		public System.Nullable<System.DateTime> NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGiao", DbType="DateTime2")]
		public System.Nullable<System.DateTime> NgayGiao
		{
			get
			{
				return this._NgayGiao;
			}
			set
			{
				if ((this._NgayGiao != value))
				{
					this.OnNgayGiaoChanging(value);
					this.SendPropertyChanging();
					this._NgayGiao = value;
					this.SendPropertyChanged("NgayGiao");
					this.OnNgayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int NOT NULL")]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CHITIETDONDATHANG", Storage="_CHITIETDONDATHANGs", ThisKey="MaDatHang", OtherKey="MaDatHang")]
		public EntitySet<CHITIETDONDATHANG> CHITIETDONDATHANGs
		{
			get
			{
				return this._CHITIETDONDATHANGs;
			}
			set
			{
				this._CHITIETDONDATHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_KHACHHANG", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.DONDATHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONDATHANGs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(int);
					}
					this.SendPropertyChanged("KHACHHANG");
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
		
		private void attach_CHITIETDONDATHANGs(CHITIETDONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = this;
		}
		
		private void detach_CHITIETDONDATHANGs(CHITIETDONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONGHO")]
	public partial class DONGHO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDH;
		
		private string _TenDH;
		
		private string _XuatSu;
		
		private System.Nullable<int> _Gia;
		
		private string _MaHang;
		
		private string _Image;
		
		private EntitySet<CHITIETDONDATHANG> _CHITIETDONDATHANGs;
		
		private EntityRef<HANG> _HANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDHChanging(int value);
    partial void OnMaDHChanged();
    partial void OnTenDHChanging(string value);
    partial void OnTenDHChanged();
    partial void OnXuatSuChanging(string value);
    partial void OnXuatSuChanged();
    partial void OnGiaChanging(System.Nullable<int> value);
    partial void OnGiaChanged();
    partial void OnMaHangChanging(string value);
    partial void OnMaHangChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    #endregion
		
		public DONGHO()
		{
			this._CHITIETDONDATHANGs = new EntitySet<CHITIETDONDATHANG>(new Action<CHITIETDONDATHANG>(this.attach_CHITIETDONDATHANGs), new Action<CHITIETDONDATHANG>(this.detach_CHITIETDONDATHANGs));
			this._HANG = default(EntityRef<HANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDH", DbType="NVarChar(50)")]
		public string TenDH
		{
			get
			{
				return this._TenDH;
			}
			set
			{
				if ((this._TenDH != value))
				{
					this.OnTenDHChanging(value);
					this.SendPropertyChanging();
					this._TenDH = value;
					this.SendPropertyChanged("TenDH");
					this.OnTenDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XuatSu", DbType="NVarChar(15)")]
		public string XuatSu
		{
			get
			{
				return this._XuatSu;
			}
			set
			{
				if ((this._XuatSu != value))
				{
					this.OnXuatSuChanging(value);
					this.SendPropertyChanging();
					this._XuatSu = value;
					this.SendPropertyChanged("XuatSu");
					this.OnXuatSuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Int")]
		public System.Nullable<int> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHang", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string MaHang
		{
			get
			{
				return this._MaHang;
			}
			set
			{
				if ((this._MaHang != value))
				{
					if (this._HANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHangChanging(value);
					this.SendPropertyChanging();
					this._MaHang = value;
					this.SendPropertyChanged("MaHang");
					this.OnMaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(50)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONGHO_CHITIETDONDATHANG", Storage="_CHITIETDONDATHANGs", ThisKey="MaDH", OtherKey="MaSanPham")]
		public EntitySet<CHITIETDONDATHANG> CHITIETDONDATHANGs
		{
			get
			{
				return this._CHITIETDONDATHANGs;
			}
			set
			{
				this._CHITIETDONDATHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HANG_DONGHO", Storage="_HANG", ThisKey="MaHang", OtherKey="MaHang", IsForeignKey=true)]
		public HANG HANG
		{
			get
			{
				return this._HANG.Entity;
			}
			set
			{
				HANG previousValue = this._HANG.Entity;
				if (((previousValue != value) 
							|| (this._HANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HANG.Entity = null;
						previousValue.DONGHOs.Remove(this);
					}
					this._HANG.Entity = value;
					if ((value != null))
					{
						value.DONGHOs.Add(this);
						this._MaHang = value.MaHang;
					}
					else
					{
						this._MaHang = default(string);
					}
					this.SendPropertyChanged("HANG");
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
		
		private void attach_CHITIETDONDATHANGs(CHITIETDONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONGHO = this;
		}
		
		private void detach_CHITIETDONDATHANGs(CHITIETDONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONGHO = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HANG")]
	public partial class HANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHang;
		
		private string _TenHang;
		
		private string _Detail;
		
		private EntitySet<DONGHO> _DONGHOs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHangChanging(string value);
    partial void OnMaHangChanged();
    partial void OnTenHangChanging(string value);
    partial void OnTenHangChanged();
    partial void OnDetailChanging(string value);
    partial void OnDetailChanged();
    #endregion
		
		public HANG()
		{
			this._DONGHOs = new EntitySet<DONGHO>(new Action<DONGHO>(this.attach_DONGHOs), new Action<DONGHO>(this.detach_DONGHOs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHang", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHang
		{
			get
			{
				return this._MaHang;
			}
			set
			{
				if ((this._MaHang != value))
				{
					this.OnMaHangChanging(value);
					this.SendPropertyChanging();
					this._MaHang = value;
					this.SendPropertyChanged("MaHang");
					this.OnMaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHang", DbType="NVarChar(20)")]
		public string TenHang
		{
			get
			{
				return this._TenHang;
			}
			set
			{
				if ((this._TenHang != value))
				{
					this.OnTenHangChanging(value);
					this.SendPropertyChanging();
					this._TenHang = value;
					this.SendPropertyChanged("TenHang");
					this.OnTenHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Detail", DbType="NVarChar(MAX)")]
		public string Detail
		{
			get
			{
				return this._Detail;
			}
			set
			{
				if ((this._Detail != value))
				{
					this.OnDetailChanging(value);
					this.SendPropertyChanging();
					this._Detail = value;
					this.SendPropertyChanged("Detail");
					this.OnDetailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HANG_DONGHO", Storage="_DONGHOs", ThisKey="MaHang", OtherKey="MaHang")]
		public EntitySet<DONGHO> DONGHOs
		{
			get
			{
				return this._DONGHOs;
			}
			set
			{
				this._DONGHOs.Assign(value);
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
		
		private void attach_DONGHOs(DONGHO entity)
		{
			this.SendPropertyChanging();
			entity.HANG = this;
		}
		
		private void detach_DONGHOs(DONGHO entity)
		{
			this.SendPropertyChanging();
			entity.HANG = null;
		}
	}
}
#pragma warning restore 1591
