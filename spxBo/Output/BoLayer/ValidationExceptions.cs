using System; 
using System.Collections.Generic; 

namespace BOLayer.Validation{
public class ValidationFailedException : Exception
 {


#region --- Class Fields / Objects  ---

private List<Error> _errors;

#endregion


#region --- Class Properties ---

public List<Error> Errors 
{
get
{

return _errors;
}
}


#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  ValidationFailedException(List<Error> pErrors)
{
if( pErrors == null  ) throw new ArgumentNullException("pErrors");
_errors = pErrors;

}


#endregion
}
}

