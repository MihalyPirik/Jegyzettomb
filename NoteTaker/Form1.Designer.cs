using System.Drawing;

namespace NoteTaker
{
    partial class formJegyzet
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
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUjJegyzet = new System.Windows.Forms.Button();
            this.tbJegyzet = new System.Windows.Forms.TextBox();
            this.dgvAdatok = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cím = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jegyzet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opciók = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.lblJegyzet = new System.Windows.Forms.Label();
            this.lblCim = new System.Windows.Forms.Label();
            this.tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdatok)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tlp1.ColumnCount = 7;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp1.Controls.Add(this.btnUjJegyzet, 5, 1);
            this.tlp1.Controls.Add(this.tbJegyzet, 1, 5);
            this.tlp1.Controls.Add(this.dgvAdatok, 4, 5);
            this.tlp1.Controls.Add(this.tbCim, 1, 3);
            this.tlp1.Controls.Add(this.btnBetoltes, 4, 1);
            this.tlp1.Controls.Add(this.btnTorles, 5, 3);
            this.tlp1.Controls.Add(this.btnMentes, 4, 3);
            this.tlp1.Controls.Add(this.lblJegyzet, 1, 4);
            this.tlp1.Controls.Add(this.lblCim, 1, 2);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 7;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp1.Size = new System.Drawing.Size(982, 753);
            this.tlp1.TabIndex = 0;
            // 
            // btnUjJegyzet
            // 
            this.btnUjJegyzet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUjJegyzet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUjJegyzet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjJegyzet.Location = new System.Drawing.Point(719, 18);
            this.btnUjJegyzet.Name = "btnUjJegyzet";
            this.tlp1.SetRowSpan(this.btnUjJegyzet, 2);
            this.btnUjJegyzet.Size = new System.Drawing.Size(210, 91);
            this.btnUjJegyzet.TabIndex = 6;
            this.btnUjJegyzet.Text = "Új jegyzet";
            this.btnUjJegyzet.UseVisualStyleBackColor = false;
            this.btnUjJegyzet.Click += new System.EventHandler(this.btnUjJegyzet_Click);
            // 
            // tbJegyzet
            // 
            this.tbJegyzet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlp1.SetColumnSpan(this.tbJegyzet, 2);
            this.tbJegyzet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbJegyzet.Location = new System.Drawing.Point(52, 212);
            this.tbJegyzet.Multiline = true;
            this.tbJegyzet.Name = "tbJegyzet";
            this.tbJegyzet.Size = new System.Drawing.Size(426, 521);
            this.tbJegyzet.TabIndex = 2;
            // 
            // dgvAdatok
            // 
            this.dgvAdatok.AllowUserToAddRows = false;
            this.dgvAdatok.AllowUserToDeleteRows = false;
            this.dgvAdatok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdatok.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cím,
            this.Jegyzet,
            this.Opciók});
            this.tlp1.SetColumnSpan(this.dgvAdatok, 2);
            this.dgvAdatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdatok.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAdatok.Location = new System.Drawing.Point(503, 212);
            this.dgvAdatok.Name = "dgvAdatok";
            this.dgvAdatok.ReadOnly = true;
            this.dgvAdatok.RowHeadersWidth = 51;
            this.dgvAdatok.RowTemplate.Height = 24;
            this.dgvAdatok.Size = new System.Drawing.Size(426, 521);
            this.dgvAdatok.TabIndex = 7;
            this.dgvAdatok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdatok_CellContentClick);
            this.dgvAdatok.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdatok_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Cím
            // 
            this.Cím.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cím.HeaderText = "Cím";
            this.Cím.MinimumWidth = 6;
            this.Cím.Name = "Cím";
            this.Cím.ReadOnly = true;
            // 
            // Jegyzet
            // 
            this.Jegyzet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jegyzet.HeaderText = "Jegyzet";
            this.Jegyzet.MinimumWidth = 6;
            this.Jegyzet.Name = "Jegyzet";
            this.Jegyzet.ReadOnly = true;
            // 
            // Opciók
            // 
            this.Opciók.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opciók.HeaderText = "Opciók";
            this.Opciók.MinimumWidth = 6;
            this.Opciók.Name = "Opciók";
            this.Opciók.ReadOnly = true;
            // 
            // tbCim
            // 
            this.tbCim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlp1.SetColumnSpan(this.tbCim, 2);
            this.tbCim.Location = new System.Drawing.Point(52, 115);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(426, 22);
            this.tbCim.TabIndex = 1;
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBetoltes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBetoltes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBetoltes.ForeColor = System.Drawing.Color.Black;
            this.btnBetoltes.Location = new System.Drawing.Point(503, 18);
            this.btnBetoltes.Name = "btnBetoltes";
            this.tlp1.SetRowSpan(this.btnBetoltes, 2);
            this.btnBetoltes.Size = new System.Drawing.Size(210, 91);
            this.btnBetoltes.TabIndex = 5;
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.UseVisualStyleBackColor = false;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTorles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTorles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorles.Location = new System.Drawing.Point(719, 115);
            this.btnTorles.Name = "btnTorles";
            this.tlp1.SetRowSpan(this.btnTorles, 2);
            this.btnTorles.Size = new System.Drawing.Size(210, 91);
            this.btnTorles.TabIndex = 4;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = false;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMentes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentes.Location = new System.Drawing.Point(503, 115);
            this.btnMentes.Name = "btnMentes";
            this.tlp1.SetRowSpan(this.btnMentes, 2);
            this.btnMentes.Size = new System.Drawing.Size(210, 91);
            this.btnMentes.TabIndex = 3;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = false;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // lblJegyzet
            // 
            this.lblJegyzet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJegyzet.AutoSize = true;
            this.lblJegyzet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJegyzet.ForeColor = System.Drawing.Color.Black;
            this.lblJegyzet.Location = new System.Drawing.Point(52, 184);
            this.lblJegyzet.Name = "lblJegyzet";
            this.lblJegyzet.Size = new System.Drawing.Size(210, 25);
            this.lblJegyzet.TabIndex = 8;
            this.lblJegyzet.Text = "Jegyzet:";
            // 
            // lblCim
            // 
            this.lblCim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.ForeColor = System.Drawing.Color.Black;
            this.lblCim.Location = new System.Drawing.Point(52, 87);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(210, 25);
            this.lblCim.TabIndex = 7;
            this.lblCim.Text = "Cím:";
            // 
            // formJegyzet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.tlp1);
            this.Name = "formJegyzet";
            this.Text = "Jegyzettömb";
            this.Load += new System.EventHandler(this.formJegyzet_Load);
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdatok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TextBox tbJegyzet;
        private System.Windows.Forms.DataGridView dgvAdatok;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.Button btnUjJegyzet;
        private System.Windows.Forms.Label lblJegyzet;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cím;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jegyzet;
        private System.Windows.Forms.DataGridViewButtonColumn Opciók;
    }
}

