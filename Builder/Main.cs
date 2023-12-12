using static System.Collections.Specialized.BitVector32;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Builder
{
    public partial class Main : Form
    {
        string option;
        double area;
        double price_1sqmtr_brick = 0.25 * 50;
        double price_1sqmtr_100blk = 16 * 1.50;
        double price_1sqmtr_200blk = 16 * 2.50;
        double price_1cumtr_con = 25;
        double price_1mtr_2kerb = 5 * 2;
        double temp = 0;


        public Main()
        {
            InitializeComponent();
            panelBB.Visible = false;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtSubTtl.Enabled = false;
            txtVAT.Enabled = false;
            txtTtl.Enabled = false;

        }
 
 

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLenght.Clear();
            txtHeight.Clear();
            txtWidth.Clear();
            txtDepth.Clear();
            txtArea.Clear();
            txtSubTtl.Clear();
            txtVAT.Clear();
            txtTtl.Clear();
            txtSubTtl.Enabled = false;
            txtVAT.Enabled = false;
            txtTtl.Enabled = false;
            option = ((ListBox)sender).Text;
            panelBB.Visible = true;
            txtArea.Enabled = false;
            if (option == "Bricks" || option == "100mm Building Blocks" || option == "200mm Building Blocks")
            {

                label1.Visible = false;
                lblmtrs.Text = "sq mtrs";

                lblHeight.Visible = true;
                txtHeight.Visible = true;
                lblHeightmtrs.Visible = true;

                lblWidth.Visible = false;
                lblDepth.Visible = false;
                txtDepth.Visible = false;
                txtWidth.Visible = false;
                lblDepthmtrs.Visible = false;
                lblWidthmtrs.Visible = false;

            }
            else if (option == "Concrete")
            {


                label1.Visible = false;
                lblmtrs.Text = "cu mtrs";

                lblHeight.Visible = false;
                txtHeight.Visible = false;
                lblHeightmtrs.Visible = false;

                lblWidth.Visible = true;
                lblDepth.Visible = true;
                txtDepth.Visible = true;
                txtWidth.Visible = true;
                lblDepthmtrs.Visible = true;
                lblWidthmtrs.Visible = true;


            }
            else
            {
                label1.Visible = false;
                lblmtrs.Text = "mtrs";

                lblHeight.Visible = false;
                txtHeight.Visible = false;
                lblHeightmtrs.Visible = false;

                lblWidth.Visible = false;
                lblDepth.Visible = false;
                txtDepth.Visible = false;
                txtWidth.Visible = false;
                lblDepthmtrs.Visible = false;
                lblWidthmtrs.Visible = false;

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (option == "Bricks" || option == "100mm Building Blocks" || option == "200mm Building Blocks")
            {
                //if (txtLenght.Text == null || txtLenght.Text == " " || txtHeight.Text == null || txtHeight.Text== " ")

                if (txtLenght.Text == "" || txtHeight.Text == "")
                {
                    MessageBox.Show("You must enter a value for Lenght or Height", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    area = Convert.ToDouble(txtLenght.Text) * Convert.ToDouble(txtHeight.Text);
                    txtArea.Enabled = true;
                    txtArea.Text = Math.Round(area, 2).ToString();
                    txtSubTtl.Enabled = true;
                    if (option == "Bricks")
                    {
                        temp = area * price_1sqmtr_brick;
                        txtSubTtl.Text = temp.ToString("C");
                    }
                    else if (option == "100mm Building Blocks")
                    {
                        temp = area * price_1sqmtr_100blk;
                        txtSubTtl.Text = temp.ToString("C");
                    }
                    else
                    {
                        temp = area * price_1sqmtr_200blk;
                        txtSubTtl.Text = temp.ToString("C");
                    }


                }
            }
            else if (option == "Concrete")
            {
                if (txtLenght.Text == "" || txtDepth.Text == "" || txtWidth.Text == "")
                {
                    MessageBox.Show("You must enter a value for Lenght or Depth or width", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    area = Convert.ToDouble(txtLenght.Text) * Convert.ToDouble(txtDepth.Text) * Convert.ToDouble(txtWidth.Text);
                    txtArea.Enabled = true;
                    txtArea.Text = Math.Round(area, 2).ToString();
                    txtSubTtl.Enabled = true;
                    temp = area * price_1cumtr_con;
                    txtSubTtl.Text = temp.ToString("C");


                }

            }
            else if (option == null)
            {
                MessageBox.Show("First select the Material");
            }
            else
            {
                if (txtLenght.Text == "")
                {
                    MessageBox.Show("You must enter a value for Lenght", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    area = Convert.ToDouble(txtLenght.Text);
                    txtArea.Enabled = true;
                    txtArea.Text = Math.Round(area, 2).ToString();
                    txtSubTtl.Enabled = true;
                    temp = area * price_1mtr_2kerb;
                    txtSubTtl.Text = temp.ToString("C");

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArea.Text))
            {
                txtVAT.Enabled = true;
                double tempvat = (temp * .175);
                txtVAT.Text = tempvat.ToString("C");
                txtTtl.Enabled = true;
                txtTtl.Text = (temp + tempvat).ToString("C");
            }
            else
            {
                MessageBox.Show("First Calculate Cost Excluding VAT ", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBB.Visible = false;
            label1.Visible = true;
            txtSubTtl.Clear();
            txtVAT.Clear();
            txtTtl.Clear();
            txtSubTtl.Enabled = false;
            txtVAT.Enabled = false;
            txtTtl.Enabled = false;
        

            listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            listBox1.ClearSelected();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}