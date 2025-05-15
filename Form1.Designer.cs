namespace Tennis_Score_App
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listViewRanking = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listViewLatestGame = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(313, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 70);
            label1.TabIndex = 0;
            label1.Text = "Tennis Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(41, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 48);
            label2.TabIndex = 4;
            label2.Text = "Ranking";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(41, 342);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 48);
            label3.TabIndex = 5;
            label3.Text = "Latest Game\r\n";
            // 
            // listViewRanking
            // 
            listViewRanking.BackColor = Color.Gold;
            listViewRanking.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewRanking.Location = new Point(41, 143);
            listViewRanking.Margin = new Padding(4, 3, 4, 3);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(845, 151);
            listViewRanking.TabIndex = 6;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            listViewRanking.SelectedIndexChanged += listViewRanking_SelectedIndexChanged;

            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PlayerName";
            columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";
            columnHeader2.Width = 265;
            // 
            // listViewLatestGame
            // 
            listViewLatestGame.BackColor = Color.Gold;
            listViewLatestGame.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewLatestGame.Location = new Point(41, 397);
            listViewLatestGame.Margin = new Padding(4, 3, 4, 3);
            listViewLatestGame.Name = "listViewLatestGame";
            listViewLatestGame.Size = new Size(845, 151);
            listViewLatestGame.TabIndex = 7;
            listViewLatestGame.UseCompatibleStateImageBehavior = false;
            listViewLatestGame.View = View.Details;
            listViewLatestGame.SelectedIndexChanged += listViewLatestGame_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "First Player";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Second Player";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Winner";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Score";
            columnHeader6.Width = 66;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Location = new Point(570, 326);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(197, 31);
            button1.TabIndex = 9;
            button1.Text = "Add New Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddNewGameButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1000, 563);
            Controls.Add(button1);
            Controls.Add(listViewLatestGame);
            Controls.Add(listViewRanking);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "ScoreForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listViewRanking;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listViewLatestGame;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
    }
}