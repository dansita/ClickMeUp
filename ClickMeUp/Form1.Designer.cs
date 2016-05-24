namespace ClickMeUp
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
            this.components = new System.ComponentModel.Container();
            this.srcUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srcTick = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.srcBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.srcCode = new System.Windows.Forms.TextBox();
            this.srcStatus = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.srcTimer = new System.Windows.Forms.Timer(this.components);
            this.srcDiff = new System.Windows.Forms.CheckBox();
            this.srcBeep = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcTick)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // srcUrl
            // 
            this.srcUrl.Location = new System.Drawing.Point(10, 36);
            this.srcUrl.Name = "srcUrl";
            this.srcUrl.Size = new System.Drawing.Size(210, 20);
            this.srcUrl.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.srcBeep);
            this.groupBox1.Controls.Add(this.srcDiff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.srcTick);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.srcUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impostazioni URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indirizzo della pagina da scansionare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scansiona ogni";
            // 
            // srcTick
            // 
            this.srcTick.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.srcTick.Location = new System.Drawing.Point(87, 60);
            this.srcTick.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.srcTick.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.srcTick.Name = "srcTick";
            this.srcTick.Size = new System.Drawing.Size(52, 20);
            this.srcTick.TabIndex = 2;
            this.srcTick.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "millisecondi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.srcBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorgente originario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Il sorgente base caricato la prima volta che\r\nsi ha effettuato l\'accesso alla pag" +
    "ina";
            // 
            // srcBox
            // 
            this.srcBox.Location = new System.Drawing.Point(10, 47);
            this.srcBox.Multiline = true;
            this.srcBox.Name = "srcBox";
            this.srcBox.ReadOnly = true;
            this.srcBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.srcBox.Size = new System.Drawing.Size(210, 207);
            this.srcBox.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stopBtn);
            this.groupBox3.Controls.Add(this.pauseBtn);
            this.groupBox3.Controls.Add(this.startBtn);
            this.groupBox3.Location = new System.Drawing.Point(249, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 44);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Azioni";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.srcStatus);
            this.groupBox4.Location = new System.Drawing.Point(249, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 41);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stato";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.srcCode);
            this.groupBox5.Location = new System.Drawing.Point(249, 107);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(327, 304);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Anteprima sorgente";
            // 
            // srcCode
            // 
            this.srcCode.Location = new System.Drawing.Point(6, 16);
            this.srcCode.Multiline = true;
            this.srcCode.Name = "srcCode";
            this.srcCode.ReadOnly = true;
            this.srcCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.srcCode.Size = new System.Drawing.Size(315, 282);
            this.srcCode.TabIndex = 6;
            // 
            // srcStatus
            // 
            this.srcStatus.AutoSize = true;
            this.srcStatus.Location = new System.Drawing.Point(6, 18);
            this.srcStatus.Name = "srcStatus";
            this.srcStatus.Size = new System.Drawing.Size(116, 13);
            this.srcStatus.TabIndex = 4;
            this.srcStatus.Text = "Scansione non avviata";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(29, 14);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(87, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Avvia";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Location = new System.Drawing.Point(122, 14);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(87, 23);
            this.pauseBtn.TabIndex = 1;
            this.pauseBtn.Text = "Pausa";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(215, 14);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(87, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Interrompi";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // srcTimer
            // 
            this.srcTimer.Tick += new System.EventHandler(this.srcTimer_Tick);
            // 
            // srcDiff
            // 
            this.srcDiff.AutoSize = true;
            this.srcDiff.Checked = true;
            this.srcDiff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.srcDiff.Location = new System.Drawing.Point(10, 87);
            this.srcDiff.Name = "srcDiff";
            this.srcDiff.Size = new System.Drawing.Size(203, 17);
            this.srcDiff.TabIndex = 4;
            this.srcDiff.Text = "Apri la pagina se si rilevano differenze";
            this.srcDiff.UseVisualStyleBackColor = true;
            // 
            // srcBeep
            // 
            this.srcBeep.AutoSize = true;
            this.srcBeep.Checked = true;
            this.srcBeep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.srcBeep.Location = new System.Drawing.Point(10, 108);
            this.srcBeep.Name = "srcBeep";
            this.srcBeep.Size = new System.Drawing.Size(210, 17);
            this.srcBeep.TabIndex = 5;
            this.srcBeep.Text = "Emetti un \"bip\" se si rilevano differenze";
            this.srcBeep.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(482, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Info su ClickMeUp";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickMeUp 1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcTick)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srcUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown srcTick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox srcBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox srcCode;
        private System.Windows.Forms.Label srcStatus;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer srcTimer;
        private System.Windows.Forms.CheckBox srcDiff;
        private System.Windows.Forms.CheckBox srcBeep;
        private System.Windows.Forms.Label label5;
    }
}

