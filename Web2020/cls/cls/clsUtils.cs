using System;
using System.Collections.Generic;
using System.IO;
using System.Web;


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


}
