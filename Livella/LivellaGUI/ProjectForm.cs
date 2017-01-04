using System;
using System.CodeDom.Compiler;
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
        private ListViewItem lastViewBaseTableChecked;
        private ListViewItem lastViewCompareTableChecked;

        public ProjectForm()
        {
            InitializeComponent();
            CreaListBox();
            LoadData();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (listViewBaseTable.Items.Count > 0 && listViewCompareTable.Items.Count > 0)
            {
                string valore = listViewBaseTable.CheckedItems[0].SubItems["NomeTabella"].Text + "." + listViewBaseTable.CheckedItems[0].SubItems["NomeCampo"].Text + " <-> " + listViewCompareTable.CheckedItems[0].SubItems["NomeTabella"].Text + "." + listViewCompareTable.CheckedItems[0].SubItems["NomeCampo"].Text;
                //if (!listBoxLinked.Items.Contains(valore))
                //{
                //    listBoxLinked.Items.Add(valore);
                //}
                //else
                //{
                //    MessageBox.Show(@"Questa coppia di campi è già associata");
                //}
            }
        }

        #region Metodi privati


        private void CreaListBox()
        {

            listViewBaseTable.Columns.Add("Tabella", "Tabella");
            listViewBaseTable.Columns.Add("Campo", "Campo");
            listViewBaseTable.Columns.Add("DataType", "DataType");
            listViewBaseTable.Columns.Add("Descrizione", "Descrizione");

            listViewCompareTable.Columns.Add("Tabella", "Tabella");
            listViewCompareTable.Columns.Add("Campo", "Campo");
            listViewCompareTable.Columns.Add("DataType", "DataType");
            listViewCompareTable.Columns.Add("Descrizione", "Descrizione");

            listViewJoinList.Columns.Add("Join");

        }

        protected void LoadData()
        {

            foreach (Campo campo in Program.Prj.BaseTable.ListaCampi)
            {
                ListViewItem itm = new ListViewItem();
                ListViewItem.ListViewSubItem asd = new ListViewItem.ListViewSubItem();
                asd.Name = "NomeTabella";
                asd.Text = campo.NomeTabella;
                itm.SubItems.Add(asd);
                asd = new ListViewItem.ListViewSubItem();
                asd.Name = "NomeCampo";
                asd.Text = campo.NomeCampo;
                itm.SubItems.Add(asd);
                asd = new ListViewItem.ListViewSubItem();
                asd.Name = "DataType";
                asd.Text = campo.DataType;
                itm.SubItems.Add(asd);
                asd = new ListViewItem.ListViewSubItem();
                asd.Name = "Description";
                asd.Text = campo.Description;
                itm.SubItems.Add(asd);
                listViewBaseTable.Items.Add(itm);
                itm.SubItems.RemoveAt(0);

            }
            listViewBaseTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            foreach (Campo campo in Program.Prj.CompareTable.ListaCampi)
            {
                ListViewItem itm = new ListViewItem();
                ListViewItem.ListViewSubItem asd = new ListViewItem.ListViewSubItem();
                asd.Name = "NomeTabella";
                asd.Text = campo.NomeTabella;
                itm.SubItems.Add(asd);
                asd = new ListViewItem.ListViewSubItem();
                asd.Name = "NomeCampo";
                asd.Text = campo.NomeCampo;
                itm.SubItems.Add(asd);
                asd = new ListViewItem.ListViewSubItem();
                asd.Name = "DataType";
                asd.Text = campo.DataType;
                itm.SubItems.Add(asd);
                asd = new ListViewItem.ListViewSubItem();
                asd.Name = "Description";
                asd.Text = campo.Description;
                itm.SubItems.Add(asd);
                listViewCompareTable.Items.Add(itm);
                itm.SubItems.RemoveAt(0);
            }
            listViewCompareTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            foreach (Join joinedField in Program.Prj.JoinedFields)
            {
                ListViewItem itm = new ListViewItem();
                ListViewItem.ListViewSubItem asd = new ListViewItem.ListViewSubItem();
                asd.Name = "Join";
                asd.Text = joinedField.FirstField.NomeTabella + "."  + joinedField.FirstField.NomeCampo + "<->" + joinedField.SecondField.NomeTabella + "." + joinedField.SecondField.NomeCampo;
                itm.SubItems.Add(asd);
                listViewJoinList.Items.Add(itm);
                itm.SubItems.RemoveAt(0);
            }

            listViewJoinList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        protected void CreaPrj()
        {
            Project pj = new Project();
            pj.ProjectName = Program.Prj.ProjectName;
            // Crea le tabelle
            Tabella tb1 = new Tabella();
            Campo campo;
            foreach (ListViewItem item in listViewBaseTable.Items)
            {
                campo = new Campo();
                campo.NomeTabella = item.SubItems["NomeTabella"].Text;
                campo.NomeCampo = item.SubItems["NomeCampo"].Text;
                campo.DataType = item.SubItems["DataType"].Text;
                campo.Description = item.SubItems["Description"].Text;
                tb1.ListaCampi.Add(campo);
            }

            Tabella tb2 = new Tabella();
            foreach (ListViewItem item in listViewCompareTable.Items)
            {
                campo = new Campo();
                campo.NomeTabella = item.SubItems["NomeTabella"].Text;
                campo.NomeCampo = item.SubItems["NomeCampo"].Text;
                campo.DataType = item.SubItems["DataType"].Text;
                campo.Description = item.SubItems["Description"].Text;
                tb2.ListaCampi.Add(campo);
            }

            // Crea le Join

        }

        private void listBoxLinked_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //if (listBoxLinked.SelectedIndex != -1)
                //{
                //    listBoxLinked.Items.RemoveAt(listBoxLinked.SelectedIndex);
                //}
            }
        }

        private void listViewBaseTable_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // if we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it
            if (lastViewBaseTableChecked != null && lastViewBaseTableChecked.Checked
                && lastViewBaseTableChecked != listViewBaseTable.Items[e.Index])
            {
                // uncheck the last item and store the new one
                lastViewBaseTableChecked.Checked = false;
            }

            // store current item
            lastViewBaseTableChecked = listViewBaseTable.Items[e.Index];
        }

        private void listViewCompareTable_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // if we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it
            if (lastViewCompareTableChecked != null && lastViewCompareTableChecked.Checked
                && lastViewCompareTableChecked != listViewCompareTable.Items[e.Index])
            {
                // uncheck the last item and store the new one
                lastViewCompareTableChecked.Checked = false;
            }

            // store current item
            lastViewCompareTableChecked = listViewCompareTable.Items[e.Index];
        }

        #endregion Metodi privati


    }
}

