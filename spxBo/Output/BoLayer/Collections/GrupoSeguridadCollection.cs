using System; 
using System.Collections; 
using System.ComponentModel; 
using System.Collections.Generic; 

namespace BOLayer{
[Serializable]
public class GrupoSeguridadCollection : BindingList<GrupoSeguridad>
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
private GrupoSeguridadFactory _factory;

#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  GrupoSeguridadCollection()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  GrupoSeguridadCollection(GrupoSeguridadFactory pFactory)
{
_factory = pFactory;

}

/// <summary>
/// Adds a List of GrupoSeguridad objects.
/// </summary>
public void AddRange(IList pList)
{
foreach( GrupoSeguridad _item in pList ) 
{
   Add(_item);
}

}

/// <summary>
/// Removes an item of type GrupoSeguridad from the Collection.
/// </summary>
protected override void RemoveItem(int pIndex)
{
GrupoSeguridad _grupoSeguridad = Items[pIndex];
 _factory.Delete( _grupoSeguridad );
 base.RemoveItem(pIndex);

}

/// <summary>
/// Adds an item of type GrupoSeguridad to the Collection.
/// </summary>
protected override void InsertItem(int pIndex , GrupoSeguridad pGrupoSeguridad)
{
 base.InsertItem(pIndex,pGrupoSeguridad);
}


#endregion
        #region --- Sorting Support ----

        private bool _isSorted = false;

        /// <summary>
        /// Support sorting
        /// </summary>
        /// <value></value>
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }
          
        [NonSerialized]private ListSortDirection _currentDirection =  ListSortDirection.Ascending  ;
        [NonSerialized]private PropertyDescriptor _currentSortProp = null;

        protected override void ApplySortCore(PropertyDescriptor pProperty, ListSortDirection pDirection)
        {
            // Get list to sort
            List<GrupoSeguridad> items = this.Items as List<GrupoSeguridad>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<GrupoSeguridad> pc = new PropertyComparer<GrupoSeguridad>(pProperty, _currentDirection);
                items.Sort(pc);
                SwitchDirection();
                _isSorted = true;
            }

            _currentSortProp = pProperty;
            //_currentDirection = pDirection;

            // Let bound controls know they should refresh their views
            this.OnListChanged( new ListChangedEventArgs(ListChangedType.Reset, -1));            
        }

        /// <summary>
        /// Switched from ascending to descending.
        /// </summary>
        /// <param name="pDirection"></param>
        /// <returns></returns>
        private void SwitchDirection()
        {
            if (_currentDirection == ListSortDirection.Ascending)
                _currentDirection = ListSortDirection.Descending;
            else
                _currentDirection = ListSortDirection.Ascending;
        }
        protected override void RemoveSortCore()
        {
            _isSorted = false;
        }


        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _currentSortProp; }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get { return _currentDirection; }
        }
        #endregion


}
}

