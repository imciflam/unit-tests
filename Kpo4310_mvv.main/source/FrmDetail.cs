using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4310.mvv.Lib;
using Kpo4310.mvv.main.source;

namespace Kpo4310.mvv.main.source
{
    public partial class FrmelementaryParticle : Form
    {

        private elementaryParticle _elementaryParticle = null;
        public FrmelementaryParticle()
        {
            InitializeComponent(); 

        } 

        public elementaryParticle elementaryParticle
        {
            get { return _elementaryParticle; }
        }



       // private void FrmelementaryParticle_Load(object sender, EventArgs e)
         

        //private void txtboxName_TextChanged(object sender, EventArgs e)
        

        /*private void setParticle_Click(object sender, EventArgs e)
        {
            elementaryParticle elementaryParticle = new elementaryParticle()
            //инициализировать скрытое поля класса 
            //присвоить значение данных сотрудника элементам редактирования
            {
                name = this.txtboxName.Text,
                group = this.textBoxGroup.Text,
                charge = this.textBoxCharge.Text,
                weight  = 1 
            };
             
            MessageBox.Show("Added"); 
        }*/

        public void setSomeParticle(elementaryParticle elementaryParticle)
        {
            this._elementaryParticle = elementaryParticle;
            this.txtboxName.Text = Convert.ToString(_elementaryParticle.name);
            this.textBoxGroup.Text = Convert.ToString(_elementaryParticle.group);
            this.textBoxCharge.Text = Convert.ToString(_elementaryParticle.charge);
            this.textBoxWeight.Text = Convert.ToString(_elementaryParticle.weight);

        }
        //private void setParticle_Click_1(object sender, EventArgs e)
        
    }
}
