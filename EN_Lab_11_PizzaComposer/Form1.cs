using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EN_Lab_11_PizzaComposer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();

            flowLayoutPanelIngedients.Controls.Add(tb);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            string size = "Undefined";
            if(radioButtonSizeS.Checked)
            {
                size = "Small";
            }
            else if(radioButtonSizeM.Checked)
            {
                size = "Medium";
            }
            else if(radioButtonSizeL.Checked)
            {
                size = "Large";
            }

            string sauce = checkBoxSauce.Checked ? "Yes" : "No";

            string ingredients = "";
            foreach(TextBox tb in flowLayoutPanelIngedients.Controls)
            {
                ingredients += tb.Text + ", ";
            }

            string pizza = $"Name: {name}\n\nSize: {size}\n\nSouce: {sauce}\n\nIngredients: {ingredients}";

            MessageBox.Show(pizza);
        }
    }
}
