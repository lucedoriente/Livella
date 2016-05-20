using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Enum;
using SharedBase.Domain;

namespace SharedBase.Utils
{
    public static class HelpParser
    {
        #region Metodi Pubblici

        public static string Parse(StructureQueryBuilder structureQueryBuilder, bool skipStaticWhere, bool skipTemporaryWhere, int byIdWhere)
        {
            string query = string.Empty;
            string queryfrom = string.Empty;
            string campiquery = string.Empty;
            string queryjoin = string.Empty;

            try
            {
                // Campi da estrarre
                foreach (StructureQueryBuilder.Tabella tabella in structureQueryBuilder.Tabelle)
                {
                    foreach (StructureQueryBuilder.Campi campo in tabella.ListaCampi)
                    {
                        campiquery = campiquery + campo.NomeTabella + "." + campo.NomeCampo + ", ";
                    }
                    if (tabella.IsMasterTable)
                    {
                        queryfrom = queryfrom + " FROM " + tabella.NomeTabella + " ";
                    }
                }

                // Aggiunge JOIN dalla master

                campiquery = campiquery.Substring(0, campiquery.LastIndexOf(", ")) + " ";

                foreach (StructureQueryBuilder.Tabella tabella in structureQueryBuilder.Tabelle)
                {
                    // Se non è la master devo fare il parse delle join
                    if (!tabella.IsMasterTable)
                    {
                        queryjoin = queryjoin + " " + tabella.RelazioneTabelle.TipoRelazione + " " + tabella.NomeTabella + " ON ";
                        foreach (Tuple<StructureQueryBuilder.Campi, StructureQueryBuilder.Campi> campi in tabella.RelazioneTabelle.ListaCampiRelazione)
                        {
                            queryjoin = queryjoin + campi.Item1.NomeTabella + "." + campi.Item1.NomeCampo + " = " + campi.Item2.NomeTabella + "." +
                                    campi.Item2.NomeCampo + " " + (BooleanOperatori)tabella.RelazioneTabelle.Operatori;
                            // NEST Gestire operatori
                        }
                        if (tabella.RelazioneTabelle.ListaCampiRelazione.Any())
                        {
                            queryjoin = queryjoin.Substring(0, queryjoin.LastIndexOf(" "));
                        }
                        if (!string.IsNullOrWhiteSpace(tabella.RelazioneTabelle.JoinCondition))
                            queryjoin += " AND " + tabella.RelazioneTabelle.JoinCondition;
                    }
                }

                // Aggiunge WHERE

                string queryWhere = "";

                if (!skipStaticWhere)
                    queryWhere = structureQueryBuilder.WherePart.StaticWhere;

                if (!skipTemporaryWhere)
                    queryWhere += (string.IsNullOrWhiteSpace(queryWhere) ? "" : " AND ") + structureQueryBuilder.WherePart.TemporaryWhere;

                if ((byIdWhere > 0))
                    queryWhere += (string.IsNullOrWhiteSpace(queryWhere) ? "" : " AND ") + String.Format(structureQueryBuilder.WherePart.IdWhere, byIdWhere);


                query = ("SELECT " + campiquery + queryfrom + queryjoin + " WHERE " + queryWhere).TrimEnd();
                // Elimino eventuali WHERE in più
                if (query.EndsWith("WHERE"))
                    query = query.Replace("WHERE", "");

                return query;
            }
            catch (Exception ex)
            {
                //LoggingEvents.Log("Si è verificato una anomalia rivolgersi all'amministratore di sistema", TraceEventType.Error, ex);
                return null;
            }
        }

        #endregion Metodi Pubblici
    }
}
