
namespace piramidodevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // OpenGlControl
            // 
            this.OpenGlControl.AccumBits = ((byte)(0));
            this.OpenGlControl.AutoCheckErrors = false;
            this.OpenGlControl.AutoFinish = false;
            this.OpenGlControl.AutoMakeCurrent = true;
            this.OpenGlControl.AutoSwapBuffers = true;
            this.OpenGlControl.BackColor = System.Drawing.Color.Black;
            this.OpenGlControl.ColorBits = ((byte)(32));
            this.OpenGlControl.DepthBits = ((byte)(16));
            this.OpenGlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenGlControl.Location = new System.Drawing.Point(0, 0);
            this.OpenGlControl.Name = "OpenGlControl";
            this.OpenGlControl.Size = new System.Drawing.Size(412, 451);
            this.OpenGlControl.StencilBits = ((byte)(0));
            this.OpenGlControl.TabIndex = 0;
            this.OpenGlControl.Load += new System.EventHandler(this.OpenGlControl_Load_1);
            this.OpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPaint);
            this.OpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 451);
            this.Controls.Add(this.OpenGlControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl;
    }
}

