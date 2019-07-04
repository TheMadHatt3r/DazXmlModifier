using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DazXmlModifier
{
    public partial class Form1 : Form
    {

        DazDsx d;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Daz XML Editor - Version " + typeof(Form1).Assembly.GetName().Version;
            btn_save.Enabled = false;
            dg1.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dg1.Rows.Clear();
                LoadFile();
                PopulateGridView();
                btn_save.Enabled = true;
                dg1.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("System Exception trying to load file. Message:" + ex.Message);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SubmitEdits();
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Exception trying to save edits. Message:" + ex.Message);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Boolean SubmitEdits()
        {
            if (d != null)
            {
                //Check for null values
                foreach (DataGridViewRow row in dg1.Rows)
                {
                    if ((String)row.Cells["xContent"].Value == null)
                    {
                        MessageBox.Show("Error, null value for Content in row " + row.Index + ".");
                        return false;
                    }
                    if ((String)row.Cells["xCategories"].Value == null)
                    {
                        MessageBox.Show("Error, null value for Categories in row " + row.Index + ".");
                        return false;
                    }
                    if ((String)row.Cells["xCompatibility"].Value == null)
                    {
                        MessageBox.Show("Error, null value for Compatibility in row " + row.Index + ".");
                        return false;
                    }
                }
                //Do Real Edit
                foreach (DataGridViewRow row in dg1.Rows)
                {
                    String name = (String)row.Cells["xId"].Value;
                    String content = (String)row.Cells["xContent"].Value;
                    String catagories = (String)row.Cells["xCategories"].Value;
                    String compatibility = (String)row.Cells["xCompatibility"].Value;
                    Boolean compatibilityBase = (Convert.ToBoolean(row.Cells["xCompatibilityBase"].Value));
                    d.ProcessAssets(name, content, catagories, compatibility, compatibilityBase);
                }
                d.saveChanges();
                btn_save.Enabled = false;
                dg1.Enabled = false;
            }
            else
                MessageBox.Show("Please first load dsx file.");
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Boolean LoadFile()
        {
            String dsxPath = "";

            if (txt_runtimeDir.Text == null)
            {
                MessageBox.Show("Missing dsx path.");
                return false;
            }

            dsxPath = txt_runtimeDir.Text;

            if (!File.Exists(dsxPath))
            {
                MessageBox.Show("Dsx file does not exist.");
                return false;
            }

            d = new DazDsx(dsxPath);
            lbl_prodName.Text = "Product Name: " + d.productName;
            lbl_globalID.Text = "DAZ Global ID: " + d.globalID;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Boolean PopulateGridView()
        {
            foreach (String s in d.AssetNames)
            {
                dg1.Rows.Add(s,null,null,null,null);
            }
            return true;
        }


        ////Fix for editable combo box in gridview...
        private void dg1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var cbo = e.Control as ComboBox;
            if (cbo == null)
            {
                return;
            }

            cbo.DropDownStyle = ComboBoxStyle.DropDown;
            cbo.Validating -= HandleDG1ComboBoxValidating;
            cbo.Validating += HandleDG1ComboBoxValidating;
        }
        ////Fix for editable combo box in gridview...
        private void HandleDG1ComboBoxValidating(object sender, CancelEventArgs e)
        {
            var combo = sender as DataGridViewComboBoxEditingControl;
            if (combo == null)
            {
                return;
            }
            if (!combo.Items.Contains(combo.Text)) //check if item is already in drop down, if not, add it to all
            {
                var comboColumn = dg1.Columns[dg1.CurrentCell.ColumnIndex] as DataGridViewComboBoxColumn;
                combo.Items.Add(combo.Text);
                comboColumn.Items.Add(combo.Text);
                dg1.CurrentCell.Value = combo.Text;
            }
        }


    }
}
