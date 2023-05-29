﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosLinqEscolar.Modelo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="escolaruv")]
	public partial class DataClassesEscolarUVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertalumno(alumno instance);
    partial void Updatealumno(alumno instance);
    partial void Deletealumno(alumno instance);
    partial void Insertcarrera(carrera instance);
    partial void Updatecarrera(carrera instance);
    partial void Deletecarrera(carrera instance);
    partial void Insertfacultad(facultad instance);
    partial void Updatefacultad(facultad instance);
    partial void Deletefacultad(facultad instance);
    partial void Insertusuario(usuario instance);
    partial void Updateusuario(usuario instance);
    partial void Deleteusuario(usuario instance);
    #endregion
		
		public DataClassesEscolarUVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEscolarUVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEscolarUVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesEscolarUVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<alumno> alumno
		{
			get
			{
				return this.GetTable<alumno>();
			}
		}
		
		public System.Data.Linq.Table<carrera> carrera
		{
			get
			{
				return this.GetTable<carrera>();
			}
		}
		
		public System.Data.Linq.Table<facultad> facultad
		{
			get
			{
				return this.GetTable<facultad>();
			}
		}
		
		public System.Data.Linq.Table<usuario> usuario
		{
			get
			{
				return this.GetTable<usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.alumno")]
	public partial class alumno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAlumno;
		
		private string _nombre;
		
		private string _apellidoPaterno;
		
		private string _apellidoMaternos;
		
		private string _matricula;
		
		private string _correo;
		
		private System.Nullable<System.DateTime> _fechaNacimiento;
		
		private System.Data.Linq.Binary _foto;
		
		private System.Nullable<int> _idCarrera;
		
		private EntityRef<carrera> _carrera;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAlumnoChanging(int value);
    partial void OnidAlumnoChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoPaternoChanging(string value);
    partial void OnapellidoPaternoChanged();
    partial void OnapellidoMaternosChanging(string value);
    partial void OnapellidoMaternosChanged();
    partial void OnmatriculaChanging(string value);
    partial void OnmatriculaChanged();
    partial void OncorreoChanging(string value);
    partial void OncorreoChanged();
    partial void OnfechaNacimientoChanging(System.Nullable<System.DateTime> value);
    partial void OnfechaNacimientoChanged();
    partial void OnfotoChanging(System.Data.Linq.Binary value);
    partial void OnfotoChanged();
    partial void OnidCarreraChanging(System.Nullable<int> value);
    partial void OnidCarreraChanged();
    #endregion
		
		public alumno()
		{
			this._carrera = default(EntityRef<carrera>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAlumno", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idAlumno
		{
			get
			{
				return this._idAlumno;
			}
			set
			{
				if ((this._idAlumno != value))
				{
					this.OnidAlumnoChanging(value);
					this.SendPropertyChanging();
					this._idAlumno = value;
					this.SendPropertyChanged("idAlumno");
					this.OnidAlumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(100)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoPaterno", DbType="VarChar(255)")]
		public string apellidoPaterno
		{
			get
			{
				return this._apellidoPaterno;
			}
			set
			{
				if ((this._apellidoPaterno != value))
				{
					this.OnapellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoPaterno = value;
					this.SendPropertyChanged("apellidoPaterno");
					this.OnapellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoMaternos", DbType="VarChar(255)")]
		public string apellidoMaternos
		{
			get
			{
				return this._apellidoMaternos;
			}
			set
			{
				if ((this._apellidoMaternos != value))
				{
					this.OnapellidoMaternosChanging(value);
					this.SendPropertyChanging();
					this._apellidoMaternos = value;
					this.SendPropertyChanged("apellidoMaternos");
					this.OnapellidoMaternosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matricula", DbType="VarChar(25)")]
		public string matricula
		{
			get
			{
				return this._matricula;
			}
			set
			{
				if ((this._matricula != value))
				{
					this.OnmatriculaChanging(value);
					this.SendPropertyChanging();
					this._matricula = value;
					this.SendPropertyChanged("matricula");
					this.OnmatriculaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo", DbType="NChar(25)")]
		public string correo
		{
			get
			{
				return this._correo;
			}
			set
			{
				if ((this._correo != value))
				{
					this.OncorreoChanging(value);
					this.SendPropertyChanging();
					this._correo = value;
					this.SendPropertyChanged("correo");
					this.OncorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaNacimiento", DbType="Date")]
		public System.Nullable<System.DateTime> fechaNacimiento
		{
			get
			{
				return this._fechaNacimiento;
			}
			set
			{
				if ((this._fechaNacimiento != value))
				{
					this.OnfechaNacimientoChanging(value);
					this.SendPropertyChanging();
					this._fechaNacimiento = value;
					this.SendPropertyChanged("fechaNacimiento");
					this.OnfechaNacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foto", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary foto
		{
			get
			{
				return this._foto;
			}
			set
			{
				if ((this._foto != value))
				{
					this.OnfotoChanging(value);
					this.SendPropertyChanging();
					this._foto = value;
					this.SendPropertyChanged("foto");
					this.OnfotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCarrera", DbType="Int")]
		public System.Nullable<int> idCarrera
		{
			get
			{
				return this._idCarrera;
			}
			set
			{
				if ((this._idCarrera != value))
				{
					if (this._carrera.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCarreraChanging(value);
					this.SendPropertyChanging();
					this._idCarrera = value;
					this.SendPropertyChanged("idCarrera");
					this.OnidCarreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="carrera_alumno", Storage="_carrera", ThisKey="idCarrera", OtherKey="idCarrera", IsForeignKey=true)]
		public carrera carrera
		{
			get
			{
				return this._carrera.Entity;
			}
			set
			{
				carrera previousValue = this._carrera.Entity;
				if (((previousValue != value) 
							|| (this._carrera.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._carrera.Entity = null;
						previousValue.alumno.Remove(this);
					}
					this._carrera.Entity = value;
					if ((value != null))
					{
						value.alumno.Add(this);
						this._idCarrera = value.idCarrera;
					}
					else
					{
						this._idCarrera = default(Nullable<int>);
					}
					this.SendPropertyChanged("carrera");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.carrera")]
	public partial class carrera : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCarrera;
		
		private string _nombre;
		
		private string _codigo;
		
		private System.Nullable<int> _idFacultad;
		
		private EntitySet<alumno> _alumno;
		
		private EntityRef<facultad> _facultad;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCarreraChanging(int value);
    partial void OnidCarreraChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OncodigoChanging(string value);
    partial void OncodigoChanged();
    partial void OnidFacultadChanging(System.Nullable<int> value);
    partial void OnidFacultadChanged();
    #endregion
		
		public carrera()
		{
			this._alumno = new EntitySet<alumno>(new Action<alumno>(this.attach_alumno), new Action<alumno>(this.detach_alumno));
			this._facultad = default(EntityRef<facultad>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCarrera", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idCarrera
		{
			get
			{
				return this._idCarrera;
			}
			set
			{
				if ((this._idCarrera != value))
				{
					this.OnidCarreraChanging(value);
					this.SendPropertyChanging();
					this._idCarrera = value;
					this.SendPropertyChanged("idCarrera");
					this.OnidCarreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(100)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="VarChar(10)")]
		public string codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFacultad", DbType="Int")]
		public System.Nullable<int> idFacultad
		{
			get
			{
				return this._idFacultad;
			}
			set
			{
				if ((this._idFacultad != value))
				{
					if (this._facultad.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidFacultadChanging(value);
					this.SendPropertyChanging();
					this._idFacultad = value;
					this.SendPropertyChanged("idFacultad");
					this.OnidFacultadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="carrera_alumno", Storage="_alumno", ThisKey="idCarrera", OtherKey="idCarrera")]
		public EntitySet<alumno> alumno
		{
			get
			{
				return this._alumno;
			}
			set
			{
				this._alumno.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="facultad_carrera", Storage="_facultad", ThisKey="idFacultad", OtherKey="idFacultad", IsForeignKey=true)]
		public facultad facultad
		{
			get
			{
				return this._facultad.Entity;
			}
			set
			{
				facultad previousValue = this._facultad.Entity;
				if (((previousValue != value) 
							|| (this._facultad.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._facultad.Entity = null;
						previousValue.carrera.Remove(this);
					}
					this._facultad.Entity = value;
					if ((value != null))
					{
						value.carrera.Add(this);
						this._idFacultad = value.idFacultad;
					}
					else
					{
						this._idFacultad = default(Nullable<int>);
					}
					this.SendPropertyChanged("facultad");
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
		
		private void attach_alumno(alumno entity)
		{
			this.SendPropertyChanging();
			entity.carrera = this;
		}
		
		private void detach_alumno(alumno entity)
		{
			this.SendPropertyChanging();
			entity.carrera = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.facultad")]
	public partial class facultad : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idFacultad;
		
		private string _nombre;
		
		private EntitySet<carrera> _carrera;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidFacultadChanging(int value);
    partial void OnidFacultadChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    #endregion
		
		public facultad()
		{
			this._carrera = new EntitySet<carrera>(new Action<carrera>(this.attach_carrera), new Action<carrera>(this.detach_carrera));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFacultad", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idFacultad
		{
			get
			{
				return this._idFacultad;
			}
			set
			{
				if ((this._idFacultad != value))
				{
					this.OnidFacultadChanging(value);
					this.SendPropertyChanging();
					this._idFacultad = value;
					this.SendPropertyChanged("idFacultad");
					this.OnidFacultadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(100)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="facultad_carrera", Storage="_carrera", ThisKey="idFacultad", OtherKey="idFacultad")]
		public EntitySet<carrera> carrera
		{
			get
			{
				return this._carrera;
			}
			set
			{
				this._carrera.Assign(value);
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
		
		private void attach_carrera(carrera entity)
		{
			this.SendPropertyChanging();
			entity.facultad = this;
		}
		
		private void detach_carrera(carrera entity)
		{
			this.SendPropertyChanging();
			entity.facultad = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuario")]
	public partial class usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idUsuario;
		
		private string _nombre;
		
		private string _apellidoPaterno;
		
		private string _apellidoMaterno;
		
		private string _username;
		
		private string _password;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidUsuarioChanging(int value);
    partial void OnidUsuarioChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoPaternoChanging(string value);
    partial void OnapellidoPaternoChanged();
    partial void OnapellidoMaternoChanging(string value);
    partial void OnapellidoMaternoChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public usuario()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NChar(500)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoPaterno", DbType="NChar(255)")]
		public string apellidoPaterno
		{
			get
			{
				return this._apellidoPaterno;
			}
			set
			{
				if ((this._apellidoPaterno != value))
				{
					this.OnapellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoPaterno = value;
					this.SendPropertyChanged("apellidoPaterno");
					this.OnapellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoMaterno", DbType="VarChar(255)")]
		public string apellidoMaterno
		{
			get
			{
				return this._apellidoMaterno;
			}
			set
			{
				if ((this._apellidoMaterno != value))
				{
					this.OnapellidoMaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoMaterno = value;
					this.SendPropertyChanged("apellidoMaterno");
					this.OnapellidoMaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(20)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
