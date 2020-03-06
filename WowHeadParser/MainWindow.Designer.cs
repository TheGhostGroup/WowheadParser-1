namespace WowHeadParser
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
            this.textBoxDe = new System.Windows.Forms.TextBox();
            this.labelDe = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxLocale = new System.Windows.Forms.ComboBox();
            this.ProgressBarValue = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.comboBoxEntity = new System.Windows.Forms.ComboBox();
            this.selectList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(16, 45);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(624, 28);
            this.progressBar1.TabIndex = 1;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(561, 12);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(79, 22);
            this.textBoxA.TabIndex = 4;
            this.textBoxA.Text = "0";
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Location = new System.Drawing.Point(16, 12);
            this.comboBoxChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(168, 24);
            this.comboBoxChoice.TabIndex = 1;
            this.comboBoxChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoice_SelectedIndexChanged);
            this.comboBoxChoice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxChoice_MouseClick);
            // 
            // textBoxDe
            // 
            this.textBoxDe.Location = new System.Drawing.Point(426, 12);
            this.textBoxDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDe.Name = "textBoxDe";
            this.textBoxDe.Size = new System.Drawing.Size(79, 22);
            this.textBoxDe.TabIndex = 3;
            this.textBoxDe.Text = "1";
            // 
            // labelDe
            // 
            this.labelDe.AutoSize = true;
            this.labelDe.Location = new System.Drawing.Point(372, 15);
            this.labelDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(46, 17);
            this.labelDe.TabIndex = 5;
            this.labelDe.Text = "Start :";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(513, 15);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(41, 17);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "End :";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(496, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start parsing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxLocale
            // 
            this.comboBoxLocale.FormattingEnabled = true;
            this.comboBoxLocale.Location = new System.Drawing.Point(112, 213);
            this.comboBoxLocale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLocale.Name = "comboBoxLocale";
            this.comboBoxLocale.Size = new System.Drawing.Size(105, 24);
            this.comboBoxLocale.TabIndex = 6;
            // 
            // ProgressBarValue
            // 
            this.ProgressBarValue.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.ProgressBarValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarValue.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBarValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgressBarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBarValue.Location = new System.Drawing.Point(16, 56);
            this.ProgressBarValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgressBarValue.Name = "ProgressBarValue";
            this.ProgressBarValue.Size = new System.Drawing.Size(624, 17);
            this.ProgressBarValue.TabIndex = 1;
            this.ProgressBarValue.Text = "0%";
            this.ProgressBarValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Location = new System.Drawing.Point(336, 216);
            this.timeLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(82, 17);
            this.timeLeftLabel.TabIndex = 9;
            this.timeLeftLabel.Text = "00h00m00s";
            // 
            // comboBoxEntity
            // 
            this.comboBoxEntity.FormattingEnabled = true;
            this.comboBoxEntity.Location = new System.Drawing.Point(192, 12);
            this.comboBoxEntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEntity.Name = "comboBoxEntity";
            this.comboBoxEntity.Size = new System.Drawing.Size(168, 24);
            this.comboBoxEntity.TabIndex = 2;
            this.comboBoxEntity.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntity_SelectedIndexChanged);
            this.comboBoxEntity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxEntity_MouseClick);
            // 
            // selectList
            // 
            this.selectList.CheckBoxes = true;
            this.selectList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.selectList.HideSelection = false;
            this.selectList.Location = new System.Drawing.Point(16, 81);
            this.selectList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(624, 118);
            this.selectList.TabIndex = 5;
            this.selectList.UseCompatibleStateImageBehavior = false;
            this.selectList.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time left :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Language :";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.comboBoxEntity);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.ProgressBarValue);
            this.Controls.Add(this.comboBoxLocale);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelDe);
            this.Controls.Add(this.textBoxDe);
            this.Controls.Add(this.comboBoxChoice);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Wowhead Parser";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.ComboBox comboBoxChoice;
        private System.Windows.Forms.TextBox textBoxDe;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxLocale;
        private System.Windows.Forms.Label ProgressBarValue;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.ComboBox comboBoxEntity;
        private System.Windows.Forms.ListView selectList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

