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
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();

            flowLayoutPanelIngedients.Controls.Add(tb);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();

            string name = textBoxName.Text;
            pizza.Name = textBoxName.Text;

            string size = "Undefined";
            pizza.Size = 'U';
            if (radioButtonSizeS.Checked)
            {
                size = "Small";
                pizza.Size = 'S';
            }
            else if(radioButtonSizeM.Checked)
            {
                size = "Medium";
                pizza.Size = 'M';
            }
            else if(radioButtonSizeL.Checked)
            {
                size = "Large";
                pizza.Size = 'L';
            }

            string sauce = checkBoxSauce.Checked ? "Yes" : "No";
            pizza.Sauce = checkBoxSauce.Checked ? true : false;

            string ingredients = "";
            foreach(TextBox tb in flowLayoutPanelIngedients.Controls)
            {
                ingredients += tb.Text + ", ";
                Ingerdient ingredient = new Ingerdient();
                ingredient.Name = tb.Text;
                
                pizza.Ingerdients.Add(ingredient);
                //ingredient.Pizza = pizza;
            }

            string pizzaDescription = $"Name: {name}\n\nSize: {size}\n\nSouce: {sauce}\n\nIngredients: {ingredients}";
            MessageBox.Show(pizzaDescription, "Order");

            db.Pizzas.InsertOnSubmit(pizza);
            db.SubmitChanges();
        }
    }
}
