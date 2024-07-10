using System; 
using System.Collections; 
using System.ComponentModel; 
using System.Collections.Generic; 

namespace BOLayer{
[Serializable]
public class UnidadTiempoCollection : BindingList<UnidadTiempo>
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
private UnidadTiempoFactory _factory;

#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  UnidadTiempoCollection()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  UnidadTiempoCollection(UnidadTiempoFactory pFactory)
{
_factory = pFactory;

}

/// <summary>
/// Adds a List of UnidadTiempo objects.
/// </summary>
public void AddRange(IList pList)
{
foreach( UnidadTiempo _item in pList ) 
{
   Add(_item);
}

}

/// <summary>
/// Removes an item of type UnidadTiempo from the Collection.
/// </summary>
protected override void RemoveItem(int pIndex)
{
UnidadTiempo _unidadTiempo = Items[pIndex];
 _factory.Delete( _unidadTiempo );
 base.RemoveItem(pIndex);

}

/// <summary>
/// Adds an item of type UnidadTiempo to the Collection.
/// </summary>
protected override void InsertItem(int pIndex , UnidadTiempo pUnidadTiempo)
{
 base.InsertItem(pIndex,pUnidadTiempo);
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
            List<UnidadTiempo> items = this.Items as List<UnidadTiempo>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<UnidadTiempo> pc = new PropertyComparer<UnidadTiempo>(pProperty, _currentDirection);
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

