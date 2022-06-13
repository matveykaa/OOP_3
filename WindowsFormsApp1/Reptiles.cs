using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Reptiles: Animal
    {
        public bool Eat;


        public Reptiles()
        {
            this.Type = "Reptiles";
        }
        public override void ShowInList(DataGridView dgv)
        { 
        string Eatt;
        if (this.Eat)
                       {
            Eatt = "Herbivore";
        }
        else
        {
            Eatt = "Predator";
        }
        dgv.Rows.Add(this.Type, this.Name, this.Age, this.Weight, this.Habitat, "", Eatt, "", "", "", "");

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
            Form2.label5.Text = "Type of eating";
            Form2.radioButton7.Visible = true;
            Form2.radioButton8.Visible = true;
            Form2.radioButton7.Text = "Herbivore";
            Form2.radioButton8.Text = "Predator";
            if (this.Eat)
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
                this.Eat = true;
            }
           else
            {
                this.Eat = false;
            }

        }
    }
}
