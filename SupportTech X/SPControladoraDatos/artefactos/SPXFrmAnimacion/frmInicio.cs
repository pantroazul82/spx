using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;
using System.Windows.Media.Media3D;
using System.Windows.Controls;
using System.Windows.Markup;
using SPControladoraDatos.artefactos;

namespace SPXFrmAnimacion
{
    public partial class frmInicio : Form
    {
        public string xaml = "";

        Viewport3D viewport1 = null;
        ContentControl contentControl = null;
        int timerInterval = 2;

        bool startedApp = false;
        public bool endedSplash = false;


        private double fadeInTime = 800;//tiempo en ponerse visible
        private double startAppTime = 1100;
        private double holdTime = 950;
        private double fadeOutTime = 1200;

        double elapsedTicks = 0;



        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            ajustar objFormResizer = new ajustar();
            objFormResizer.ResizeForm(this, Height, Width);
           
               

        }

    

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }


        


    }

}