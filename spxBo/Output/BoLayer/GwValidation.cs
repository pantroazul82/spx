using System; 
using System.Collections.Generic; 

namespace BOLayer.Validation{
public interface IValidatable
 {


#region --- Class Fields / Objects  ---


#endregion


#region --- Class Properties ---

bool IsValid
{
get;
}


#endregion


#region --- Class Methods --- 

List<Error> Validate();


#endregion
}
}

