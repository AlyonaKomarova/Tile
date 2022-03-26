
namespace WinFormsTiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxTiles = new System.Windows.Forms.PictureBox();
            this.labelInf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReference = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.labelCreateSize = new System.Windows.Forms.Label();
            this.groupBoxCreateSize = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBoxLen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxCalculateTheTile = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxM2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxM1 = new System.Windows.Forms.TextBox();
            this.radioButtonM2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSqM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTiles)).BeginInit();
            this.groupBoxCreateSize.SuspendLayout();
            this.groupBoxCalculateTheTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonNext.Location = new System.Drawing.Point(76, 107);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(58, 55);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.OldLace;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(12, 107);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(58, 55);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxTiles
            // 
            this.pictureBoxTiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxTiles.Location = new System.Drawing.Point(17, 166);
            this.pictureBoxTiles.Name = "pictureBoxTiles";
            this.pictureBoxTiles.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxTiles.TabIndex = 10;
            this.pictureBoxTiles.TabStop = false;
            // 
            // labelInf
            // 
            this.labelInf.AutoSize = true;
            this.labelInf.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInf.Location = new System.Drawing.Point(273, 166);
            this.labelInf.Name = "labelInf";
            this.labelInf.Size = new System.Drawing.Size(98, 27);
            this.labelInf.TabIndex = 12;
            this.labelInf.Text = "labelInf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(237, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Магазин кафельной плитки «Tile Shop»";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(82, 10);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(64, 61);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReference
            // 
            this.buttonReference.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReference.BackgroundImage")));
            this.buttonReference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReference.Location = new System.Drawing.Point(12, 9);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(64, 61);
            this.buttonReference.TabIndex = 15;
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSize.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "50 x 50",
            "45 x 45",
            "40 x 40",
            "35 x 35",
            "30 x 30",
            "25 x 25",
            "20 x 20",
            "Размер на заказ"});
            this.comboBoxSize.Location = new System.Drawing.Point(492, 295);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(166, 28);
            this.comboBoxSize.TabIndex = 16;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            this.comboBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSize_KeyPress);
            // 
            // labelCreateSize
            // 
            this.labelCreateSize.AutoSize = true;
            this.labelCreateSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCreateSize.Location = new System.Drawing.Point(285, 295);
            this.labelCreateSize.Name = "labelCreateSize";
            this.labelCreateSize.Size = new System.Drawing.Size(201, 23);
            this.labelCreateSize.TabIndex = 17;
            this.labelCreateSize.Text = "Выберите размер:";
            // 
            // groupBoxCreateSize
            // 
            this.groupBoxCreateSize.BackColor = System.Drawing.Color.Moccasin;
            this.groupBoxCreateSize.Controls.Add(this.buttonOK);
            this.groupBoxCreateSize.Controls.Add(this.textBoxW);
            this.groupBoxCreateSize.Controls.Add(this.textBoxLen);
            this.groupBoxCreateSize.Controls.Add(this.label3);
            this.groupBoxCreateSize.Controls.Add(this.label2);
            this.groupBoxCreateSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCreateSize.Location = new System.Drawing.Point(294, 344);
            this.groupBoxCreateSize.Name = "groupBoxCreateSize";
            this.groupBoxCreateSize.Size = new System.Drawing.Size(364, 116);
            this.groupBoxCreateSize.TabIndex = 18;
            this.groupBoxCreateSize.TabStop = false;
            this.groupBoxCreateSize.Text = "Введите новый размер:";
            // 
            // buttonOK
            // 
            this.buttonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackgroundImage")));
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(277, 40);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(64, 61);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxW
            // 
            this.textBoxW.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxW.Location = new System.Drawing.Point(153, 75);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(87, 32);
            this.textBoxW.TabIndex = 22;
            this.textBoxW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxW.TextChanged += new System.EventHandler(this.textBoxW_TextChanged);
            this.textBoxW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxW_KeyPress);
            // 
            // textBoxLen
            // 
            this.textBoxLen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLen.Location = new System.Drawing.Point(153, 37);
            this.textBoxLen.Name = "textBoxLen";
            this.textBoxLen.Size = new System.Drawing.Size(87, 32);
            this.textBoxLen.TabIndex = 21;
            this.textBoxLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLen.TextChanged += new System.EventHandler(this.textBoxLen_TextChanged);
            this.textBoxLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLen_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ширина, см:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Длина, см:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStart.BackgroundImage")));
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(85, 113);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(205, 65);
            this.buttonStart.TabIndex = 19;
            this.buttonStart.Text = "Рассчитать стоимость заказа";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxCalculateTheTile
            // 
            this.groupBoxCalculateTheTile.BackColor = System.Drawing.Color.Moccasin;
            this.groupBoxCalculateTheTile.Controls.Add(this.labelPrice);
            this.groupBoxCalculateTheTile.Controls.Add(this.buttonStart);
            this.groupBoxCalculateTheTile.Controls.Add(this.textBoxM2);
            this.groupBoxCalculateTheTile.Controls.Add(this.label4);
            this.groupBoxCalculateTheTile.Controls.Add(this.textBoxM1);
            this.groupBoxCalculateTheTile.Controls.Add(this.radioButtonM2);
            this.groupBoxCalculateTheTile.Controls.Add(this.radioButtonSqM);
            this.groupBoxCalculateTheTile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCalculateTheTile.Location = new System.Drawing.Point(724, 105);
            this.groupBoxCalculateTheTile.Name = "groupBoxCalculateTheTile";
            this.groupBoxCalculateTheTile.Size = new System.Drawing.Size(389, 313);
            this.groupBoxCalculateTheTile.TabIndex = 20;
            this.groupBoxCalculateTheTile.TabStop = false;
            this.groupBoxCalculateTheTile.Text = "Рассчитать стоимость заказа:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(26, 197);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(71, 21);
            this.labelPrice.TabIndex = 22;
            this.labelPrice.Text = "labelInf";
            // 
            // textBoxM2
            // 
            this.textBoxM2.Location = new System.Drawing.Point(225, 60);
            this.textBoxM2.Name = "textBoxM2";
            this.textBoxM2.Size = new System.Drawing.Size(65, 32);
            this.textBoxM2.TabIndex = 4;
            this.textBoxM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxM2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxM2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "x";
            // 
            // textBoxM1
            // 
            this.textBoxM1.Location = new System.Drawing.Point(124, 60);
            this.textBoxM1.Name = "textBoxM1";
            this.textBoxM1.Size = new System.Drawing.Size(65, 32);
            this.textBoxM1.TabIndex = 2;
            this.textBoxM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxM1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxM1_KeyPress);
            // 
            // radioButtonM2
            // 
            this.radioButtonM2.AutoSize = true;
            this.radioButtonM2.Location = new System.Drawing.Point(26, 79);
            this.radioButtonM2.Name = "radioButtonM2";
            this.radioButtonM2.Size = new System.Drawing.Size(86, 27);
            this.radioButtonM2.TabIndex = 1;
            this.radioButtonM2.TabStop = true;
            this.radioButtonM2.Text = "м x м";
            this.radioButtonM2.UseVisualStyleBackColor = true;
            this.radioButtonM2.CheckedChanged += new System.EventHandler(this.radioButtonM2_CheckedChanged);
            // 
            // radioButtonSqM
            // 
            this.radioButtonSqM.AutoSize = true;
            this.radioButtonSqM.Location = new System.Drawing.Point(26, 46);
            this.radioButtonSqM.Name = "radioButtonSqM";
            this.radioButtonSqM.Size = new System.Drawing.Size(81, 27);
            this.radioButtonSqM.TabIndex = 0;
            this.radioButtonSqM.TabStop = true;
            this.radioButtonSqM.Text = "кв.м.";
            this.radioButtonSqM.UseVisualStyleBackColor = true;
            this.radioButtonSqM.CheckedChanged += new System.EventHandler(this.radioButtonSqM_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(273, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Каталог плиток:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1135, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxCalculateTheTile);
            this.Controls.Add(this.pictureBoxTiles);
            this.Controls.Add(this.buttonReference);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBoxCreateSize);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.labelInf);
            this.Controls.Add(this.labelCreateSize);
            this.Name = "Form1";
            this.Text = "Tile Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTiles)).EndInit();
            this.groupBoxCreateSize.ResumeLayout(false);
            this.groupBoxCreateSize.PerformLayout();
            this.groupBoxCalculateTheTile.ResumeLayout(false);
            this.groupBoxCalculateTheTile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxTiles;
        private System.Windows.Forms.Label labelInf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label labelCreateSize;
        private System.Windows.Forms.GroupBox groupBoxCreateSize;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxCalculateTheTile;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxM2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxM1;
        private System.Windows.Forms.RadioButton radioButtonM2;
        private System.Windows.Forms.RadioButton radioButtonSqM;
        private System.Windows.Forms.Label label5;
    }
}

