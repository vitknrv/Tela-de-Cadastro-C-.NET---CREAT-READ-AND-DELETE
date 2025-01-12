namespace AvaliaçãoEstestica
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cadmodelo = new Button();
            label1 = new Label();
            excmodelo = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // cadmodelo
            // 
            cadmodelo.BackColor = Color.IndianRed;
            cadmodelo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cadmodelo.Location = new Point(427, 121);
            cadmodelo.Name = "cadmodelo";
            cadmodelo.Size = new Size(271, 74);
            cadmodelo.TabIndex = 0;
            cadmodelo.Text = "Clique aqui para cadastrar modelo.";
            cadmodelo.UseVisualStyleBackColor = false;
            cadmodelo.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(267, 26);
            label1.Name = "label1";
            label1.Size = new Size(277, 47);
            label1.TabIndex = 2;
            label1.Text = "ESTÉTICA SENAC";
            // 
            // excmodelo
            // 
            excmodelo.BackColor = Color.IndianRed;
            excmodelo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            excmodelo.Location = new Point(427, 221);
            excmodelo.Name = "excmodelo";
            excmodelo.Size = new Size(271, 70);
            excmodelo.TabIndex = 3;
            excmodelo.Text = "Clique aqui para excluir modelo.";
            excmodelo.UseVisualStyleBackColor = false;
            excmodelo.Click += excmodelo_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(427, 325);
            button1.Name = "button1";
            button1.Size = new Size(271, 71);
            button1.TabIndex = 4;
            button1.Text = "Clique aqui para buscar modelo.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(110, 121);
            button2.Name = "button2";
            button2.Size = new Size(271, 70);
            button2.TabIndex = 5;
            button2.Text = "Clique aqui para cadastrar um Esteticista.";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(110, 327);
            button3.Name = "button3";
            button3.Size = new Size(271, 70);
            button3.TabIndex = 6;
            button3.Text = "Clique aqui para buscar um Esteticista.";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(110, 223);
            button4.Name = "button4";
            button4.Size = new Size(271, 70);
            button4.TabIndex = 7;
            button4.Text = "Clique aqui para excluir um Esteticista.";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(excmodelo);
            Controls.Add(label1);
            Controls.Add(cadmodelo);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadmodelo;
        private Label label1;
        private Button excmodelo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}