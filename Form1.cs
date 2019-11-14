using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slomorje_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TempText.Text = WeatherData.Temp();
            WindText.Text = WeatherData.Wind();
            WsizeText.Text = WeatherData.SeaW();
            TempSeaPText.Text = WeatherData.SeaTP();
            TempSeaB1Text.Text = WeatherData.SeaTG1();
            TempSeaB2Text.Text = WeatherData.SeaTG2();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WeatherData.RefreshData();
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TempText.Text = WeatherData.Temp();
            WindText.Text = WeatherData.Wind();
            WsizeText.Text = WeatherData.SeaW();
            TempSeaPText.Text = WeatherData.SeaTP();
            TempSeaB1Text.Text = WeatherData.SeaTG1();
            TempSeaB2Text.Text = WeatherData.SeaTG2();
        }
    }
}
