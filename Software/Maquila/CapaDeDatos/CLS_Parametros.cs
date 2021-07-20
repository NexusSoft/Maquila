using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Parametros : ConexionBase
    {
        public string c_codigo_mat { get;  set; }
        public string v_nombre_mat { get;  set; }
        public string c_codigo_pai { get; set; }
        public string v_nombre_pai { get; set; }
        //Precios del Termo
        public string PrecioMaquilaId { get; set; }
        public int PrecioMaquilaDesde { get; set; }
        public int PrecioMaquilaHasta { get; set; }
        public decimal PrecioMaquilaCosto { get; set; }
        //Precio Maquila
        public decimal PrecioNacional { get; set; }
        public decimal PrecioMalla { get; set; }
        public decimal PrecioAPEAM { get; set; }
        public decimal PrecioCharola25Lb { get; set; }
        public decimal PrecioCharolaRPC { get; set; }
        public string c_codigo_pro { get; set; }
        public string v_nombre_pro { get; set; }
        public string c_codigo_causa { get;  set; }
        public string c_codigo_causah { get;  set; }

        public void MtdSeleccionarParametroTermo()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroPrecioTermo_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdSeleccionarParametroPrecios()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroPrecios_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdSeleccionarParametroAPEAM()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroAPEAM_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdSeleccionarParametroMalla()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterialMalla_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdSeleccionarParametroRPC()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterialRPC_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdSeleccionarParametroProductoExt()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaProductosExcluidos_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdSeleccionarParametro25Lb()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterial25Lb_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdSeleccionarParametroCausa()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroCausa_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdSeleccionarParametroCausaHorario()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroCausaHorario_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdSeleccionarParametroCausaPrecio()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroCausaPrecio_Select";
                _dato.CadenaTexto = c_codigo_causa;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_causa");
                _dato.CadenaTexto = c_codigo_causah;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_causah");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdProducto25Lb_Insert()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterial25Lb_Insert";

                _dato.CadenaTexto = c_codigo_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_mat");
                _dato.CadenaTexto = v_nombre_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_mat");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdProductoRPC_Insert()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterialRPC_Insert";

                _dato.CadenaTexto = c_codigo_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_mat");
                _dato.CadenaTexto = v_nombre_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_mat");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdProductoAPEAM_Insert()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroAPEAM_Insert";

                _dato.CadenaTexto = c_codigo_pai;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pai");
                _dato.CadenaTexto = v_nombre_pai;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_pai");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdProductoMalla_Insert()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterialMalla_Insert";

                _dato.CadenaTexto = c_codigo_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_mat");
                _dato.CadenaTexto = v_nombre_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_mat");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdProductoExc_Insert()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroProductoExc_Insert";

                _dato.CadenaTexto = c_codigo_pro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pro");
                _dato.CadenaTexto = v_nombre_pro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_nombre_pro");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdProducto25Lb_Delete()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterial25Lb_Delete";
                _dato.CadenaTexto = c_codigo_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_mat");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdProductoRPC_Delete()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterialRPC_Delete";
                _dato.CadenaTexto = c_codigo_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_mat");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdProductoAPEAM_Delete()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroAPEAM_Delete";
                _dato.CadenaTexto = c_codigo_pai;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pai");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdProductoMalla_Delete()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroMaterialMalla_Delete";
                _dato.CadenaTexto = c_codigo_mat;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_mat");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdProductoExc_Delete()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroProductoExc_Delete";
                _dato.CadenaTexto = c_codigo_pro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pro");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdPrecioTermo_Update()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroPrecioTermo_Update";
                _dato.Entero = PrecioMaquilaDesde;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "PrecioMaquilaDesde");
                _dato.Entero = PrecioMaquilaHasta;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "PrecioMaquilaHasta");
                _dato.DecimalValor = PrecioMaquilaCosto;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioMaquilaCosto");
                _dato.CadenaTexto = PrecioMaquilaId;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "PrecioMaquilaId");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdPrecio_Update()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaParametroPrecios_Update";
                _dato.DecimalValor = PrecioNacional;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioNacional");
                _dato.DecimalValor = PrecioMalla;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioMalla");
                _dato.DecimalValor = PrecioAPEAM;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioAPEAM");
                _dato.DecimalValor = PrecioCharola25Lb;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioCharola25Lb");
                _dato.DecimalValor = PrecioCharolaRPC;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioCharolaRPC");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

    }
}
