using System; 
using System.Collections; 
using System.ComponentModel; 
using System.Collections.Generic; 

namespace BOLayer{
[Serializable]
public class SmtpServerCollection : BindingList<SmtpServer>
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
private SmtpServerFactory _factory;

#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
public  SmtpServerCollection()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  SmtpServerCollection(SmtpServerFactory pFactory)
{
_factory = pFactory;

}

/// <summary>
/// Adds a List of SmtpServer objects.
/// </summary>
public void AddRange(IList pList)
{
foreach( SmtpServer _item in pList ) 
{
   Add(_item);
}

}

/// <summary>
/// Removes an item of type SmtpServer from the Collection.
/// </summary>
protected override void RemoveItem(int pIndex)
{
SmtpServer _smtpServer = Items[pIndex];
 _factory.Delete( _smtpServer );
 base.RemoveItem(pIndex);

}

/// <summary>
/// Adds an item of type SmtpServer to the Collection.
/// </summary>
protected override void InsertItem(int pIndex , SmtpServer pSmtpServer)
{
 base.InsertItem(pIndex,pSmtpServer);
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
            List<SmtpServer> items = this.Items as List<SmtpServer>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<SmtpServer> pc = new PropertyComparer<SmtpServer>(pProperty, _currentDirection);
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

