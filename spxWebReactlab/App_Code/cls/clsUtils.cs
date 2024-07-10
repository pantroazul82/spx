using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.Office.Interop.Excel;

/// <summary>
/// Summary description for clsUtils
/// </summary>
public class clsUtils
{
    public clsUtils()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DateTime generarFecha(string fecha) 
    {
        int ano = 0, mes = 0, dia = 0;
        int.TryParse(fecha.Substring(0, 4), out ano);
        int.TryParse(fecha.Substring(5, 2), out mes);
        int.TryParse(fecha.Substring(8, 2), out dia);
        DateTime fechaRes = new DateTime(ano, mes, dia);
        return fechaRes;
    }

    public void remplazarCampos(string nombreArchivo, SPControladoraDatos.dsCientifica.revision_equiposDataTable revision,System.Web.UI.Page p)
    {
        if (revision[0].Iscod_template_revison_equipoNull()) return;
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter campos = new SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter archivo = new SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter();
        campos.FillBycod_template_revison_equipo(ds.campos_template_revision, revision[0].cod_template_revison_equipo);
        C1.C1Excel.C1XLBook libro = new C1.C1Excel.C1XLBook();
        try
        {
            libro.Load(nombreArchivo);
        }catch(Exception ){
            CGWebUtils.utils.misc.messageBox(p,"El archivo adjuntado inicialmente no es un archivo valido.");
            archivo.DeleteQuery(revision[0].cod_revision_equipos);
            return;
        }
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        for (int k = 0; k < ds.campos_template_revision.Count; k++)
        {
            string value = "";
            switch (ds.campos_template_revision[k].campo.Trim().ToLower())
            {
                case "asesor recibe":
                    {
                        if (!revision[0].Isasesor_recibeNull())
                            value = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario = '" + revision[0].asesor_recibe + "'").ToString();
                        break;
                    }
                case "consecutivo":
                    {
                        value = revision[0].cod_revision_equipos.ToString();
                        break;
                    }
                case "fabricante":
                    {
                        value = bd.ejecutarProcedimiento("select nombreFabricante from vistaEquipo where serial = '" + revision[0].serial.Trim() + "'").ToString();
                        break;
                    }
                case "fecha creacion":
                    {
                        value = revision[0].fecha_creacion.ToShortDateString();
                        break;
                    }
                case "fecha revision":
                    {
                        value = revision[0].fecha_revision.ToShortDateString();
                        break;
                    }
                case "fecha aprobacion":
                    {
                        value = revision[0].fecha_aprobacion.ToShortDateString();
                        break;
                    }
                case "fecha cierre":
                    {
                        value = revision[0].fecha_cierre.ToShortDateString();
                        break;
                    }
                case "ingeniero entrega":
                    {
                        if (!revision[0].Isingeniero_entregaNull())
                            value = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario = '" + revision[0].ingeniero_entrega + "'").ToString();
                        break;
                    }
                case "modelos":
                    {
                        value = bd.ejecutarProcedimiento("select nombreModelo from vistaEquipo where serial = '" + revision[0].serial.Trim() + "'").ToString();

                        break;
                    }
                case "nit cliente":
                    {
                        value = revision[0].nit_cliente;
                        break;
                    }
                case "nombre cliente":
                    {
                        if (!revision[0].Isasesor_recibeNull())
                            value = bd.ejecutarProcedimiento("select nombreCliente from clientes where nitCliente ='" + revision[0].nit_cliente + "'").ToString();

                        break;
                    }
                case "serial ":
                    {
                        value = revision[0].serial;
                        break;
                    }
                case "observaciones": { value = revision[0].observaciones; break; }
                case "observaciones iniciales": { value = revision[0].observaciones_iniciales; break; }
                case "usuario creacion":
                    {
                        if (!revision[0].Isusuario_creacionNull())
                            value = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario = '" + revision[0].usuario_creacion + "'").ToString();

                        break;
                    }

            }
            libro.Sheets[0][ds.campos_template_revision[k].fila, ds.campos_template_revision[k].columna].Value = value;
        }
        libro.Save(nombreArchivo);


    }

    public bool Convertir(string sourcePath, string targetPath, XlFixedFormatType targetType)
    {
        bool result;
        object missing = Type.Missing;
        ApplicationClass application = null;
        Workbook workBook = null;
        try
        {
            application = new ApplicationClass();
            object target = targetPath;
            object type = targetType;
            workBook = application.Workbooks.Open(sourcePath, missing, missing, missing, missing, missing,
                               missing, missing, missing, missing, missing, missing, missing, missing, missing);
            workBook.ExportAsFixedFormat(targetType, target, XlFixedFormatQuality.xlQualityStandard, true, false, missing, missing, missing, missing);
            result = true;
        }
        catch
        {
            result = false;
        }
        finally
        {
            if (workBook != null)
            {
                workBook.Close(true, missing, missing);
                workBook = null;
            }
            if (application != null)
            {
                application.Quit();
                application = null;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        return result;

    }
}
