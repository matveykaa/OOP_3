using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Insects: Animal
    {
        public int Eyes;


        public Insects()
        {
            this.Type = "Insects";
        }

        public override void ShowInList(DataGridView dgv)
        {
            // base.ShowInList(dgv);
            dgv.Rows.Add(this.Type, this.Name, this.Age, this.Weight, this.Habitat, "", "", "", "", Eyes, "");
        }
        


        public override void ShowForEditEdition(Form2 Form2)
        {
            Form2.tbAge.Text = Convert.ToString(this.Age);
            Form2.tbWeight.Text = Convert.ToString(this.Weight);
            Form2.tbHabitat.Text = this.Habitat;
            Form2.tbName.Text = this.Name;
            Form2.lbExtra.Visible = true;
            Form2.tbExtra.Visible = true;
            Form2.lbExtra.Text = "Amount of eyes:";
            Form2.tbExtra.Text = Convert.ToString(this.Eyes);
            Form2.label5.Visible = false;
            Form2.radioButton7.Visible = false;
            Form2.radioButton8.Visible = false;
        }


        public override void Edit(Form2 Form2)
        {
            this.Name = Form2.tbName.Text;
            this.Habitat = Form2.tbHabitat.Text;
            this.Age = Convert.ToInt32(Form2.tbAge.Text);
            this.Weight = Convert.ToInt32(Form2.tbWeight.Text);
            this.Eyes = Convert.ToInt32(Form2.tbExtra.Text);

        }
    }
}
