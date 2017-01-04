using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharedBase.Domain
{
    [Serializable]
    [XmlRoot("Project")]
    public class Project
    {
        #region Costruttori

        public Project()
        {
            _baseTable = new Tabella();
            _compareTable = new Tabella();
            _joinedFields = new List<Join>();
        }

        #endregion Costruttori

        #region Variabili
        
        private string _projectName;
        private Tabella _baseTable;
        private Tabella _compareTable;
        private List<Join> _joinedFields;

        #endregion Variabili

        #region Proprietà

        [XmlElement("ProjectName")]
        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        [XmlElement("BaseTable")]
        public Tabella BaseTable
        {
            get { return _baseTable; }
            set { _baseTable = value; }
        }

        [XmlElement("CompareTable")]
        public Tabella CompareTable
        {
            get { return _compareTable; }
            set { _compareTable = value; }
        }

        public List<Join> JoinedFields
        {
            get { return _joinedFields; }
            set { _joinedFields = value; }
        }

        #endregion Proprietà
    }

    [Serializable]
    public class Join
    {
        #region Variabili

        private Campo _firstField;
        private Campo _secondField;

        #endregion Variabili

        #region Proprietà

        [XmlElement("FirstField")]
        public Campo FirstField
        {
            get { return _firstField; }
            set { _firstField = value; }
        }

        [XmlElement("SecondField")]
        public Campo SecondField
        {
            get { return _secondField; }
            set { _secondField = value; }
        }

        #endregion Proprietà
    }
}
