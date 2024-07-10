using System; 
using System.Collections; 
using System.ComponentModel; 
using System.Collections.Generic; 

namespace BOLayer{
[Serializable]
public class ArchivosxEntradaSalidaEquipoCollection : BindingList<ArchivosxEntradaSalidaEquipo>
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
private ArchivosxEntradaSalidaEquipoFactory _factory;

#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  ArchivosxEntradaSalidaEquipoCollection()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ArchivosxEntradaSalidaEquipoCollection(ArchivosxEntradaSalidaEquipoFactory pFactory)
{
_factory = pFactory;

}

/// <summary>
/// Adds a List of ArchivosxEntradaSalidaEquipo objects.
/// </summary>
public void AddRange(IList pList)
{
foreach( ArchivosxEntradaSalidaEquipo _item in pList ) 
{
   Add(_item);
}

}

/// <summary>
/// Removes an item of type ArchivosxEntradaSalidaEquipo from the Collection.
/// </summary>
protected override void RemoveItem(int pIndex)
{
ArchivosxEntradaSalidaEquipo _archivosxEntradaSalidaEquipo = Items[pIndex];
 _factory.Delete( _archivosxEntradaSalidaEquipo );
 base.RemoveItem(pIndex);

}

/// <summary>
/// Adds an item of type ArchivosxEntradaSalidaEquipo to the Collection.
/// </summary>
protected override void InsertItem(int pIndex , ArchivosxEntradaSalidaEquipo pArchivosxEntradaSalidaEquipo)
{
 base.InsertItem(pIndex,pArchivosxEntradaSalidaEquipo);
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
            List<ArchivosxEntradaSalidaEquipo> items = this.Items as List<ArchivosxEntradaSalidaEquipo>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<ArchivosxEntradaSalidaEquipo> pc = new PropertyComparer<ArchivosxEntradaSalidaEquipo>(pProperty, _currentDirection);
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

