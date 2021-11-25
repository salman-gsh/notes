
namespace NotizProgramm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttn_new = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_open = new System.Windows.Forms.Button();
            this.bttn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Arabic", 8.249999F);
            this.label1.Location = new System.Drawing.Point(59, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Arabic", 8.249999F);
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachricht:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Arabic", 8.249999F);
            this.label3.Location = new System.Drawing.Point(490, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liste:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(120, 65);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(248, 20);
            this.tbTitle.TabIndex = 3;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(120, 134);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(248, 202);
            this.tbMessage.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 232);
            this.dataGridView1.TabIndex = 5;
            // 
            // bttn_new
            // 
            this.bttn_new.Location = new System.Drawing.Point(120, 369);
            this.bttn_new.Name = "bttn_new";
            this.bttn_new.Size = new System.Drawing.Size(75, 23);
            this.bttn_new.TabIndex = 6;
            this.bttn_new.Text = "Neu";
            this.bttn_new.UseVisualStyleBackColor = true;
            this.bttn_new.Click += new System.EventHandler(this.bttn_neu_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(293, 369);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 7;
            this.bttn_save.Text = "Speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_open
            // 
            this.bttn_open.Location = new System.Drawing.Point(494, 369);
            this.bttn_open.Name = "bttn_open";
            this.bttn_open.Size = new System.Drawing.Size(75, 23);
            this.bttn_open.TabIndex = 8;
            this.bttn_open.Text = "Öffnen";
            this.bttn_open.UseVisualStyleBackColor = true;
            this.bttn_open.Click += new System.EventHandler(this.bttn_open_Click);
            // 
            // bttn_delete
            // 
            this.bttn_delete.Location = new System.Drawing.Point(659, 369);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(75, 23);
            this.bttn_delete.TabIndex = 9;
            this.bttn_delete.Text = "Löschen";
            this.bttn_delete.UseVisualStyleBackColor = true;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.bttn_delete);
            this.Controls.Add(this.bttn_open);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.bttn_new);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttn_new;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_open;
        private System.Windows.Forms.Button bttn_delete;
    }
}

