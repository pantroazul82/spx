using System; 
using System.Collections; 
using System.ComponentModel; 
using System.Collections.Generic; 

namespace BOLayer{
[Serializable]
public class Problemas_frecuenteCollection : BindingList<Problemas_frecuente>
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
private Problemas_frecuenteFactory _factory;

#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  Problemas_frecuenteCollection()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Problemas_frecuenteCollection(Problemas_frecuenteFactory pFactory)
{
_factory = pFactory;

}

/// <summary>
/// Adds a List of Problemas_frecuente objects.
/// </summary>
public void AddRange(IList pList)
{
foreach( Problemas_frecuente _item in pList ) 
{
   Add(_item);
}

}

/// <summary>
/// Removes an item of type Problemas_frecuente from the Collection.
/// </summary>
protected override void RemoveItem(int pIndex)
{
Problemas_frecuente _problemas_frecuente = Items[pIndex];
 _factory.Delete( _problemas_frecuente );
 base.RemoveItem(pIndex);

}

/// <summary>
/// Adds an item of type Problemas_frecuente to the Collection.
/// </summary>
protected override void InsertItem(int pIndex , Problemas_frecuente pProblemas_frecuente)
{
 base.InsertItem(pIndex,pProblemas_frecuente);
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
            List<Problemas_frecuente> items = this.Items as List<Problemas_frecuente>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<Problemas_frecuente> pc = new PropertyComparer<Problemas_frecuente>(pProperty, _currentDirection);
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

