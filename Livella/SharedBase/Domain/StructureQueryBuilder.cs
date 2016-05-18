using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Enum;

namespace SharedBase.Domain
{
    public class StructureQueryBuilder
    {
        public List<Tabella> Tabelle { get; set; }

        public WherePart WherePart { get; set; }

        [Serializable]
        public class Tabella
        {
            #region Costruttori

            public Tabella()
            {
                _listaCampi = new List<Campi>();
                _relazione = new Relazione();
            }

            #endregion Costruttori

            #region Variabili

            private bool _isMasterTable;
            private string _nomeTabella;
            private List<Campi> _listaCampi;
            private Relazione _relazione;

            #endregion Variabili

            #region Proprietà

            [XmlElement("IsMasterTable")]
            public bool IsMasterTable
            {
                get { return _isMasterTable; }
                set { _isMasterTable = value; }
            }

            [XmlArray("ListaCampi")]
            [XmlArrayItem("Campi", typeof(Campi))]
            public List<Campi> ListaCampi
            {
                get { return _listaCampi; }
                set { _listaCampi = value; }
            }

            [XmlElement("RelazioneTabelle")]
            public Relazione RelazioneTabelle
            {
                get { return _relazione; }
                set { _relazione = value; }
            }

            [XmlElement("NomeTabella")]
            public string NomeTabella
            {
                get { return _nomeTabella; }
                set { _nomeTabella = value; }
            }

            #endregion Proprietà
        }

        [Serializable]
        public class Campi
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

            private List<Tuple<Campi, Campi>> _listaCampiRelazione;
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

            public List<Tuple<Campi, Campi>> ListaCampiRelazione
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

    public class WherePart
    {
        #region Variabili

        private string _staticWhere;
        private string _temporaryWhere;
        private string _idWhere;

        #endregion Variabili

        #region Proprietà


        public string StaticWhere
        {
            get { return _staticWhere; }
            set { _staticWhere = value; }
        }

        public string TemporaryWhere
        {
            get { return _temporaryWhere; }
            set { _temporaryWhere = value; }
        }

        public string IdWhere
        {
            get { return _idWhere; }
            set { _idWhere = value; }
        }

        #endregion Proprietà

    }
}
