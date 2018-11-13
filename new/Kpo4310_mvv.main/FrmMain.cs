
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
//dependency  
using Kpo4310.mvv.main.source;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kpo4310.mvv.main
{
  
    public partial class FrmMain : Form
    {
        private IElementaryParticlesFactory factory = null;
        public FrmMain()
        {
            InitializeComponent();
            factory = AppGlobalSettings.factory;

        }

        private List <elementaryParticle> elementaryParticle = null;
        private BindingSource bselementaryParticles = new BindingSource();
        public string logParam = AppGlobalSettings.Log;
        public string dataParam = AppGlobalSettings.DataFile;
        public string nameFile = AppGlobalSettings.nameFile;

        private void FrmMain_Load(object sender, EventArgs e)
        {
             
            this.param1.Text = Convert.ToString(logParam);
            this.param2.Text = Convert.ToString(dataParam);
             
        }

        private void mmFile_Click(object sender, EventArgs e)
        {

        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public List<string> names = new List<string>();
        public static string nameChecker()
        {
            FrmMain z = new FrmMain();
            FileStream fstream = new FileStream(@"C:\Users\Vitalia\Desktop\4\charge.txt", FileMode.OpenOrCreate);
            ElementaryParticleListTestLoader x = new ElementaryParticleListTestLoader();
            x.Execute();
            
            foreach (var elementaryParticle in x.elementaryParticleList)
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(elementaryParticle.name + Environment.NewLine);
                fstream.Write(array, 0, array.Length);
                z.names.Add(elementaryParticle.name);
            }
            var message = string.Join(Environment.NewLine, z.names);
            MessageBox.Show(message);
            return message;
        }


        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            { 
                IElementaryParticlesListLoader loader = factory.CreateElementaryParticlesListLoader();
                loader.Execute();
                nameChecker();
                dgvelementaryParticles.DataSource = loader.elementaryParticleList;
                
                elementaryParticle = loader.elementaryParticleList;
                bselementaryParticles.DataSource = elementaryParticle;
                dgvelementaryParticles.DataSource = bselementaryParticles;
                 

                if (elementaryParticle == null)
                {
                    mnOpenelementaryParticle.Visible = false;
                } 
            }
            catch (NotImplementedException ex)
            { 
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }
        private void mnOpenelementaryParticle_Click(object sender, EventArgs e)
        { 
            try { 

                FrmelementaryParticle frmelementaryParticle = new FrmelementaryParticle(); 
                elementaryParticle elementaryParticle = (bselementaryParticles.Current as elementaryParticle);
                if (elementaryParticle == null)
                {
                    mnOpenelementaryParticle.Visible = false;
                    throw new MyException("list is empty");
                }
                else
                {
                    frmelementaryParticle.setSomeParticle(elementaryParticle);
                    frmelementaryParticle.ShowDialog();
                }
            }
            catch (MyException exx)
            {
                DateTime localDate = DateTime.Now;
                MessageBox.Show("Ошибка: " + exx.Message);
                LogUtility.ErrorLog(localDate.ToString() +" " + exx.Message + Environment.NewLine);
            }
            catch(Exception basicex)
            {
                DateTime localDate = DateTime.Now;
                MessageBox.Show("Ошибка: " + basicex.Message);
                LogUtility.ErrorLog(localDate.ToString() + " " + basicex.Message + Environment.NewLine);
            }
        }

        private void открытьMockToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            //ClientMethod(new ElementaryParticlesTestFactory());
           // ClientMethod();
            if (elementaryParticle == null)
                {
                    mnOpenelementaryParticle.Visible = false;
                }
            
        } 
        

        private void saveToFile_Click(object sender, EventArgs e)
         {
            try
            {
                IElementaryParticlesListSaver saver = factory.CreateElementaryParticlesListSaver();
                saver.Save();
                //checking if error.log exists
                //dependency 
               // UnitTestProject x = new UnitTestProject();
                //x.TestMethod2();
                if (elementaryParticle != null)
                {
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("nothing to save");
                }
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
            //UnitTestAssertException//AssertFailedException
            catch (UnitTestAssertException ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                // LogUtility.ErrorLog(ex.Message);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №3: " + ex.Message);
                // LogUtility.ErrorLog(ex.Message);
            }
        }

        private void saveMock_Click(object sender, EventArgs e)
        { 
        }
  
    }
} 