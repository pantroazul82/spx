using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Web2020.cls
{
    public class WebUtils
    {
        #region --- Class Fields / Objects  ---


        #endregion


        #region --- Class Methods --- 

        public static void SetValue(object pObject, string pKey, object pValue)
        {
            if (pObject == null) throw new ArgumentNullException("pObject");
            if (string.IsNullOrEmpty(pKey)) throw new ArgumentNullException("pKey");
            System.ComponentModel.PropertyDescriptor _prop = System.ComponentModel.TypeDescriptor.GetProperties(pObject)[pKey];
            if (_prop == null) return;
            if (_prop.IsReadOnly) throw new ArgumentException("The Property " + pKey + " is read only. You should not change it's value");
            // Do not try to bind read only properties.
            if (_prop.IsReadOnly) return;
            Object _value = pValue;
            if (pValue != null)
            {
                _value = _prop.Converter.ConvertFromString(pValue.ToString());
            }
            _prop.SetValue(pObject, _value);

        }

        public static int FindColumnIndex(GridView pControl, string pSortExpression)
        {
            if (pControl == null) throw new ArgumentNullException("pControl");
            if (string.IsNullOrEmpty(pSortExpression)) throw new ArgumentNullException("pSortExpression");
            int _index = 0;
            foreach (DataControlField _dcf in pControl.Columns)
            {
                if (_dcf.SortExpression == pSortExpression) return _index;
                _index++;
            }

            // 2nd attempt , if the Sort Expression contains a DESC, remove it.
            if (pSortExpression.Contains(" DESC"))
            {

                _index = 0;
                string _sortExpression = pSortExpression.Replace(" DESC", string.Empty);

                foreach (DataControlField _dcf in pControl.Columns)
                {
                    if (_dcf.SortExpression.Equals(_sortExpression, StringComparison.InvariantCultureIgnoreCase)) return _index;
                    _index++;
                }
            }

            // Column not found , return -1 
            return -1;

        }

        public static void SortExpressionTransformer(GridViewSortEventArgs pEventArgs)
        {
            if (pEventArgs == null) throw new ArgumentNullException("pEventArgs");
            if (pEventArgs.SortDirection == SortDirection.Descending)
            {
                if (pEventArgs.SortExpression.Contains(","))
                {
                    // Case : We have a composite sorting ( Field1,Field2) 
                    string newSortExpression = string.Empty;
                    string[] sortParts = pEventArgs.SortExpression.Split(',');
                    for (int i = 0; i < sortParts.Length; i++)
                    {
                        string sortPart = sortParts[i];

                        int sortDirectionIndex = sortPart.IndexOf(" DESC");
                        bool isDescending = (sortDirectionIndex > -1);

                        string property = sortPart;
                        if (isDescending)
                        {
                            property = sortPart.Substring(0, (sortPart.Length - sortDirectionIndex + 1));
                        }
                        else
                        {
                            if (i > 0) newSortExpression += ",";
                            newSortExpression += property;
                            // Only add the DESC to all except the last (Last one will be controlled automatically by the object datasource.
                            if (i < (sortParts.Length - 1))
                                newSortExpression += " DESC";
                        }
                    }
                    pEventArgs.SortExpression = newSortExpression;
                }
            }

        }


        #endregion
    }
}