using System;

namespace BOLayer{
public enum FetchMode { Default = 0, Lazy = 1, Eager = 2 }
public enum SessionScope { PerOperation , FactoryScope, SessionFactory }


	/// <summary>
	/// Allows to extend the MetaData of the POCO class.
	///
	/// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]

    public class GenWiseAttribute : System.Attribute
    {

        #region --- Constructors ---

        public GenWiseAttribute()
        {
        }

        #endregion

        #region --- Fields  ---

        private System.Type _collectionOfType;
        private bool _isDataSourceEntity;
        private string _relationID;

        #endregion

        #region --- Properties ---

        /// <summary>
        /// The Type of the object inside the IList
        /// </summary>
        /// <value></value>
        public System.Type CollectionOfType
        {
            get
            {
                return _collectionOfType;
            }
            set
            {
                _collectionOfType = value;
            }
        }

        public bool IsDataSourceEntity
        {
            get { return _isDataSourceEntity; }
            set { _isDataSourceEntity = value; }
        }
        
        /// <summary>
        /// Database Repository Relation GUID.
        /// Used to keep a link between the DataObjects and the DbRepository.
        /// </summary>
        /// <value></value>
        public string RelationID
        {
            get
            {
                return _relationID;
            }
            set
            {
                _relationID = value;
            }
        }



        #endregion

    }

}

