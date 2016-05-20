using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Enum;

namespace SharedBase.Domain
{
    [Serializable]
    [XmlRoot("Tabella")]
    public class Tabella
    {
        #region Costruttori

        //public Tabella()
        //{
        //    _listaCampi = new List<Campi>();
        //    _relazione = new Relazione();
        //}

        #endregion Costruttori

        #region Variabili
        
        private string _nomeTabella;
        private List<Campo> _listaCampi;

        #endregion Variabili

        #region Proprietà

        [XmlElement("NomeTabella")]
        public string NomeTabella
        {
            get { return _nomeTabella; }
            set { _nomeTabella = value; }
        }

        [XmlArray("ListaCampi")]
        [XmlArrayItem("Campi", typeof(Campo))]
        public List<Campo> ListaCampi
        {
            get { return _listaCampi; }
            set { _listaCampi = value; }
        }

        #endregion Proprietà
    }

    [Serializable]
    public class Campo
    {

        #region Variabili

        private string _nomeTabella;
        private string _nomeCampo;
        private string _dataType;
        private string _description;

        #endregion Variabili

        #region Proprietà

        [XmlElement("NomeTabella")]
        public string NomeTabella
        {
            get { return _nomeTabella; }
            set { _nomeTabella = value; }
        }

        [XmlElement("NomeCampo")]
        public string NomeCampo
        {
            get { return _nomeCampo; }
            set { _nomeCampo = value; }
        }

        [XmlElement("DataType")]
        public string DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        [XmlElement("Description")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        #endregion Proprietà

    }

    public class Relazione
    {
        #region Variabili

        private List<Tuple<Campo, Campo>> _listaCampiRelazione;
        private BooleanOperatori _tipoOperatori;
        private string _tipoRelazione;
        private string _joinCondition;

        #endregion Variabili

        #region Proprietà


        public BooleanOperatori Operatori
        {
            get { return _tipoOperatori; }
            set { _tipoOperatori = value; }
        }

        public List<Tuple<Campo, Campo>> ListaCampiRelazione
        {
            get { return _listaCampiRelazione; }
            set { _listaCampiRelazione = value; }
        }

        public string TipoRelazione
        {
            get { return _tipoRelazione; }
            set { _tipoRelazione = value; }
        }

        public string JoinCondition
        {
            get { return _joinCondition; }
            set { _joinCondition = value; }
        }

        #endregion Proprietà

    }

}
