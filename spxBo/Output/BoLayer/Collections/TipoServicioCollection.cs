﻿using System; 
using System.Collections; 
using System.ComponentModel; 
using System.Collections.Generic; 

namespace BOLayer{
[Serializable]
public class TipoServicioCollection : BindingList<TipoServicio>
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
private TipoServicioFactory _factory;

#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoServicioCollection()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoServicioCollection(TipoServicioFactory pFactory)
{
_factory = pFactory;

}

/// <summary>
/// Adds a List of TipoServicio objects.
/// </summary>
public void AddRange(IList pList)
{
foreach( TipoServicio _item in pList ) 
{
   Add(_item);
}

}

/// <summary>
/// Removes an item of type TipoServicio from the Collection.
/// </summary>
protected override void RemoveItem(int pIndex)
{
TipoServicio _tipoServicio = Items[pIndex];
 _factory.Delete( _tipoServicio );
 base.RemoveItem(pIndex);

}

/// <summary>
/// Adds an item of type TipoServicio to the Collection.
/// </summary>
protected override void InsertItem(int pIndex , TipoServicio pTipoServicio)
{
 base.InsertItem(pIndex,pTipoServicio);
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
            List<TipoServicio> items = this.Items as List<TipoServicio>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<TipoServicio> pc = new PropertyComparer<TipoServicio>(pProperty, _currentDirection);
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

