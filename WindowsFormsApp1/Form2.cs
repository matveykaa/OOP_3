using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rbFish_CheckedChanged(object sender, EventArgs e)
        {
            Fish fish = new Fish();
            Form1 Form1 = (Form1)this.Owner;
            Form1.animal = fish;
            Animal printedEdition = Form1.animal;
            btOk.Visible = true;
            lbExtra.Visible = true;
            lbExtra.Text = "Deep:";
            tbExtra.Visible = true;
            label5.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            Form1.add1 = animal =>
            {
                AddFish(fish);
            };
        }
        private void AddFish(Fish fish)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "") throw new Exception();
            fish.Name = tbName.Text;
            fish.Weight = Convert.ToInt32(tbWeight.Text);
            fish.Deep = Convert.ToInt32(tbExtra.Text);
            fish.Age = Convert.ToInt32(tbAge.Text);
            fish.Habitat = tbHabitat.Text;
            Form1.listAnimal.Add(fish);
        }

        private void rbBirds_CheckedChanged(object sender, EventArgs e)
        {
            Birds birds = new Birds();
            Form1 Form1 = (Form1)this.Owner;
            Form1.animal = birds;
            Animal printedEdition = Form1.animal;
            btOk.Visible = true;
            lbExtra.Visible = false;
            tbExtra.Visible = false;
            label5.Visible = true;
            label5.Text = "Flying";
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton7.Text = "Can fly";
            radioButton8.Text = "Can't fly";
            Form1.add1 = animal =>
            {
                AddBirds(birds);
            };
        }

        private void AddBirds(Birds birds)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "") throw new Exception();
            birds.Name = tbName.Text;
            birds.Weight = Convert.ToInt32(tbWeight.Text);
            if (radioButton8.Checked) { birds.Fly = false; }
            else { birds.Fly = true; }
            birds.Age = Convert.ToInt32(tbAge.Text);
            birds.Habitat = tbHabitat.Text;
            Form1.listAnimal.Add(birds);
        }

        private void rbReptiles_CheckedChanged(object sender, EventArgs e)
        {
            Reptiles reptiles = new Reptiles();
            Form1 Form1 = (Form1)this.Owner;
            Form1.animal = reptiles;
            Animal printedEdition = Form1.animal;
            btOk.Visible = true;
            lbExtra.Visible = false;
            tbExtra.Visible = false;
            label5.Visible = true;
            label5.Text = "Type of eating";
            radioButton7.Text = "Herbivore";
            radioButton8.Text = "Predator";
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            Form1.add1 = animal =>
            {
                AddReptiles(reptiles);
            };
        }

        private void AddReptiles(Reptiles reptiles)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "") throw new Exception();
            reptiles.Name = tbName.Text;
            reptiles.Weight = Convert.ToInt32(tbWeight.Text);
            if (radioButton8.Checked) { reptiles.Eat = false; }
            else { reptiles.Eat = true; }
            reptiles.Age = Convert.ToInt32(tbAge.Text);
            reptiles.Habitat = tbHabitat.Text;

            Form1.listAnimal.Add(reptiles);
        }

        private void rbAmphibians_CheckedChanged(object sender, EventArgs e)
        {
            Amphibians amphibians = new Amphibians();
            Form1 Form1 = (Form1)this.Owner;
            Form1.animal = amphibians;
            Animal printedEdition = Form1.animal;
            btOk.Visible = true;
            lbExtra.Visible = true;
            lbExtra.Text = "Amount of legs:";
            tbExtra.Visible = true;
            label5.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            Form1.add1 = animal =>
            {
                AddAmphibians(amphibians);
            };
        }
        private void AddAmphibians(Amphibians amphibians)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "") throw new Exception();
            amphibians.Name = tbName.Text;
            amphibians.Weight = Convert.ToInt32(tbWeight.Text);
            amphibians.Legs = Convert.ToInt32(tbExtra.Text);
            amphibians.Age = Convert.ToInt32(tbAge.Text);
            amphibians.Habitat = tbHabitat.Text;
            Form1.listAnimal.Add(amphibians);
        }

        private void rbMammals_CheckedChanged(object sender, EventArgs e)
        {
            Mammals mammals = new Mammals();
            Form1 Form1 = (Form1)this.Owner;
            Form1.animal = mammals;
            Animal printedEdition = Form1.animal;
            btOk.Visible = true;
            lbExtra.Visible = false;
            tbExtra.Visible = false;
            label5.Visible = true;
            label5.Text = "Type of living";
            radioButton7.Text = "Pet";
            radioButton8.Text = "Wild";
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            Form1.add1 = animal =>
            {
                AddMammals(mammals);
            };
        }

        private void AddMammals(Mammals mammals)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "") throw new Exception();
            mammals.Name = tbName.Text;
            mammals.Weight = Convert.ToInt32(tbWeight.Text);
            if (radioButton8.Checked) { mammals.Home = false; }
            else { mammals.Home = true; }
            mammals.Age = Convert.ToInt32(tbAge.Text);
            mammals.Habitat = tbHabitat.Text;

            Form1.listAnimal.Add(mammals);
        }

        private void rbInsects_CheckedChanged(object sender, EventArgs e)
        {
            Insects insects = new Insects();
            Form1 Form1 = (Form1)this.Owner;
            Form1.animal = insects;
            Animal printedEdition = Form1.animal;
            btOk.Visible = true;
            lbExtra.Visible = true;
            lbExtra.Text = "Amount of eyes:";
            tbExtra.Visible = true;
            label5.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            Form1.add1 = animal =>
            {
                AddInsects(insects);
            };
        }
        private void AddInsects(Insects insects)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "") throw new Exception();
            insects.Name = tbName.Text;
            insects.Weight = Convert.ToInt32(tbWeight.Text);
            insects.Eyes = Convert.ToInt32(tbExtra.Text);
            insects.Age = Convert.ToInt32(tbAge.Text);
            insects.Habitat = tbHabitat.Text;
            Form1.listAnimal.Add(insects);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (Form1.GetAdd)
            {
                try
                {
                    Form1 Form1 = (Form1)this.Owner;
                    Animal animal = Form1.animal;
                    Form1.add1(animal);
                    Form1.ShowList(Form1.listAnimal);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Fields're filled incorrectly!");
                }

            }
            else
            {
                try
                {
                    Form1 Form1 = (Form1)this.Owner;
                    Form1.listAnimal[Form1.index].Edit(this);
                    Form1.ShowList(Form1.listAnimal);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Fields're filled incorrectly!");
                }

            }
        }

       
    }
}
