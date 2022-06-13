using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Animal
    {
     
        public int Age;
        public string Habitat;
        public int Weight;
        public string Name;
        public string Type;

        public virtual void ShowInList(DataGridView dgv)
        {

        }
        public virtual void ShowForEditEdition(Form2 Form2)
        {

        }
        public virtual void Edit(Form2 Form2)
        {

        }
    }
}
