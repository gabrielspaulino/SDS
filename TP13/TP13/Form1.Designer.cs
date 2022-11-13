
namespace TP13
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
            this.buttonLer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSerializar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLer
            // 
            this.buttonLer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLer.Location = new System.Drawing.Point(238, 59);
            this.buttonLer.Name = "buttonLer";
            this.buttonLer.Size = new System.Drawing.Size(139, 30);
            this.buttonLer.TabIndex = 0;
            this.buttonLer.Text = "Ler arquivo XML";
            this.buttonLer.UseVisualStyleBackColor = true;
            this.buttonLer.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(560, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonSerializar
            // 
            this.buttonSerializar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSerializar.Location = new System.Drawing.Point(383, 59);
            this.buttonSerializar.Name = "buttonSerializar";
            this.buttonSerializar.Size = new System.Drawing.Size(139, 30);
            this.buttonSerializar.TabIndex = 2;
            this.buttonSerializar.Text = "Serializar";
            this.buttonSerializar.UseVisualStyleBackColor = true;
            this.buttonSerializar.Click += new System.EventHandler(this.buttonSerializar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSerializar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSerializar;
    }
}

