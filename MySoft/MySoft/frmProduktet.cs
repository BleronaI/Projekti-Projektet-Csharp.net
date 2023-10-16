using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySoft
{
    public partial class frmProduktet : Form
    {
        public frmProduktet()
        {
            InitializeComponent();
        }

        private void frmProduktet_Load(object sender, EventArgs e)
        {
            FillProducts();
            FillCategory();
            dgvProduktet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;       
            
        }


        private void FillProducts(string searchText=null)
        {
            using (var context = new Model1())
            {
                var product = (from Produktet in context.Produktets.AsNoTracking()
                                where (searchText != null ?
                        ( Produktet.Emri.ToLower().StartsWith(searchText)
                        ):true)
                        orderby Produktet.Id descending
                        select new
                        {
                            Produktet.Id,
                            Produktet.CmimiMeTVSH,
                            Produktet.Emri,
                            Produktet.DataEProdhimit,
                            Produktet.Pershkrimi,
                            Produktet.KategoriaId,
                            Produktet.Vendor,
                            Produktet.JoVendor
                        }).ToList();
            
            
                dgvProduktet.DataSource = product;
                dgvProduktet.AutoGenerateColumns = false;
            
            
            }
        }


        private void FillCategory()
        {
            using(var context = new Model1())
            {
                var kategoria = (from c in context.Kategorias select new { c.IdKategoria, c.TitulliKategoris }).ToList();

                cbKategoria.DataSource = kategoria;
                cbKategoria.DisplayMember = "TitulliKategoris";
                cbKategoria.ValueMember = "IdKategoria";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text; 
            FillProducts(searchText);
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtId.Text= string.Empty;   
            txtEmri.Text= string.Empty; 
            txtCmimiMeTVSH.Text= string.Empty;  
            txtPershkrimi.Text= string.Empty;       
            dtpData.Text= string.Empty;
            cbKategoria.Text = "Zgjedh Kategorine";
            radioJoVendor.Checked = false;
            radioVendor.Checked = false;        
        }

        private bool isValid()
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Gabim Id:");
                return false;
            }

            if(txtEmri.Text == "")
            {
                MessageBox.Show("Shkruani emrin:");
                return false;
            }

            if (txtCmimiMeTVSH.Text == "")
            {
                MessageBox.Show("Shkruani cmimin:");
                return false;
            }
            if (txtPershkrimi.Text == "")
            {
                MessageBox.Show("Shkruani pershkrimin:");
                return false;
            }


            if (radioVendor.Checked == false && radioJoVendor.Checked == false)
            {
                MessageBox.Show("Zgjedhni njeri nga opeonet vendore ose jo");
                return false;
            }
        

            return true;
        }

        private bool isEditMode()
        {
            return dgvProduktet.SelectedRows.Count > 0;
        }
        private int getProductId()
        {
            return Convert.ToInt32(dgvProduktet.SelectedRows[0].Cells["Id"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                if (isValid())
                {
                    try
                    {

                        if (isEditMode())
                        {
                            int produktiId = getProductId();

                            Produktet product = context.Produktets.FirstOrDefault(t => t.Id == produktiId);


                            if(product != null)
                            {
                                product.Id = int.Parse(txtId.Text);
                                product.Emri = txtEmri.Text;
                                product.CmimiMeTVSH = double.Parse(txtCmimiMeTVSH.Text);
                                product.Pershkrimi = txtPershkrimi.Text;
                                product.DataEProdhimit = DateTime.Parse(dtpData.Text);
                                product.KategoriaId = int.Parse(cbKategoria.SelectedValue.ToString());
                                product.Vendor = radioVendor.Checked ? 1 : (int?)null;
                                product.JoVendor = radioJoVendor.Checked ? 1 : (int?)null;


                                context.SaveChanges();
                                MessageBox.Show("U editua");
                                FillProducts();
                                ClearFields();
                            }
                        }
                        else
                        {
                            Produktet product1 = new Produktet();   
                            product1.Id = int.Parse(txtId.Text);
                            product1.Emri = txtEmri.Text;
                            product1.CmimiMeTVSH = double.Parse(txtCmimiMeTVSH.Text);
                            product1.Pershkrimi = txtPershkrimi.Text;
                            product1.DataEProdhimit = DateTime.Parse(dtpData.Text);
                            product1.KategoriaId = int.Parse(cbKategoria.SelectedValue.ToString());
                            product1.Vendor = radioVendor.Checked ? 1 : (int?)null;
                            product1.JoVendor = radioJoVendor.Checked ? 1 : (int?)null;
                            context.Produktets.Add(product1);

                            context.SaveChanges();
                            MessageBox.Show("U shtua");
                            FillProducts();
                            ClearFields();

                        }

                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Gabim " + ex);
                        return;
                    }
                }

               
            }

            dgvProduktet.ClearSelection();
        }






      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvProduktet_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.RowIndex < dgvProduktet.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvProduktet.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtEmri.Text = selectedRow.Cells["Emri"].Value.ToString();
                txtCmimiMeTVSH.Text = selectedRow.Cells["CmimiMeTVSH"].Value.ToString();
                txtPershkrimi.Text = selectedRow.Cells["pershkrimi"].Value.ToString();
                string vlera = selectedRow.Cells["Vendor"].Value != null ? selectedRow.Cells["Vendor"].Value.ToString() : "0";
                string vlera1 = selectedRow.Cells["JoVendor"].Value != null ? selectedRow.Cells["JoVendor"].Value.ToString() : "0";

                if (vlera == "1")
                {
                    radioVendor.Checked = true;
                }
                else if (vlera1 == "1")
                {
                    radioJoVendor.Checked = true;
                }

            }
        }

        private void cbKategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
