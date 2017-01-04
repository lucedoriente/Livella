using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedBase.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Enum;
using SharedBase.Domain;

namespace SharedBase.Utils.Tests
{
    [TestClass()]
    public class HelpProjectTests
    {

        [TestMethod()]
        public void SerializzaProjectTest()
        {
            Project pj = crea();

            XmlDocument xml = HelpProject.SerializzaProject(pj);
        }

        private Project crea()
        {
            Project pj = new Project();
            pj.ProjectName = "Test";

            // Creazione tabella di base
            Tabella tb1 = new Tabella();
            tb1.NomeTabella = "Tabella1";
            List<Campo> lc1 = new List<Campo>();

            Campo c1 = new Campo();
            c1.NomeTabella = tb1.NomeTabella;
            c1.NomeCampo = "Nome";
            c1.DataType = "String";
            c1.Description = "Nome del soggetto";
            lc1.Add(c1);

            c1 = new Campo();
            c1.NomeTabella = tb1.NomeTabella;
            c1.NomeCampo = "Cognome";
            c1.DataType = "String";
            c1.Description = "Cognome del soggetto";
            lc1.Add(c1);

            c1 = new Campo();
            c1.NomeTabella = tb1.NomeTabella;
            c1.NomeCampo = "Indirizzo";
            c1.DataType = "String";
            c1.Description = "Indirizzo del soggetto";
            lc1.Add(c1);

            c1 = new Campo();
            c1.NomeTabella = tb1.NomeTabella;
            c1.NomeCampo = "Email";
            c1.DataType = "String";
            c1.Description = "Email del soggetto";
            lc1.Add(c1);

            c1 = new Campo();
            c1.NomeTabella = tb1.NomeTabella;
            c1.NomeCampo = "Eta";
            c1.DataType = "Int";
            c1.Description = "Età del soggetto";
            lc1.Add(c1);

            tb1.ListaCampi = lc1;
            pj.BaseTable = tb1;
            


            // Creazione tabella di comparazione
            Tabella tb2 = new Tabella();
            tb2.NomeTabella = "Tabella2";
            List<Campo> lc2 = new List<Campo>();

            Campo c2 = new Campo();
            c2.NomeTabella = tb2.NomeTabella;
            c2.NomeCampo = "NomeUtente";
            c2.DataType = "String";
            c2.Description = "Nome del soggetto";
            lc2.Add(c2);

            c2 = new Campo();
            c2.NomeTabella = tb2.NomeTabella;
            c2.NomeCampo = "CognomeUtente";
            c2.DataType = "String";
            c2.Description = "Cognome del soggetto";
            lc2.Add(c2);

            c2 = new Campo();
            c2.NomeTabella = tb2.NomeTabella;
            c2.NomeCampo = "Indirizzo";
            c2.DataType = "String";
            c2.Description = "Indirizzo del soggetto";
            lc2.Add(c2);

            c2 = new Campo();
            c2.NomeTabella = tb2.NomeTabella;
            c2.NomeCampo = "Email";
            c2.DataType = "String";
            c2.Description = "Email del soggetto";
            lc2.Add(c2);

            c2 = new Campo();
            c2.NomeTabella = tb2.NomeTabella;
            c2.NomeCampo = "Eta";
            c2.DataType = "Int";
            c2.Description = "Età del soggetto";
            lc2.Add(c2);

            tb2.ListaCampi = lc2;
            pj.CompareTable = tb2;

            // Aggiungo le due tabelle al progetto
            pj.BaseTable = tb1;
            pj.CompareTable = tb2;

            
            
            Campo campo1 = new Campo();
            campo1.NomeTabella = tb1.NomeTabella;
            campo1.NomeCampo = "Nome";
            campo1.DataType = "String";
            campo1.Description = "Nome del soggetto";

            Campo campo2 = new Campo();
            campo2.NomeTabella = tb2.NomeTabella;
            campo2.NomeCampo = "NomeUtente";
            campo2.DataType = "String";
            campo2.Description = "Nome del soggetto";
            
            Join j = new Join();
            j.FirstField = campo1;
            j.SecondField = campo2;

            pj.JoinedFields.Add(j);
            

            return pj;
        }

        [TestMethod()]
        public void SaveXmlTest()
        {
            Project pj = crea();

            XmlDocument xml = HelpProject.SerializzaProject(pj);

            HelpProject.SaveXml(xml, @"C:\project.xml");

        }

        [TestMethod()]
        public void LoadXmlTest()
        {
            XmlDocument xml = HelpProject.LoadXml(@"C:\project.xml");
        }
    }
}