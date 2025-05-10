namespace Tennis_Score_App
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            fPlayerlbl = new Label();
            sPlayerlbl = new Label();
            fplayerpoints = new Label();
            firstPlayerbox = new TextBox();
            secondPlayerbox = new TextBox();
            label6 = new Label();
            savebutton2 = new Button();
            fplayernumericUpDown1 = new NumericUpDown();
            splayernumericUpDown2 = new NumericUpDown();
            labelVS = new Label();
            fPlayerError = new ErrorProvider(components);
            sPlayerError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)fplayernumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splayernumericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fPlayerError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sPlayerError).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(381, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 61);
            label1.TabIndex = 0;
            label1.Text = "New Game";
            // 
            // fPlayerlbl
            // 
            fPlayerlbl.AutoSize = true;
            fPlayerlbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fPlayerlbl.Location = new Point(49, 149);
            fPlayerlbl.Margin = new Padding(4, 0, 4, 0);
            fPlayerlbl.Name = "fPlayerlbl";
            fPlayerlbl.Size = new Size(129, 32);
            fPlayerlbl.TabIndex = 1;
            fPlayerlbl.Text = "First Player";
            fPlayerlbl.Click += label2_Click;
            // 
            // sPlayerlbl
            // 
            sPlayerlbl.AutoSize = true;
            sPlayerlbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sPlayerlbl.Location = new Point(659, 149);
            sPlayerlbl.Margin = new Padding(4, 0, 4, 0);
            sPlayerlbl.Name = "sPlayerlbl";
            sPlayerlbl.Size = new Size(164, 32);
            sPlayerlbl.TabIndex = 2;
            sPlayerlbl.Text = "Second Player";
            // 
            // fplayerpoints
            // 
            fplayerpoints.AutoSize = true;
            fplayerpoints.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fplayerpoints.Location = new Point(110, 309);
            fplayerpoints.Margin = new Padding(4, 0, 4, 0);
            fplayerpoints.Name = "fplayerpoints";
            fplayerpoints.Size = new Size(108, 45);
            fplayerpoints.TabIndex = 3;
            fplayerpoints.Text = "Points";
            // 
            // firstPlayerbox
            // 
            firstPlayerbox.BackColor = Color.Gold;
            firstPlayerbox.Location = new Point(49, 206);
            firstPlayerbox.Margin = new Padding(4, 4, 4, 4);
            firstPlayerbox.Name = "firstPlayerbox";
            firstPlayerbox.Size = new Size(310, 31);
            firstPlayerbox.TabIndex = 1;
            // 
            // secondPlayerbox
            // 
            secondPlayerbox.BackColor = Color.Gold;
            secondPlayerbox.Location = new Point(659, 206);
            secondPlayerbox.Margin = new Padding(4, 4, 4, 4);
            secondPlayerbox.Name = "secondPlayerbox";
            secondPlayerbox.Size = new Size(276, 31);
            secondPlayerbox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(659, 309);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 45);
            label6.TabIndex = 7;
            label6.Text = "Points";
            // 
            // savebutton2
            // 
            savebutton2.BackColor = Color.LightSeaGreen;
            savebutton2.ForeColor = SystemColors.ControlLightLight;
            savebutton2.Location = new Point(382, 471);
            savebutton2.Margin = new Padding(4, 4, 4, 4);
            savebutton2.Name = "savebutton2";
            savebutton2.Size = new Size(238, 50);
            savebutton2.TabIndex = 9;
            savebutton2.Text = "Save";
            savebutton2.UseVisualStyleBackColor = false;
            savebutton2.Click += ButtonSaveGameClick;
            // 
            // fplayernumericUpDown1
            // 
            fplayernumericUpDown1.Location = new Point(136, 385);
            fplayernumericUpDown1.Margin = new Padding(4, 4, 4, 4);
            fplayernumericUpDown1.Name = "fplayernumericUpDown1";
            fplayernumericUpDown1.Size = new Size(74, 31);
            fplayernumericUpDown1.TabIndex = 10;
            // 
            // splayernumericUpDown2
            // 
            splayernumericUpDown2.Location = new Point(688, 385);
            splayernumericUpDown2.Margin = new Padding(4, 4, 4, 4);
            splayernumericUpDown2.Name = "splayernumericUpDown2";
            splayernumericUpDown2.Size = new Size(72, 31);
            splayernumericUpDown2.TabIndex = 11;
            // 
            // labelVS
            // 
            labelVS.AutoSize = true;
            labelVS.Font = new Font("Tempus Sans ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVS.Location = new Point(445, 309);
            labelVS.Margin = new Padding(4, 0, 4, 0);
            labelVS.Name = "labelVS";
            labelVS.Size = new Size(93, 74);
            labelVS.TabIndex = 12;
            labelVS.Text = "VS";
            // 
            // fPlayerError
            // 
            fPlayerError.ContainerControl = this;
            // 
            // sPlayerError
            // 
            sPlayerError.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1000, 562);
            Controls.Add(labelVS);
            Controls.Add(splayernumericUpDown2);
            Controls.Add(fplayernumericUpDown1);
            Controls.Add(savebutton2);
            Controls.Add(label6);
            Controls.Add(secondPlayerbox);
            Controls.Add(firstPlayerbox);
            Controls.Add(fplayerpoints);
            Controls.Add(sPlayerlbl);
            Controls.Add(fPlayerlbl);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form2";
            Text = "NewGameForm";
            Load += Form2_Load;
            Validating += ValidatePlayerName;
            ((System.ComponentModel.ISupportInitialize)fplayernumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splayernumericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fPlayerError).EndInit();
            ((System.ComponentModel.ISupportInitialize)sPlayerError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label fPlayerlbl;
        private Label sPlayerlbl;
        private Label fplayerpoints;
        public  TextBox firstPlayerbox;
        public TextBox secondPlayerbox;
        private Label label6;
        private Button savebutton2;
        private NumericUpDown fplayernumericUpDown1;
        private NumericUpDown splayernumericUpDown2;
        private Label labelVS;
        private ErrorProvider fPlayerError;
        private ErrorProvider sPlayerError;
    }
}