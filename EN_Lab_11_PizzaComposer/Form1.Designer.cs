
namespace EN_Lab_11_PizzaComposer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.radioButtonSizeS = new System.Windows.Forms.RadioButton();
            this.radioButtonSizeM = new System.Windows.Forms.RadioButton();
            this.radioButtonSizeL = new System.Windows.Forms.RadioButton();
            this.checkBoxSauce = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelIngedients = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(394, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(267, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // radioButtonSizeS
            // 
            this.radioButtonSizeS.AutoSize = true;
            this.radioButtonSizeS.Location = new System.Drawing.Point(394, 82);
            this.radioButtonSizeS.Name = "radioButtonSizeS";
            this.radioButtonSizeS.Size = new System.Drawing.Size(32, 17);
            this.radioButtonSizeS.TabIndex = 1;
            this.radioButtonSizeS.TabStop = true;
            this.radioButtonSizeS.Text = "S";
            this.radioButtonSizeS.UseVisualStyleBackColor = true;
            // 
            // radioButtonSizeM
            // 
            this.radioButtonSizeM.AutoSize = true;
            this.radioButtonSizeM.Location = new System.Drawing.Point(485, 82);
            this.radioButtonSizeM.Name = "radioButtonSizeM";
            this.radioButtonSizeM.Size = new System.Drawing.Size(34, 17);
            this.radioButtonSizeM.TabIndex = 2;
            this.radioButtonSizeM.TabStop = true;
            this.radioButtonSizeM.Text = "M";
            this.radioButtonSizeM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSizeL
            // 
            this.radioButtonSizeL.AutoSize = true;
            this.radioButtonSizeL.Location = new System.Drawing.Point(576, 82);
            this.radioButtonSizeL.Name = "radioButtonSizeL";
            this.radioButtonSizeL.Size = new System.Drawing.Size(31, 17);
            this.radioButtonSizeL.TabIndex = 3;
            this.radioButtonSizeL.TabStop = true;
            this.radioButtonSizeL.Text = "L";
            this.radioButtonSizeL.UseVisualStyleBackColor = true;
            // 
            // checkBoxSauce
            // 
            this.checkBoxSauce.AutoSize = true;
            this.checkBoxSauce.Location = new System.Drawing.Point(394, 106);
            this.checkBoxSauce.Name = "checkBoxSauce";
            this.checkBoxSauce.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSauce.TabIndex = 4;
            this.checkBoxSauce.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelIngedients
            // 
            this.flowLayoutPanelIngedients.Location = new System.Drawing.Point(394, 130);
            this.flowLayoutPanelIngedients.Name = "flowLayoutPanelIngedients";
            this.flowLayoutPanelIngedients.Size = new System.Drawing.Size(267, 192);
            this.flowLayoutPanelIngedients.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sauce";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrediens";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(364, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(24, 24);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(325, 328);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(336, 24);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelIngedients);
            this.Controls.Add(this.checkBoxSauce);
            this.Controls.Add(this.radioButtonSizeL);
            this.Controls.Add(this.radioButtonSizeM);
            this.Controls.Add(this.radioButtonSizeS);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonSizeS;
        private System.Windows.Forms.RadioButton radioButtonSizeM;
        private System.Windows.Forms.RadioButton radioButtonSizeL;
        private System.Windows.Forms.CheckBox checkBoxSauce;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelIngedients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
    }
}

