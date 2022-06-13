using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Birds: Animal
    {
        public bool Fly;


        public Birds()
        {
            this.Type = "Birds";
        }
        public override void ShowInList(DataGridView dgv)
        {
            string Flyy;
            if (this.Fly)
            {
                Flyy = "Can fly";
            }
            else
            {
                Flyy = "Can't fly";
            }
            dgv.Rows.Add(this.Type, this.Name, this.Age, this.Weight, this.Habitat, "", "", Flyy, "", "", "");

        }
        public override void ShowForEditEdition(Form2 Form2)
        {
            Form2.tbAge.Text = Convert.ToString(this.Age);
            Form2.tbWeight.Text = Convert.ToString(this.Weight);
            Form2.tbHabitat.Text = this.Habitat;
            Form2.tbName.Text = this.Name;
            Form2.lbExtra.Visible = false;
            Form2.tbExtra.Visible = false;
            Form2.label5.Visible = true;
            Form2.label5.Text = "Flying";
            Form2.radioButton7.Visible = true;
            Form2.radioButton8.Visible = true;
            Form2.radioButton7.Text = "Can fly";
            Form2.radioButton8.Text = "Can't fly";
            if (this.Fly)
            {
                Form2.radioButton7.Checked = true;
            }
            else
            {
                Form2.radioButton8.Checked = true;
            }
        }


        public override void Edit(Form2 Form2)
        {
            this.Name = Form2.tbName.Text;
            this.Habitat = Form2.tbHabitat.Text;
            this.Age = Convert.ToInt32(Form2.tbAge.Text);
            this.Weight = Convert.ToInt32(Form2.tbWeight.Text);
            if (Form2.radioButton7.Checked)
            {
                this.Fly = true;
            }
            else
            {
                this.Fly = false;
            }

        }
    }
}
