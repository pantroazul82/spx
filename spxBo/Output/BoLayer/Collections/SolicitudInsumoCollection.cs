﻿using System; 
using System.Collections; 
using System.ComponentModel; 
using System.Collections.Generic; 

namespace BOLayer{
[Serializable]
public class SolicitudInsumoCollection : BindingList<SolicitudInsumo>
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
private SolicitudInsumoFactory _factory;

#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  SolicitudInsumoCollection()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  SolicitudInsumoCollection(SolicitudInsumoFactory pFactory)
{
_factory = pFactory;

}

/// <summary>
/// Adds a List of SolicitudInsumo objects.
/// </summary>
public void AddRange(IList pList)
{
foreach( SolicitudInsumo _item in pList ) 
{
   Add(_item);
}

}

/// <summary>
/// Removes an item of type SolicitudInsumo from the Collection.
/// </summary>
protected override void RemoveItem(int pIndex)
{
SolicitudInsumo _solicitudInsumo = Items[pIndex];
 _factory.Delete( _solicitudInsumo );
 base.RemoveItem(pIndex);

}

/// <summary>
/// Adds an item of type SolicitudInsumo to the Collection.
/// </summary>
protected override void InsertItem(int pIndex , SolicitudInsumo pSolicitudInsumo)
{
 base.InsertItem(pIndex,pSolicitudInsumo);
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
            List<SolicitudInsumo> items = this.Items as List<SolicitudInsumo>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<SolicitudInsumo> pc = new PropertyComparer<SolicitudInsumo>(pProperty, _currentDirection);
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

