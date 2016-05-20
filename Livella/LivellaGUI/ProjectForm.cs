using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedBase.Domain;
using SharedBase.Utils;

namespace LivellaGUI
{
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (listBoxBaseTable.Items.Count > 0 && listBoxCompareTable.Items.Count > 0)
            {
                var selectedField1 = listBoxBaseTable.SelectedItem;
                var selectedField2 = listBoxCompareTable.SelectedItem;
                string valore = selectedField1.ToString() + " <-> " + selectedField2.ToString();
                if (!listBoxLinked.Items.Contains(valore))
                {
                    listBoxLinked.Items.Add(selectedField1.ToString() + " <-> " + selectedField2.ToString());
                }
                else
                {
                    MessageBox.Show(@"Questa coppia di campi è già associata");
                }
            }
        }

        #region Metodi privati

        protected void LoadData()
        {
            foreach (Campo campo in Program.Prj.BaseTable.ListaCampi)
            {
                listBoxBaseTable.Items.Add(campo.NomeTabella + "." + campo.NomeCampo);
            }

            foreach (Campo campo in Program.Prj.CompareTable.ListaCampi)
            {
                listBoxCompareTable.Items.Add(campo.NomeTabella + "." + campo.NomeCampo);
            }
        }

        #endregion Metodi privati
    }
}
