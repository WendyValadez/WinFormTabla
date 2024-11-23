namespace WinFormTabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            richTextBoxResultado = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.PaleTurquoise;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(richTextBoxResultado);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(697, 403);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultado
            // 
            richTextBoxResultado.BackColor = Color.FromArgb(255, 255, 192);
            richTextBoxResultado.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBoxResultado.Location = new Point(402, 93);
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.Size = new Size(190, 265);
            richTextBoxResultado.TabIndex = 4;
            richTextBoxResultado.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.Yellow;
            buttonVer.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonVer.ForeColor = Color.Black;
            buttonVer.Location = new Point(105, 218);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(196, 41);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "VER TABLA";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNum.Location = new Point(151, 146);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(95, 31);
            textBoxNum.TabIndex = 2;
            textBoxNum.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(63, 96);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(291, 23);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cuál es el tabla que quieres?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(202, 29);
            label1.Name = "label1";
            label1.Size = new Size(293, 38);
            label1.TabIndex = 0;
            label1.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 403);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Wendy Itzel Valadez Herrera ID:302413";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label label1;
        private Label labelNumero;
        private TextBox textBoxNum;
        private Button buttonVer;
        private RichTextBox richTextBoxResultado;
    }
}
