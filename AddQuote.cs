using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Amiola
{
    public partial class AddQuote : Form
    {


        enum DesktopMaterials
        {
            laminate,
            oak,
            rosewood,
            veneer,
            pine
        }



        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            comboDeskMaterials.DataSource = Enum.GetNames(typeof(DesktopMaterials));
        }



        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;

                display_error.Text = "Width cannot be in alphabets characters";
                display_error.ForeColor = Color.Red;
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            display_error.Text = "";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;

                display_error.Text = "Depth cannot be in alphabets characters";
                display_error.ForeColor = Color.Red;
            }


           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            display_error.Text = "";
        }

        private void AddQuote_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {






        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

           

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        


                try
                {

               int width_value = Convert.ToInt32(textBox2.Text);

                if (width_value < 24 || width_value > 96)
                {
                    display_error.Text = "Desk width should be between 24 and 96";
                    display_error.ForeColor = Color.Red;
                }



            }
                catch (FormatException)
                {
   

                 }



            try
            {


                int depth_value = Convert.ToInt32(textBox3.Text);


               if (depth_value < 12 || depth_value > 48)
                {
                    display_error.Text = "Desk depth should be between 12 and 48";
                    display_error.ForeColor = Color.Red;
                }


            }
            catch (FormatException)
            {


            }





        }
    }
}
