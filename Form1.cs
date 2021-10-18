using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        class Convert 
        {
            virtual public double FromMeter(double v)       { return v; }
            virtual public double ToMeter(double v)         { return v; }
        
        }


        class Meter : Convert
        {
            public override double FromMeter(double v)      { return v; }
            public override double ToMeter(double v)        { return v; }
        }

        class Feet : Convert
        {
            public override double FromMeter(double v)      { return v * 0.3048; }
            public override double ToMeter(double v)        { return v / 0.3048; }
        }

        class Inch : Convert
        {
            public override double FromMeter(double v)      { return v * 0.0254; }
            public override double ToMeter(double v)        { return v / 0.0254; }
        }

        class Yard : Convert
        {
            public override double FromMeter(double v)      { return v * 0.9144; }
            public override double ToMeter(double v)        { return v / 0.9144; }

        }


        class MyCalcManagement {

            public string fCombo;
            public string sCombo;
          

            public double changeFComboToSCombo(double value) {

                double changeMeter = value;
                Convert formCovert;
                Convert toCovert;


                switch (fCombo) {
                    case "m":
                        formCovert = new Meter();
                        changeMeter = formCovert.ToMeter(value);
                        break;

                    case "feet":
                        formCovert = new Feet();
                        changeMeter = formCovert.ToMeter(value);
                        break;

                    case "inch":
                        formCovert = new Inch();
                        changeMeter = formCovert.ToMeter(value);
                        break;

                    case "yard":
                        formCovert = new Yard();
                        changeMeter = formCovert.ToMeter(value);
                        break;

                    default:
                        MessageBox.Show("", "Error");
                        break;
                        
                }

                switch (sCombo)
                {
                    case "m":
                        toCovert = new Meter();
                        changeMeter = toCovert.FromMeter(changeMeter);
                        return changeMeter;

                    case "feet":
                        toCovert = new Feet();
                        changeMeter = toCovert.FromMeter(changeMeter);
                        return changeMeter;

                    case "inch":
                        toCovert = new Inch();
                        changeMeter = toCovert.FromMeter(changeMeter);
                        return changeMeter;

                    case "yard":
                        toCovert = new Yard();
                        changeMeter = toCovert.FromMeter(changeMeter);
                        return changeMeter;

                    default:
                        return 0;

                }                
                
            }
            
        }

        MyCalcManagement myCalc = new MyCalcManagement();

        public Form1()
        {
            InitializeComponent();
            combo_init();
        }

        // combo init 
        private void combo_init() {

            string[] data = { "m", "feet", "inch", "yard"};

            fisrt_combo.Items.AddRange(data);
            fisrt_combo.SelectedIndexS = 0;

            second_combo.Items.AddRange(data);
            second_combo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;

            if (first_input.Text == "") {
                MessageBox.Show("변환값을 입력해주세요.", "Error");
                return;
            }

            try
            {
                double v = double.Parse(first_input.Text);
                result = myCalc.changeFComboToSCombo(v);
                second_result.Text = string.Format("{0:0.00}", result);
            }
            catch {
                first_input.Text = "";
                second_result.Text = "";
                MessageBox.Show("변환값을 숫자로 입력해주세요.", "Error");
            }

           
        }
        

        private void fisrt_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox fc = sender as ComboBox;
            String selectItem = fc.Items[fc.SelectedIndex].ToString();
            myCalc.fCombo = selectItem;
            first_text.Text = selectItem;
        }

        private void second_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox sc = sender as ComboBox;
            String selectItem = sc.Items[sc.SelectedIndex].ToString();
            myCalc.sCombo = selectItem;
            second_text.Text = selectItem;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
