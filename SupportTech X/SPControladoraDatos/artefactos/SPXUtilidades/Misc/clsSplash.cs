using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;


namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc
{
    public delegate void DelegateCloseSplash();

    public class clsSplash: Form
    {
        public static int timeSplash = 3000;
        public static Bitmap imageSplash = SPControladoraDatos.Properties.Resources.logo;

        #region Constructor
        public clsSplash( )
        {
            // ====================================================================================
            // Setup the form
            // ==================================================================================== 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.TopMost = true;

            // make form transparent
            this.TransparencyKey = this.BackColor;

            // tie up the events
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SplashForm_KeyUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SplashForm_Paint);
            this.MouseDown += new MouseEventHandler(SplashForm_MouseClick);

            // load and make the bitmap transparent
            m_bmp = imageSplash;// new Bitmap(@"d:\\splash\logo-Samsung-500x325.png");
            // resize the form to the size of the iamge
            this.Width = m_bmp.Width;
            this.Height = m_bmp.Height;
            //Application.DoEvents();
            Color col = Color.Transparent;// Color.FromArgb(128, 128, 128);
            m_bmp.MakeTransparent(col);
            
            

            // center the form
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // thread handling
            m_delegateClose = new DelegateCloseSplash(InternalCloseSplash);
        }
        #endregion // Constructor

        #region Public methods
        // this can be used for About dialogs
        public static void ShowModal(String imageFile, Color col)
        {
            m_imageFile = imageFile;
            m_transColor = col;
            MySplashThreadFunc();
        }
        // Call this method with the image file path and the color 
        // in the image to be rendered transparent
        public static void StartSplash()
        {
            // Create and Start the splash thread
            Thread InstanceCaller = new Thread(new ThreadStart(MySplashThreadFunc));
            InstanceCaller.Start();
        }

        // Call this at the end of your apps initialization to close the splash screen
        public static void CloseSplash()
        {
            try
            {
                if (m_instance != null)
                    m_instance.Invoke(m_instance.m_delegateClose);
            }catch(Exception){}
        }
        #endregion // Public methods

        #region Dispose
        protected override void Dispose( bool disposing )
        {
            m_bmp.Dispose();
            base.Dispose( disposing );
            m_instance = null;
        }
        #endregion // Dispose

        #region Threading code
        // ultimately this is called for closing the splash window
        void InternalCloseSplash()
        {
            this.Close();
            this.Dispose();
        }
        // this is called by the new thread to show the splash screen
        private static void MySplashThreadFunc()
        {
            m_instance = new clsSplash();
            m_instance.TopMost = false;
            m_instance.ShowDialog();
        }
        #endregion // Multithreading code

        #region Event Handlers

        void SplashForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.InternalCloseSplash();
        }

        private void SplashForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.DrawImage(m_bmp, 0,0);
        }

        private void SplashForm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                this.InternalCloseSplash();
        }
        #endregion // Event Handlers

        #region Private variables
        private static clsSplash m_instance;
        private static String m_imageFile;
        private static Color m_transColor;
        private Bitmap m_bmp;
        private DelegateCloseSplash m_delegateClose;
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // clsSplash
            // 
            this.ClientSize = new System.Drawing.Size(116, 29);
            this.Name = "clsSplash";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);
        }
    }
}
