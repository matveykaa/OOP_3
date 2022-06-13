
namespace WindowsFormsApp1
{
    partial class Form2
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
        public void InitializeComponent()
        {
            this.rbFish = new System.Windows.Forms.RadioButton();
            this.rbBirds = new System.Windows.Forms.RadioButton();
            this.rbReptiles = new System.Windows.Forms.RadioButton();
            this.rbAmphibians = new System.Windows.Forms.RadioButton();
            this.rbMammals = new System.Windows.Forms.RadioButton();
            this.rbInsects = new System.Windows.Forms.RadioButton();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.btOk = new System.Windows.Forms.Button();
            this.lbAnimal = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbHabitat = new System.Windows.Forms.Label();
            this.tbHabitat = new System.Windows.Forms.TextBox();
            this.tbExtra = new System.Windows.Forms.TextBox();
            this.lbExtra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbFish
            // 
            this.rbFish.AutoSize = true;
            this.rbFish.Location = new System.Drawing.Point(12, 59);
            this.rbFish.Name = "rbFish";
            this.rbFish.Size = new System.Drawing.Size(55, 21);
            this.rbFish.TabIndex = 0;
            this.rbFish.TabStop = true;
            this.rbFish.Text = "Fish";
            this.rbFish.UseVisualStyleBackColor = true;
            this.rbFish.CheckedChanged += new System.EventHandler(this.rbFish_CheckedChanged);
            // 
            // rbBirds
            // 
            this.rbBirds.AutoSize = true;
            this.rbBirds.Location = new System.Drawing.Point(12, 100);
            this.rbBirds.Name = "rbBirds";
            this.rbBirds.Size = new System.Drawing.Size(61, 21);
            this.rbBirds.TabIndex = 1;
            this.rbBirds.TabStop = true;
            this.rbBirds.Text = "Birds";
            this.rbBirds.UseVisualStyleBackColor = true;
            this.rbBirds.CheckedChanged += new System.EventHandler(this.rbBirds_CheckedChanged);
            // 
            // rbReptiles
            // 
            this.rbReptiles.AutoSize = true;
            this.rbReptiles.Location = new System.Drawing.Point(12, 137);
            this.rbReptiles.Name = "rbReptiles";
            this.rbReptiles.Size = new System.Drawing.Size(80, 21);
            this.rbReptiles.TabIndex = 2;
            this.rbReptiles.TabStop = true;
            this.rbReptiles.Text = "Reptiles";
            this.rbReptiles.UseVisualStyleBackColor = true;
            this.rbReptiles.CheckedChanged += new System.EventHandler(this.rbReptiles_CheckedChanged);
            // 
            // rbAmphibians
            // 
            this.rbAmphibians.AutoSize = true;
            this.rbAmphibians.Location = new System.Drawing.Point(12, 176);
            this.rbAmphibians.Name = "rbAmphibians";
            this.rbAmphibians.Size = new System.Drawing.Size(102, 21);
            this.rbAmphibians.TabIndex = 3;
            this.rbAmphibians.TabStop = true;
            this.rbAmphibians.Text = "Amphibians";
            this.rbAmphibians.UseVisualStyleBackColor = true;
            this.rbAmphibians.CheckedChanged += new System.EventHandler(this.rbAmphibians_CheckedChanged);
            // 
            // rbMammals
            // 
            this.rbMammals.AutoSize = true;
            this.rbMammals.Location = new System.Drawing.Point(12, 215);
            this.rbMammals.Name = "rbMammals";
            this.rbMammals.Size = new System.Drawing.Size(88, 21);
            this.rbMammals.TabIndex = 4;
            this.rbMammals.TabStop = true;
            this.rbMammals.Text = "Mammals";
            this.rbMammals.UseVisualStyleBackColor = true;
            this.rbMammals.CheckedChanged += new System.EventHandler(this.rbMammals_CheckedChanged);
            // 
            // rbInsects
            // 
            this.rbInsects.AutoSize = true;
            this.rbInsects.Location = new System.Drawing.Point(12, 253);
            this.rbInsects.Name = "rbInsects";
            this.rbInsects.Size = new System.Drawing.Size(73, 21);
            this.rbInsects.TabIndex = 5;
            this.rbInsects.TabStop = true;
            this.rbInsects.Text = "Insects";
            this.rbInsects.UseVisualStyleBackColor = true;
            this.rbInsects.CheckedChanged += new System.EventHandler(this.rbInsects_CheckedChanged);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(244, 43);
            this.tbAge.Multiline = true;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(157, 37);
            this.tbAge.TabIndex = 6;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(244, 136);
            this.tbWeight.Multiline = true;
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(157, 37);
            this.tbWeight.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(570, 43);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(157, 37);
            this.tbName.TabIndex = 8;
            
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(570, 215);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(110, 21);
            this.radioButton7.TabIndex = 9;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(570, 253);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(110, 21);
            this.radioButton8.TabIndex = 10;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(580, 383);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(136, 40);
            this.btOk.TabIndex = 12;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // lbAnimal
            // 
            this.lbAnimal.AutoSize = true;
            this.lbAnimal.Location = new System.Drawing.Point(12, 24);
            this.lbAnimal.Name = "lbAnimal";
            this.lbAnimal.Size = new System.Drawing.Size(54, 17);
            this.lbAnimal.TabIndex = 13;
            this.lbAnimal.Text = "Animal:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(241, 9);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(37, 17);
            this.lbAge.TabIndex = 14;
            this.lbAge.Text = "Age:";

            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(241, 104);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 17);
            this.lbWeight.TabIndex = 15;
            this.lbWeight.Text = "Weight:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(567, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 17);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Weight";
            // 
            // lbHabitat
            // 
            this.lbHabitat.AutoSize = true;
            this.lbHabitat.Location = new System.Drawing.Point(241, 206);
            this.lbHabitat.Name = "lbHabitat";
            this.lbHabitat.Size = new System.Drawing.Size(57, 17);
            this.lbHabitat.TabIndex = 18;
            this.lbHabitat.Text = "Habitat:";
            // 
            // tbHabitat
            // 
            this.tbHabitat.Location = new System.Drawing.Point(244, 253);
            this.tbHabitat.Multiline = true;
            this.tbHabitat.Name = "tbHabitat";
            this.tbHabitat.Size = new System.Drawing.Size(157, 37);
            this.tbHabitat.TabIndex = 19;
            // 
            // tbExtra
            // 
            this.tbExtra.Location = new System.Drawing.Point(244, 364);
            this.tbExtra.Multiline = true;
            this.tbExtra.Name = "tbExtra";
            this.tbExtra.Size = new System.Drawing.Size(157, 37);
            this.tbExtra.TabIndex = 20;
            // 
            // lbExtra
            // 
            this.lbExtra.AutoSize = true;
            this.lbExtra.Location = new System.Drawing.Point(241, 333);
            this.lbExtra.Name = "lbExtra";
            this.lbExtra.Size = new System.Drawing.Size(57, 17);
            this.lbExtra.TabIndex = 21;
            this.lbExtra.Text = "Habitat:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbExtra);
            this.Controls.Add(this.tbExtra);
            this.Controls.Add(this.tbHabitat);
            this.Controls.Add(this.lbHabitat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbAnimal);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.rbInsects);
            this.Controls.Add(this.rbMammals);
            this.Controls.Add(this.rbAmphibians);
            this.Controls.Add(this.rbReptiles);
            this.Controls.Add(this.rbBirds);
            this.Controls.Add(this.rbFish);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rbFish;
        public System.Windows.Forms.RadioButton rbBirds;
        public System.Windows.Forms.RadioButton rbReptiles;
        public System.Windows.Forms.RadioButton rbAmphibians;
        public System.Windows.Forms.RadioButton rbMammals;
        public System.Windows.Forms.RadioButton rbInsects;
        public System.Windows.Forms.TextBox tbAge;
        public System.Windows.Forms.TextBox tbWeight;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.RadioButton radioButton7;
        public System.Windows.Forms.RadioButton radioButton8;
        public System.Windows.Forms.Button btOk;
        public System.Windows.Forms.Label lbAnimal;
        public System.Windows.Forms.Label lbAge;
        public System.Windows.Forms.Label lbWeight;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbHabitat;
        public System.Windows.Forms.TextBox tbHabitat;
        public System.Windows.Forms.TextBox tbExtra;
        public System.Windows.Forms.Label lbExtra;
    }
}