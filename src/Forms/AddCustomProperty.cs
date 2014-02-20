using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text.RegularExpressions;

namespace GLEED2D
{
    public partial class AddCustomProperty : Form
    {
        public CustomProperty cp = new CustomProperty();

        SerializableDictionary customproperties;


        public AddCustomProperty(SerializableDictionary currentproperties)
        {
            InitializeComponent();
            customproperties = currentproperties;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length==0)
            {
                MessageBox.Show("Please enter a Property Name.");
                return;
            }

            //CustomProperty cp = new CustomProperty();
            cp.name = textBox1.Text;
            cp.description = textBox2.Text;
            if (radioButton1.Checked)
            {
                cp.type = typeof(string);
                cp.value = txbFreetext.Text;
            }
            if (radioButton2.Checked)
            { 
                cp.type = typeof(bool);
                cp.value = cbbBoolean.SelectedItem.ToString().Equals("true");
            }
            if (radioButton3.Checked)
            {
                cp.type = typeof(Vector2);
                Regex r=new Regex(@"^\d+(\.)?\d*$");
                if(r.IsMatch(txbX.Text)&&r.IsMatch(txbY.Text))
                {
                    float x=float.Parse(txbX.Text); 
                    float y=float.Parse(txbY.Text);
                    cp.value = new Vector2(x,y);
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric value.");
                    return;
                }
                
            }
            if (radioButton4.Checked)
            {
                cp.type = typeof(Color);
                byte R = byte.Parse(numUDR.Value.ToString());
                byte G = byte.Parse(numUDG.Value.ToString());
                byte B = byte.Parse(numUDB.Value.ToString());
                cp.value =new Color(R,G,B);
            }
            if (radioButton5.Checked)
            {
                cp.type = typeof(Item);
                cp.value = null;
            }
            if (cbxAddToAllSelected.Checked)//add to all selected items
            {
                foreach (Item item in Editor.Instance.SelectedItems)
                {
                    if (cbxAddMode.Checked)
                    {
                        item.CustomProperties[cp.name] = cp.clone();
                    }
                    else
                    {
                        if (item.CustomProperties.ContainsKey(cp.name)==false)
                        {
                            item.CustomProperties[cp.name] = cp.clone();
                        }
                    }
                }
            }
            else//add to selected
            {
                if (customproperties.ContainsKey(textBox1.Text))
                {
                    MessageBox.Show("A Custom Property with that name already exists.");
                    return;
                }
                customproperties[cp.name] = cp;
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomProperty_Load(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // 将先中的颜色设置为窗体的背景色
                btnColor.BackColor = colorDialog1.Color;
                numUDR.Value = btnColor.BackColor.R;
                numUDG.Value = btnColor.BackColor.G;
                numUDB.Value = btnColor.BackColor.B;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            cp.type = typeof(Color);
            btnColor.BackColor = System.Drawing.Color.FromArgb(byte.Parse(numUDR.Value.ToString()),byte.Parse(numUDG.Value.ToString()),byte.Parse( numUDB.Value.ToString()));
        }

        private void cbxAddToAllSelected_CheckedChanged(object sender, EventArgs e)
        {
            cbxAddMode.Enabled = cbxAddToAllSelected.Checked;
        }


    }
}
