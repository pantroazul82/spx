using System.IO; 
using System; 
using System.Web; 

namespace BOLayer{
public class Utils
 {


#region --- Class Fields / Objects  ---


#endregion


#region --- Class Methods --- 

public static byte[] ReadFile(string pPath)
{
 string _imageFile = pPath;
if ( !File.Exists(_imageFile)) 
{
 if ( HttpContext.Current != null) 
{
  _imageFile = HttpContext.Current.Request.PhysicalApplicationPath + _imageFile; 
}
}
if ( string.IsNullOrEmpty(_imageFile) || !File.Exists(_imageFile)) 
{
_imageFile = "NotFound.gif"; 
}
FileStream fs = new FileStream(_imageFile, FileMode.OpenOrCreate, FileAccess.Read);
Byte[] img = new Byte[fs.Length];
 fs.Read(img, 0, Convert.ToInt32(fs.Length));
return img;
}


#endregion
}
}

