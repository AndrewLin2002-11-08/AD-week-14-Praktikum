namespace AD_week_14_Praktikum
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_datapemain = new System.Windows.Forms.DataGridView();
            this.btn_first = new System.Windows.Forms.Button();
            this.Lbl_teamname = new System.Windows.Forms.Label();
            this.Btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.Lbl_manager = new System.Windows.Forms.Label();
            this.Lbl_stadium = new System.Windows.Forms.Label();
            this.Lbl_todtskorpemainpscorer = new System.Windows.Forms.Label();
            this.Lbl_worstdiscipline = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datapemain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // dataGridView_datapemain
            // 
            this.dataGridView_datapemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datapemain.Location = new System.Drawing.Point(30, 351);
            this.dataGridView_datapemain.Name = "dataGridView_datapemain";
            this.dataGridView_datapemain.RowHeadersWidth = 62;
            this.dataGridView_datapemain.RowTemplate.Height = 28;
            this.dataGridView_datapemain.Size = new System.Drawing.Size(776, 411);
            this.dataGridView_datapemain.TabIndex = 10;
            this.dataGridView_datapemain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(59, 31);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(105, 38);
            this.btn_first.TabIndex = 11;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_teamname
            // 
            this.Lbl_teamname.AutoSize = true;
            this.Lbl_teamname.Location = new System.Drawing.Point(239, 119);
            this.Lbl_teamname.Name = "Lbl_teamname";
            this.Lbl_teamname.Size = new System.Drawing.Size(51, 20);
            this.Lbl_teamname.TabIndex = 12;
            this.Lbl_teamname.Text = "label5";
            // 
            // Btn_next
            // 
            this.Btn_next.Location = new System.Drawing.Point(338, 31);
            this.Btn_next.Name = "Btn_next";
            this.Btn_next.Size = new System.Drawing.Size(104, 38);
            this.Btn_next.TabIndex = 13;
            this.Btn_next.Text = ">";
            this.Btn_next.UseVisualStyleBackColor = true;
            this.Btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(202, 31);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(97, 38);
            this.btn_prev.TabIndex = 14;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(480, 31);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(105, 38);
            this.btn_last.TabIndex = 15;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // Lbl_manager
            // 
            this.Lbl_manager.AutoSize = true;
            this.Lbl_manager.Location = new System.Drawing.Point(239, 157);
            this.Lbl_manager.Name = "Lbl_manager";
            this.Lbl_manager.Size = new System.Drawing.Size(51, 20);
            this.Lbl_manager.TabIndex = 16;
            this.Lbl_manager.Text = "label2";
            // 
            // Lbl_stadium
            // 
            this.Lbl_stadium.AutoSize = true;
            this.Lbl_stadium.Location = new System.Drawing.Point(238, 201);
            this.Lbl_stadium.Name = "Lbl_stadium";
            this.Lbl_stadium.Size = new System.Drawing.Size(51, 20);
            this.Lbl_stadium.TabIndex = 17;
            this.Lbl_stadium.Text = "label3";
            // 
            // Lbl_todtskorpemainpscorer
            // 
            this.Lbl_todtskorpemainpscorer.AutoSize = true;
            this.Lbl_todtskorpemainpscorer.Location = new System.Drawing.Point(238, 245);
            this.Lbl_todtskorpemainpscorer.Name = "Lbl_todtskorpemainpscorer";
            this.Lbl_todtskorpemainpscorer.Size = new System.Drawing.Size(51, 20);
            this.Lbl_todtskorpemainpscorer.TabIndex = 18;
            this.Lbl_todtskorpemainpscorer.Text = "label4";
            this.Lbl_todtskorpemainpscorer.Click += new System.EventHandler(this.Lbl_topscorer_Click);
            // 
            // Lbl_worstdiscipline
            // 
            this.Lbl_worstdiscipline.AutoSize = true;
            this.Lbl_worstdiscipline.Location = new System.Drawing.Point(238, 287);
            this.Lbl_worstdiscipline.Name = "Lbl_worstdiscipline";
            this.Lbl_worstdiscipline.Size = new System.Drawing.Size(51, 20);
            this.Lbl_worstdiscipline.TabIndex = 19;
            this.Lbl_worstdiscipline.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Team Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Stadium :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Manager :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = " Top Scorer :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Worst Discipline :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 882);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lbl_worstdiscipline);
            this.Controls.Add(this.Lbl_todtskorpemainpscorer);
            this.Controls.Add(this.Lbl_stadium);
            this.Controls.Add(this.Lbl_manager);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.Btn_next);
            this.Controls.Add(this.Lbl_teamname);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.dataGridView_datapemain);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Team Name :";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datapemain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_datapemain;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Label Lbl_teamname;
        private System.Windows.Forms.Button Btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label Lbl_manager;
        private System.Windows.Forms.Label Lbl_stadium;
        private System.Windows.Forms.Label Lbl_todtskorpemainpscorer;
        private System.Windows.Forms.Label Lbl_worstdiscipline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

