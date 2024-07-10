using System; 
using System.Collections; 
using System.ComponentModel; 
using System.Collections.Generic; 

namespace BOLayer{
[Serializable]
public class Soluciones_problemaCollection : BindingList<Soluciones_problema>
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
private Soluciones_problemaFactory _factory;

#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  Soluciones_problemaCollection()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Soluciones_problemaCollection(Soluciones_problemaFactory pFactory)
{
_factory = pFactory;

}

/// <summary>
/// Adds a List of Soluciones_problema objects.
/// </summary>
public void AddRange(IList pList)
{
foreach( Soluciones_problema _item in pList ) 
{
   Add(_item);
}

}

/// <summary>
/// Removes an item of type Soluciones_problema from the Collection.
/// </summary>
protected override void RemoveItem(int pIndex)
{
Soluciones_problema _soluciones_problema = Items[pIndex];
 _factory.Delete( _soluciones_problema );
 base.RemoveItem(pIndex);

}

/// <summary>
/// Adds an item of type Soluciones_problema to the Collection.
/// </summary>
protected override void InsertItem(int pIndex , Soluciones_problema pSoluciones_problema)
{
 base.InsertItem(pIndex,pSoluciones_problema);
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
            List<Soluciones_problema> items = this.Items as List<Soluciones_problema>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<Soluciones_problema> pc = new PropertyComparer<Soluciones_problema>(pProperty, _currentDirection);
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

