
namespace Words_check_desktop
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
            this.lbl_nor = new System.Windows.Forms.Label();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_eng = new System.Windows.Forms.Label();
            this.btn_shuffle = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loadnor = new System.Windows.Forms.Button();
            this.btn_loadeng = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nor
            // 
            this.lbl_nor.AutoSize = true;
            this.lbl_nor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nor.Location = new System.Drawing.Point(329, 223);
            this.lbl_nor.Name = "lbl_nor";
            this.lbl_nor.Size = new System.Drawing.Size(0, 16);
            this.lbl_nor.TabIndex = 1;
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(387, 158);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 2;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(241, 158);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(75, 23);
            this.btn_yes.TabIndex = 3;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(313, 94);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_eng
            // 
            this.lbl_eng.AutoSize = true;
            this.lbl_eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_eng.Location = new System.Drawing.Point(329, 273);
            this.lbl_eng.Name = "lbl_eng";
            this.lbl_eng.Size = new System.Drawing.Size(0, 16);
            this.lbl_eng.TabIndex = 5;
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Location = new System.Drawing.Point(313, 28);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(75, 23);
            this.btn_shuffle.TabIndex = 6;
            this.btn_shuffle.Text = "Shuffle word";
            this.btn_shuffle.UseVisualStyleBackColor = true;
            this.btn_shuffle.Click += new System.EventHandler(this.btn_shuffle_Click);
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(313, 320);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 23);
            this.btn_result.TabIndex = 7;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(329, 374);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Did you know the meaning of this word?";
            // 
            // btn_loadnor
            // 
            this.btn_loadnor.Location = new System.Drawing.Point(8, 91);
            this.btn_loadnor.Name = "btn_loadnor";
            this.btn_loadnor.Size = new System.Drawing.Size(97, 23);
            this.btn_loadnor.TabIndex = 10;
            this.btn_loadnor.Text = "Load NOR txt file";
            this.btn_loadnor.UseVisualStyleBackColor = true;
            this.btn_loadnor.Click += new System.EventHandler(this.btn_loadnor_Click);
            // 
            // btn_loadeng
            // 
            this.btn_loadeng.Location = new System.Drawing.Point(8, 120);
            this.btn_loadeng.Name = "btn_loadeng";
            this.btn_loadeng.Size = new System.Drawing.Size(97, 23);
            this.btn_loadeng.TabIndex = 11;
            this.btn_loadeng.Text = "Load ENG txt file";
            this.btn_loadeng.UseVisualStyleBackColor = true;
            this.btn_loadeng.Click += new System.EventHandler(this.btn_loadeng_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Open text file containing norwegian words";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "txt";
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Title = "Open text file containing norwegian words";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 473);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_loadnor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_loadeng);
            this.tabPage1.Controls.Add(this.lbl_result);
            this.tabPage1.Controls.Add(this.btn_shuffle);
            this.tabPage1.Controls.Add(this.btn_result);
            this.tabPage1.Controls.Add(this.lbl_nor);
            this.tabPage1.Controls.Add(this.btn_no);
            this.tabPage1.Controls.Add(this.lbl_eng);
            this.tabPage1.Controls.Add(this.btn_yes);
            this.tabPage1.Controls.Add(this.btn_check);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yes/No";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type words";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_nor;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label lbl_eng;
        private System.Windows.Forms.Button btn_shuffle;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_loadnor;
        private System.Windows.Forms.Button btn_loadeng;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

