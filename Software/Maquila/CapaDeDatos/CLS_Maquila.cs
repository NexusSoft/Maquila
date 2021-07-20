using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_Maquila:ConexionBase
    {
        public int Semana { get; set; }
        public string cManifiesto { get; set; }
        public string cDistribuidor { get; set; }
        public string cFechaEmbarque { get; set; }
        public string cProducto { get; set; }
        public string cEnvase { get; set; }
        public decimal cPesoEstandar { get; set; }
        public int cCajas { get; set; }
        public decimal cMontoMaquila { get; set; }
        public decimal cMallas { get; set; }
        public decimal cAPEAM { get; set; }
        public decimal cSubTotal { get; set; }
        public decimal cCharola { get; set; }
        public decimal cTOTAL { get; set; }
        public int Anio { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string d_fecha_inicio_maq { get;  set; }
        public string d_fecha_fin_maq { get;  set; }
        public int? n_semana_maq { get;  set; }

        public void MtdSeleccionarMaquila()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaXSemana_Select";
                _dato.CadenaTexto = FechaInicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaInicio");
                _dato.CadenaTexto = FechaFin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaFin");
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
        public void MtdInsertarMaquila()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaXSemana_Insert";
                _dato.CadenaTexto = cManifiesto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cManifiesto");
                _dato.CadenaTexto = cDistribuidor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cDistribuidor");
                _dato.CadenaTexto = cFechaEmbarque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cFechaEmbarque");
                _dato.CadenaTexto = cProducto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cProducto");
                _dato.CadenaTexto = cEnvase;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cEnvase");
                _dato.DecimalValor = cPesoEstandar;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cPesoEstandar");
                _dato.Entero = cCajas;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "cCajas");
                _dato.DecimalValor = cMontoMaquila;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cMontoMaquila");
                _dato.DecimalValor = cMallas;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cMallas");
                _dato.DecimalValor = cAPEAM;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cAPEAM");
                _dato.DecimalValor = cSubTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cSubTotal");
                _dato.DecimalValor = cCharola;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cCharola");
                _dato.DecimalValor = cTOTAL;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cTOTAL");
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
        public void MtdEliminarMaquila()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaXSemana_Delete";
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

        public void MtdGuardarMaquilaDetalles()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaDetalles_Insert";
                _dato.CadenaTexto = cManifiesto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cManifiesto");
                _dato.CadenaTexto = cDistribuidor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cDistribuidor");
                _dato.CadenaTexto = cFechaEmbarque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cFechaEmbarque");
                _dato.CadenaTexto = cProducto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cProducto");
                _dato.CadenaTexto = cEnvase;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "cEnvase");
                _dato.DecimalValor = cPesoEstandar;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cPesoEstandar");
                _dato.Entero = cCajas;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "cCajas");
                _dato.DecimalValor = cMontoMaquila;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cMontoMaquila");
                _dato.DecimalValor = cMallas;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cMallas");
                _dato.DecimalValor = cAPEAM;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cAPEAM");
                _dato.DecimalValor = cSubTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cSubTotal");
                _dato.DecimalValor = cCharola;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cCharola");
                _dato.DecimalValor = cTOTAL;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "cTOTAL");
                _dato.CadenaTexto = d_fecha_inicio_maq;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fecha_inicio_maq");
                _dato.CadenaTexto = d_fecha_fin_maq;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fecha_fin_maq");
                _dato.Entero = n_semana_maq;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "n_semana_maq");
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
        public void MtdEliminarMaquilaDetalles()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaDetalles_Delete";
                _dato.CadenaTexto = d_fecha_inicio_maq;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fecha_inicio_maq");
                _dato.CadenaTexto = d_fecha_fin_maq;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fecha_fin_maq");
                _dato.Entero = n_semana_maq;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "n_semana_maq");
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
        public void MtdSeleccionarMaquilaDetalles()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "MaquilaDetalles_Select";
                _dato.CadenaTexto = d_fecha_inicio_maq;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fecha_inicio_maq");
                _dato.CadenaTexto = d_fecha_fin_maq;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_fecha_fin_maq");
                _dato.Entero = n_semana_maq;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "n_semana_maq");
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
