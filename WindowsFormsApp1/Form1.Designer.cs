
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.serialization = new System.Windows.Forms.Button();
            this.deserialization = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.clmn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_habitat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_deep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_eat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_fly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_legs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_eyes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_live = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.serialization);
            this.panel1.Controls.Add(this.deserialization);
            this.panel1.Controls.Add(this.add);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 100);
            this.panel1.TabIndex = 0;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(192, 21);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(131, 46);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(367, 21);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(131, 46);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // serialization
            // 
            this.serialization.Location = new System.Drawing.Point(1016, 26);
            this.serialization.Name = "serialization";
            this.serialization.Size = new System.Drawing.Size(131, 46);
            this.serialization.TabIndex = 3;
            this.serialization.Text = "Serialization";
            this.serialization.UseVisualStyleBackColor = true;
            this.serialization.Click += new System.EventHandler(this.serialization_Click);
            // 
            // deserialization
            // 
            this.deserialization.Location = new System.Drawing.Point(1205, 26);
            this.deserialization.Name = "deserialization";
            this.deserialization.Size = new System.Drawing.Size(131, 46);
            this.deserialization.TabIndex = 4;
            this.deserialization.Text = "Deserialization";
            this.deserialization.UseVisualStyleBackColor = true;
            this.deserialization.Click += new System.EventHandler(this.deserialization_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(23, 24);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 41);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_name,
            this.clmn_type,
            this.clmn_age,
            this.clmn_weight,
            this.clmn_habitat,
            this.clmn_deep,
            this.clmn_eat,
            this.clmn_fly,
            this.clmn_legs,
            this.clmn_eyes,
            this.clmn_live});
            this.dgvAnimal.Location = new System.Drawing.Point(0, 97);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.RowHeadersWidth = 51;
            this.dgvAnimal.RowTemplate.Height = 24;
            this.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimal.Size = new System.Drawing.Size(1458, 606);
            this.dgvAnimal.TabIndex = 1;
            // 
            // clmn_name
            // 
            this.clmn_name.HeaderText = "Name";
            this.clmn_name.MinimumWidth = 6;
            this.clmn_name.Name = "clmn_name";
            // 
            // clmn_type
            // 
            this.clmn_type.HeaderText = "Type";
            this.clmn_type.MinimumWidth = 6;
            this.clmn_type.Name = "clmn_type";
            // 
            // clmn_age
            // 
            this.clmn_age.HeaderText = "Age";
            this.clmn_age.MinimumWidth = 6;
            this.clmn_age.Name = "clmn_age";
            // 
            // clmn_weight
            // 
            this.clmn_weight.HeaderText = "Weight";
            this.clmn_weight.MinimumWidth = 6;
            this.clmn_weight.Name = "clmn_weight";
            // 
            // clmn_habitat
            // 
            this.clmn_habitat.HeaderText = "Habitat";
            this.clmn_habitat.MinimumWidth = 6;
            this.clmn_habitat.Name = "clmn_habitat";
            // 
            // clmn_deep
            // 
            this.clmn_deep.HeaderText = "Deep";
            this.clmn_deep.MinimumWidth = 6;
            this.clmn_deep.Name = "clmn_deep";
            // 
            // clmn_eat
            // 
            this.clmn_eat.HeaderText = "Type of eat";
            this.clmn_eat.MinimumWidth = 6;
            this.clmn_eat.Name = "clmn_eat";
            // 
            // clmn_fly
            // 
            this.clmn_fly.HeaderText = "Type of flying";
            this.clmn_fly.MinimumWidth = 6;
            this.clmn_fly.Name = "clmn_fly";
            // 
            // clmn_legs
            // 
            this.clmn_legs.HeaderText = "Amount of legs";
            this.clmn_legs.MinimumWidth = 6;
            this.clmn_legs.Name = "clmn_legs";
            // 
            // clmn_eyes
            // 
            this.clmn_eyes.HeaderText = "Amount of eyes";
            this.clmn_eyes.MinimumWidth = 6;
            this.clmn_eyes.Name = "clmn_eyes";
            // 
            // clmn_live
            // 
            this.clmn_live.HeaderText = "Type of living";
            this.clmn_live.MinimumWidth = 6;
            this.clmn_live.Name = "clmn_live";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 704);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button serialization;
        private System.Windows.Forms.Button deserialization;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_habitat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_deep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_eat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_fly;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_legs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_eyes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_live;
    }
}

