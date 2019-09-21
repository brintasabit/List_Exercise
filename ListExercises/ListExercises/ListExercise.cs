using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListExercises
{
    public partial class ListExercise : Form
    {
        List<int> lists = new List<int>();
        List<int> rlists = new List<int>();
        public ListExercise()
        {
            InitializeComponent();
        }

        private void listAddButton_Click(object sender, EventArgs e)
        {
            
            
            
                lists.Add(Convert.ToInt32( listTextBox.Text));
                
            
            //MessageBox.Show("Element Added");
            listTextBox.Text = "";
        }

        private void showListButton_Click(object sender, EventArgs e)
        {
            string see = "";
            for (int i = 0; i < lists.Count(); i++)
            {
                see += "Entered Elements: " + lists[i]+"\n";
            }
            MessageBox.Show(see);
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string see = "";
            for (int i = lists.Count()-1; i >=0 ; i--)
            {
                see += "Entered Elements: " + lists[i] + "\n";
            }
            MessageBox.Show(see);
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
           int sum = lists.Sum();
           string s = Convert.ToString(sum);
           MessageBox.Show(s);
        }

        private void list2Button_Click(object sender, EventArgs e)
        {
            rlists = lists;
            string see = "";
            for (int i = 0; i<rlists.Count(); i++)
            {
                see += "Entered Elements: " + rlists[i] + "\n";
            }
            MessageBox.Show(see);
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            int max = lists.Max();
            string m = Convert.ToString(max);
            MessageBox.Show(m);
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            int min = lists.Min();
            string m = Convert.ToString(min);
            MessageBox.Show(m);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
           /* for (int i = 0; i < lists.Count(); i++)
            {
                for(int j=i+1;j<lists.Count();j++)
                {
                    rlists = lists;
                    lists[i] = lists[j];
                    lists[j] = rlists[j];

                }
            }
            string see = "";
            for (int i = 0; i < rlists.Count(); i++)
            {
                see += rlists[i];
            }
            MessageBox.Show(see);*/
        }
    }
}
