using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public static bool Adding;

        public static bool GetAdd { set { } get { return Adding; } }

        public delegate void Add(Animal animal);
        public delegate void Edit(Animal animal);

        public Add add1;
        public Edit edit1;


        public int index;
        public List<Animal> listAnimal = new List<Animal>();
        public Animal animal = new Animal();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Owner = this;
            index = dgvAnimal.CurrentRow.Index;
            Form2.rbFish.Visible = false;
            Form2.rbBirds.Visible = false;
            Form2.rbAmphibians.Visible = false;
            Form2.rbReptiles.Visible = false;
            Form2.rbMammals.Visible = false;
            Form2.rbInsects.Visible = false;
            Form2.lbAnimal.Visible = false;
            listAnimal[index].ShowForEditEdition(Form2);
             Adding = false;
            Form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           index = dgvAnimal.CurrentRow.Index;
            listAnimal.RemoveAt(index);
            ShowList(listAnimal);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Owner = this;
            Form2.lbExtra.Visible = true;
            Form2.tbExtra.Visible = true;
            Form2.label5.Visible = false;
            Form2.radioButton7.Visible = false;
            Form2.radioButton8.Visible = false;
            Adding = true;
            Form2.Show();
        }

        private void serialization_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string name;
                FileStream f = new FileStream(saveFD.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(f);
                for (int i = 0; i < listAnimal.Count; i++)
                {
                    writer.WriteLine("Экземпляр класса:" + listAnimal[i].Type);
                    foreach (FieldInfo field in listAnimal[i].GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static
                        | BindingFlags.NonPublic))
                    {
                        string s = field.Name + " "
                            + field.GetValue(listAnimal[i]).ToString();
                        writer.WriteLine(s);
                    }
                    writer.WriteLine("===");
                }
                writer.Close();
                f.Close();
            }
        }

        private void deserialization_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                Deserialization deserialization = Deserialization.GetDeserialization(openFD.FileName);
                List<Animal> newListAnimal = new List<Animal>();
                newListAnimal = deserialization.Deserialize();
                if (newListAnimal != null)
                {
                    listAnimal.Clear();
                    listAnimal = newListAnimal;
                    ShowList(listAnimal);
                }


            }
        }
        public void ShowList(List<Animal> list)
        {
            dgvAnimal.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].ShowInList(dgvAnimal);
            }
        }
    }
}
