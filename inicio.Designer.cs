
namespace estacionamento_2
{
    partial class inicio
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
            this.btnCadas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadas
            // 
            this.btnCadas.BackColor = System.Drawing.Color.Gray;
            this.btnCadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadas.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadas.Location = new System.Drawing.Point(205, 44);
            this.btnCadas.Name = "btnCadas";
            this.btnCadas.Size = new System.Drawing.Size(262, 192);
            this.btnCadas.TabIndex = 0;
            this.btnCadas.Text = "Cadastro";
            this.btnCadas.UseVisualStyleBackColor = false;
            this.btnCadas.Click += new System.EventHandler(this.btnCadas_Click);
            this.btnCadas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCadas_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-Vindo! por onde deseja começar?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Gray;
            this.btnLog.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(205, 246);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(261, 192);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            this.btnLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLog_MouseMove);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadas);
            this.Name = "inicio";
            this.Text = "Inicio";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inicio_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLog;
    }
}