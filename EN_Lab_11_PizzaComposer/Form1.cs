using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

CREATE TABLE [dbo].[Pizza]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Size] NCHAR(1) NOT NULL, 
    [Sauce] BIT NOT NULL
)

CREATE TABLE [dbo].[Ingerdient]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [PizzaId] INT NOT NULL, 
    CONSTRAINT [FK_Ingerdient_Pizza] FOREIGN KEY ([PizzaId]) REFERENCES [Pizza]([Id])
)

*/
namespace EN_Lab_11_PizzaComposer
{
    public partial class Form1 : Form
    {
        DBPizzaDataContext db = new DBPizzaDataContext();

        public Form1()
        {
            InitializeComponent();
            //property Name goes to the list in application (list contains Pizza objects)
            listBoxPizzas.DisplayMember = "Name";

            readDB();
        }

        private void readDB()
        {
            listBoxPizzas.Items.Clear();
            listBoxPizzas.Items.AddRange(db.Pizzas.ToArray());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();

            flowLayoutPanelIngedients.Controls.Add(tb);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            showMessageBox();

            Pizza pizza;
            //update
            if (listBoxPizzas.SelectedItem is Pizza)
            {
                //object from db
                pizza = listBoxPizzas.SelectedItem as Pizza;

                //delete old ingredients
                db.Ingerdients.DeleteAllOnSubmit(pizza.Ingerdients);
            }
            //insert
            else
            {
                //new Pizza object
                pizza = new Pizza();
                db.Pizzas.InsertOnSubmit(pizza);
            }

            pizza.Name = textBoxName.Text;

            pizza.Size = 'U';
            if (radioButtonSizeS.Checked)
            {
                pizza.Size = 'S';
            }
            else if (radioButtonSizeM.Checked)
            {
                pizza.Size = 'M';
            }
            else if (radioButtonSizeL.Checked)
            {
                pizza.Size = 'L';
            }

            pizza.Sauce = checkBoxSauce.Checked ? true : false;

            foreach (TextBox tb in flowLayoutPanelIngedients.Controls)
            {
                Ingerdient ingredient = new Ingerdient();
                ingredient.Name = tb.Text;

                pizza.Ingerdients.Add(ingredient);
                //ingredient.Pizza = pizza;
            }

            db.SubmitChanges();

            clearForm();
            readDB();
        }

        private void clearForm()
        {
            textBoxName.Text = "";
            radioButtonSizeS.Checked = false;
            radioButtonSizeM.Checked = false;
            radioButtonSizeL.Checked = false;
            checkBoxSauce.Checked = false;
            flowLayoutPanelIngedients.Controls.Clear();
        }

        private void showMessageBox()
        {
            string name = textBoxName.Text;

            string size = "Undefined";
            if (radioButtonSizeS.Checked)
            {
                size = "Small";
            }
            else if (radioButtonSizeM.Checked)
            {
                size = "Medium";
            }
            else if (radioButtonSizeL.Checked)
            {
                size = "Large";
            }

            string sauce = checkBoxSauce.Checked ? "Yes" : "No";

            string ingredients = "";
            foreach (TextBox tb in flowLayoutPanelIngedients.Controls)
            {
                ingredients += tb.Text + ", ";
            }
            string pizzaDescription = $"Name: {name}\n\nSize: {size}\n\nSouce: {sauce}\n\nIngredients: {ingredients}";
            MessageBox.Show(pizzaDescription, "Order");

        }

        private void listBoxPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPizzas.SelectedItem is Pizza)
            {
                Pizza pizza = listBoxPizzas.SelectedItem as Pizza;

                textBoxName.Text = pizza.Name;

                switch (pizza.Size)
                {
                    case 'S': radioButtonSizeS.Checked = true; break;
                    case 'M': radioButtonSizeM.Checked = true; break;
                    case 'L': radioButtonSizeL.Checked = true; break;
                    case 'U':
                        radioButtonSizeS.Checked = false;
                        radioButtonSizeM.Checked = false;
                        radioButtonSizeL.Checked = false;
                        break;
                }

                checkBoxSauce.Checked = pizza.Sauce;

                flowLayoutPanelIngedients.Controls.Clear();
                foreach(Ingerdient i in pizza.Ingerdients)
                {
                    TextBox tb = new TextBox();
                    tb.Text = i.Name;
                    flowLayoutPanelIngedients.Controls.Add(tb);
                }
            }
        }
    }
}
