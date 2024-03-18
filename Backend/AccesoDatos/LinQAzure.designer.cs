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

namespace ForoULAtina.AccesoDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="proyecto_progra_v")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ForoULAtina.Properties.Settings.Default.proyecto_progra_vConnectionString, mappingSource)
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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertar_usuario")]
		public int insertar_usuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="VarChar(255)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Number", DbType="VarChar(255)")] string number, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(255)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="VarChar(255)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TypeU", DbType="Char(1)")] System.Nullable<char> typeU, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Status", DbType="Bit")] System.Nullable<bool> status, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdUser", DbType="Int")] ref System.Nullable<int> idUser, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> errorIdDB, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ErrorFromDB", DbType="VarChar(255)")] ref string errorFromDB)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, number, email, password, typeU, status, idUser, errorIdDB, errorFromDB);
			idUser = ((System.Nullable<int>)(result.GetParameterValue(6)));
			errorIdDB = ((System.Nullable<int>)(result.GetParameterValue(7)));
			errorFromDB = ((string)(result.GetParameterValue(8)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.login")]
		public int login([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Number", DbType="NVarChar(50)")] string number, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(255)")] ref string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Status", DbType="Bit")] ref System.Nullable<bool> status, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TypeU", DbType="Char(1)")] ref System.Nullable<char> typeU, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> errorIdDB, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ErrorFromDB", DbType="VarChar(255)")] ref string errorFromDB)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), number, password, name, status, typeU, errorIdDB, errorFromDB);
			name = ((string)(result.GetParameterValue(2)));
			status = ((System.Nullable<bool>)(result.GetParameterValue(3)));
			typeU = ((System.Nullable<char>)(result.GetParameterValue(4)));
			errorIdDB = ((System.Nullable<int>)(result.GetParameterValue(5)));
			errorFromDB = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.order_validate_number")]
		public int order_validate_number([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Number", DbType="VarChar(255)")] string number, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumberO", DbType="NVarChar(255)")] ref string numberO, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> errorIdDB, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ErrorFromDB", DbType="VarChar(255)")] ref string errorFromDB)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), number, numberO, errorIdDB, errorFromDB);
			numberO = ((string)(result.GetParameterValue(1)));
			errorIdDB = ((System.Nullable<int>)(result.GetParameterValue(2)));
			errorFromDB = ((string)(result.GetParameterValue(3)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.actualizar_inventario")]
		public int actualizar_inventario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string numero, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(4)")] string code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> expiration, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> totalComprar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cantidadProductos, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdProducto", DbType="Int")] System.Nullable<int> idProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> errorIdDB, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ErrorFromDB", DbType="VarChar(255)")] ref string errorFromDB)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numero, code, expiration, totalComprar, cantidadProductos, idProducto, errorIdDB, errorFromDB);
			errorIdDB = ((System.Nullable<int>)(result.GetParameterValue(6)));
			errorFromDB = ((string)(result.GetParameterValue(7)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.order_validate_compra")]
		public int order_validate_compra([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string numero, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(4)")] string code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> expiration, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> totalComprar, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ValidarCompra", DbType="Bit")] ref System.Nullable<bool> validarCompra, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> errorIdDB, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ErrorFromDB", DbType="VarChar(255)")] ref string errorFromDB)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numero, code, expiration, totalComprar, validarCompra, errorIdDB, errorFromDB);
			validarCompra = ((System.Nullable<bool>)(result.GetParameterValue(4)));
			errorIdDB = ((System.Nullable<int>)(result.GetParameterValue(5)));
			errorFromDB = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.order_validate_product")]
		public ISingleResult<order_validate_productResult> order_validate_product([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdProducto", DbType="Int")] System.Nullable<int> idProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cantidad", DbType="Int")] System.Nullable<int> cantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Existe", DbType="Bit")] ref System.Nullable<bool> existe, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> errorIdDB, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ErrorFromDB", DbType="VarChar(255)")] ref string errorFromDB)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProducto, cantidad, existe, errorIdDB, errorFromDB);
			existe = ((System.Nullable<bool>)(result.GetParameterValue(2)));
			errorIdDB = ((System.Nullable<int>)(result.GetParameterValue(3)));
			errorFromDB = ((string)(result.GetParameterValue(4)));
			return ((ISingleResult<order_validate_productResult>)(result.ReturnValue));
		}
	}
	
	public partial class order_validate_productResult
	{
		
		private string _Name;
		
		public order_validate_productResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
