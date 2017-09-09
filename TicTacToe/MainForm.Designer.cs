namespace TicTacToe
{
    partial class MainForm
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.btnSquare00 = new System.Windows.Forms.Button();
            this.btnSquare01 = new System.Windows.Forms.Button();
            this.btnSquare02 = new System.Windows.Forms.Button();
            this.btnSquare10 = new System.Windows.Forms.Button();
            this.btnSquare04 = new System.Windows.Forms.Button();
            this.btnSquare03 = new System.Windows.Forms.Button();
            this.btnSquare13 = new System.Windows.Forms.Button();
            this.btnSquare12 = new System.Windows.Forms.Button();
            this.btnSquare11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSquare14 = new System.Windows.Forms.Button();
            this.btnSquare20 = new System.Windows.Forms.Button();
            this.btnSquare21 = new System.Windows.Forms.Button();
            this.btnSquare22 = new System.Windows.Forms.Button();
            this.btnSquare23 = new System.Windows.Forms.Button();
            this.btnSquare24 = new System.Windows.Forms.Button();
            this.btnSquare30 = new System.Windows.Forms.Button();
            this.btnSquare31 = new System.Windows.Forms.Button();
            this.btnSquare32 = new System.Windows.Forms.Button();
            this.btnSquare33 = new System.Windows.Forms.Button();
            this.btnSquare34 = new System.Windows.Forms.Button();
            this.btnSquare40 = new System.Windows.Forms.Button();
            this.btnSquare41 = new System.Windows.Forms.Button();
            this.btnSquare42 = new System.Windows.Forms.Button();
            this.btnSquare43 = new System.Windows.Forms.Button();
            this.btnSquare44 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(108, 13);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(250, 20);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(12, 74);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(90, 60);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start New Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(12, 140);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(90, 60);
            this.btnGoComputer.TabIndex = 3;
            this.btnGoComputer.Text = "GO! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
            this.btnGoComputer.Click += new System.EventHandler(this.btnGoComputer_Click);
            // 
            // btnSquare00
            // 
            this.btnSquare00.AccessibleName = "";
            this.btnSquare00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare00.Location = new System.Drawing.Point(3, 3);
            this.btnSquare00.Name = "btnSquare00";
            this.btnSquare00.Size = new System.Drawing.Size(43, 46);
            this.btnSquare00.TabIndex = 4;
            this.btnSquare00.Text = "?";
            this.btnSquare00.UseVisualStyleBackColor = true;
            this.btnSquare00.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare01
            // 
            this.btnSquare01.AccessibleName = "";
            this.btnSquare01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare01.Location = new System.Drawing.Point(52, 3);
            this.btnSquare01.Name = "btnSquare01";
            this.btnSquare01.Size = new System.Drawing.Size(43, 46);
            this.btnSquare01.TabIndex = 5;
            this.btnSquare01.Text = "?";
            this.btnSquare01.UseVisualStyleBackColor = true;
            this.btnSquare01.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare02
            // 
            this.btnSquare02.AccessibleName = "";
            this.btnSquare02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare02.Location = new System.Drawing.Point(101, 3);
            this.btnSquare02.Name = "btnSquare02";
            this.btnSquare02.Size = new System.Drawing.Size(43, 46);
            this.btnSquare02.TabIndex = 6;
            this.btnSquare02.Text = "?";
            this.btnSquare02.UseVisualStyleBackColor = true;
            this.btnSquare02.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare10
            // 
            this.btnSquare10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare10.Location = new System.Drawing.Point(3, 55);
            this.btnSquare10.Name = "btnSquare10";
            this.btnSquare10.Size = new System.Drawing.Size(43, 46);
            this.btnSquare10.TabIndex = 9;
            this.btnSquare10.Text = "?";
            this.btnSquare10.UseVisualStyleBackColor = true;
            this.btnSquare10.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare04
            // 
            this.btnSquare04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare04.Location = new System.Drawing.Point(199, 3);
            this.btnSquare04.Name = "btnSquare04";
            this.btnSquare04.Size = new System.Drawing.Size(46, 46);
            this.btnSquare04.TabIndex = 8;
            this.btnSquare04.Text = "?";
            this.btnSquare04.UseVisualStyleBackColor = true;
            this.btnSquare04.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare03
            // 
            this.btnSquare03.AccessibleName = "";
            this.btnSquare03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare03.Location = new System.Drawing.Point(150, 3);
            this.btnSquare03.Name = "btnSquare03";
            this.btnSquare03.Size = new System.Drawing.Size(43, 46);
            this.btnSquare03.TabIndex = 7;
            this.btnSquare03.Text = "?";
            this.btnSquare03.UseVisualStyleBackColor = true;
            this.btnSquare03.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare13
            // 
            this.btnSquare13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare13.Location = new System.Drawing.Point(150, 55);
            this.btnSquare13.Name = "btnSquare13";
            this.btnSquare13.Size = new System.Drawing.Size(43, 46);
            this.btnSquare13.TabIndex = 12;
            this.btnSquare13.Text = "?";
            this.btnSquare13.UseVisualStyleBackColor = true;
            this.btnSquare13.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare12
            // 
            this.btnSquare12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare12.Location = new System.Drawing.Point(101, 55);
            this.btnSquare12.Name = "btnSquare12";
            this.btnSquare12.Size = new System.Drawing.Size(43, 46);
            this.btnSquare12.TabIndex = 11;
            this.btnSquare12.Text = "?";
            this.btnSquare12.UseVisualStyleBackColor = true;
            this.btnSquare12.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare11
            // 
            this.btnSquare11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare11.Location = new System.Drawing.Point(52, 55);
            this.btnSquare11.Name = "btnSquare11";
            this.btnSquare11.Size = new System.Drawing.Size(43, 46);
            this.btnSquare11.TabIndex = 10;
            this.btnSquare11.Text = "?";
            this.btnSquare11.UseVisualStyleBackColor = true;
            this.btnSquare11.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Human Player:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnSquare00, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare02, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare03, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare04, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare14, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare22, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare23, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare24, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare30, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare31, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare32, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare33, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare34, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare40, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare41, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare42, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare43, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare44, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(124, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 260);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnSquare14
            // 
            this.btnSquare14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare14.Location = new System.Drawing.Point(199, 55);
            this.btnSquare14.Name = "btnSquare14";
            this.btnSquare14.Size = new System.Drawing.Size(46, 46);
            this.btnSquare14.TabIndex = 12;
            this.btnSquare14.Text = "?";
            this.btnSquare14.UseVisualStyleBackColor = true;
            this.btnSquare14.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare20
            // 
            this.btnSquare20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare20.Location = new System.Drawing.Point(3, 107);
            this.btnSquare20.Name = "btnSquare20";
            this.btnSquare20.Size = new System.Drawing.Size(43, 46);
            this.btnSquare20.TabIndex = 12;
            this.btnSquare20.Text = "?";
            this.btnSquare20.UseVisualStyleBackColor = true;
            this.btnSquare20.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare21
            // 
            this.btnSquare21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare21.Location = new System.Drawing.Point(52, 107);
            this.btnSquare21.Name = "btnSquare21";
            this.btnSquare21.Size = new System.Drawing.Size(43, 46);
            this.btnSquare21.TabIndex = 12;
            this.btnSquare21.Text = "?";
            this.btnSquare21.UseVisualStyleBackColor = true;
            this.btnSquare21.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare22
            // 
            this.btnSquare22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare22.Enabled = false;
            this.btnSquare22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare22.Location = new System.Drawing.Point(101, 107);
            this.btnSquare22.Name = "btnSquare22";
            this.btnSquare22.Size = new System.Drawing.Size(43, 46);
            this.btnSquare22.TabIndex = 12;
            this.btnSquare22.Text = "Free Space";
            this.btnSquare22.UseVisualStyleBackColor = true;
            // 
            // btnSquare23
            // 
            this.btnSquare23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare23.Location = new System.Drawing.Point(150, 107);
            this.btnSquare23.Name = "btnSquare23";
            this.btnSquare23.Size = new System.Drawing.Size(43, 46);
            this.btnSquare23.TabIndex = 12;
            this.btnSquare23.Text = "?";
            this.btnSquare23.UseVisualStyleBackColor = true;
            this.btnSquare23.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare24
            // 
            this.btnSquare24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare24.Location = new System.Drawing.Point(199, 107);
            this.btnSquare24.Name = "btnSquare24";
            this.btnSquare24.Size = new System.Drawing.Size(46, 46);
            this.btnSquare24.TabIndex = 12;
            this.btnSquare24.Text = "?";
            this.btnSquare24.UseVisualStyleBackColor = true;
            this.btnSquare24.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare30
            // 
            this.btnSquare30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare30.Location = new System.Drawing.Point(3, 159);
            this.btnSquare30.Name = "btnSquare30";
            this.btnSquare30.Size = new System.Drawing.Size(43, 46);
            this.btnSquare30.TabIndex = 12;
            this.btnSquare30.Text = "?";
            this.btnSquare30.UseVisualStyleBackColor = true;
            this.btnSquare30.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare31
            // 
            this.btnSquare31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare31.Location = new System.Drawing.Point(52, 159);
            this.btnSquare31.Name = "btnSquare31";
            this.btnSquare31.Size = new System.Drawing.Size(43, 46);
            this.btnSquare31.TabIndex = 12;
            this.btnSquare31.Text = "?";
            this.btnSquare31.UseVisualStyleBackColor = true;
            this.btnSquare31.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare32
            // 
            this.btnSquare32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare32.Location = new System.Drawing.Point(101, 159);
            this.btnSquare32.Name = "btnSquare32";
            this.btnSquare32.Size = new System.Drawing.Size(43, 46);
            this.btnSquare32.TabIndex = 12;
            this.btnSquare32.Text = "?";
            this.btnSquare32.UseVisualStyleBackColor = true;
            this.btnSquare32.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare33
            // 
            this.btnSquare33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare33.Location = new System.Drawing.Point(150, 159);
            this.btnSquare33.Name = "btnSquare33";
            this.btnSquare33.Size = new System.Drawing.Size(43, 46);
            this.btnSquare33.TabIndex = 12;
            this.btnSquare33.Text = "?";
            this.btnSquare33.UseVisualStyleBackColor = true;
            this.btnSquare33.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare34
            // 
            this.btnSquare34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare34.Location = new System.Drawing.Point(199, 159);
            this.btnSquare34.Name = "btnSquare34";
            this.btnSquare34.Size = new System.Drawing.Size(46, 46);
            this.btnSquare34.TabIndex = 12;
            this.btnSquare34.Text = "?";
            this.btnSquare34.UseVisualStyleBackColor = true;
            this.btnSquare34.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare40
            // 
            this.btnSquare40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare40.Location = new System.Drawing.Point(3, 211);
            this.btnSquare40.Name = "btnSquare40";
            this.btnSquare40.Size = new System.Drawing.Size(43, 46);
            this.btnSquare40.TabIndex = 12;
            this.btnSquare40.Text = "?";
            this.btnSquare40.UseVisualStyleBackColor = true;
            this.btnSquare40.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare41
            // 
            this.btnSquare41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare41.Location = new System.Drawing.Point(52, 211);
            this.btnSquare41.Name = "btnSquare41";
            this.btnSquare41.Size = new System.Drawing.Size(43, 46);
            this.btnSquare41.TabIndex = 12;
            this.btnSquare41.Text = "?";
            this.btnSquare41.UseVisualStyleBackColor = true;
            this.btnSquare41.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare42
            // 
            this.btnSquare42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare42.Location = new System.Drawing.Point(101, 211);
            this.btnSquare42.Name = "btnSquare42";
            this.btnSquare42.Size = new System.Drawing.Size(43, 46);
            this.btnSquare42.TabIndex = 12;
            this.btnSquare42.Text = "?";
            this.btnSquare42.UseVisualStyleBackColor = true;
            this.btnSquare42.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare43
            // 
            this.btnSquare43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare43.Location = new System.Drawing.Point(150, 211);
            this.btnSquare43.Name = "btnSquare43";
            this.btnSquare43.Size = new System.Drawing.Size(43, 46);
            this.btnSquare43.TabIndex = 12;
            this.btnSquare43.Text = "?";
            this.btnSquare43.UseVisualStyleBackColor = true;
            this.btnSquare43.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // btnSquare44
            // 
            this.btnSquare44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare44.Location = new System.Drawing.Point(199, 211);
            this.btnSquare44.Name = "btnSquare44";
            this.btnSquare44.Size = new System.Drawing.Size(46, 46);
            this.btnSquare44.TabIndex = 12;
            this.btnSquare44.Text = "?";
            this.btnSquare44.UseVisualStyleBackColor = true;
            this.btnSquare44.Click += new System.EventHandler(this.TicTacToeButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "CS Game Surface - Nathan Robson";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.Button btnSquare00;
        private System.Windows.Forms.Button btnSquare01;
        private System.Windows.Forms.Button btnSquare02;
        private System.Windows.Forms.Button btnSquare10;
        private System.Windows.Forms.Button btnSquare04;
        private System.Windows.Forms.Button btnSquare03;
        private System.Windows.Forms.Button btnSquare13;
        private System.Windows.Forms.Button btnSquare12;
        private System.Windows.Forms.Button btnSquare11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSquare14;
        private System.Windows.Forms.Button btnSquare20;
        private System.Windows.Forms.Button btnSquare21;
        private System.Windows.Forms.Button btnSquare22;
        private System.Windows.Forms.Button btnSquare23;
        private System.Windows.Forms.Button btnSquare24;
        private System.Windows.Forms.Button btnSquare30;
        private System.Windows.Forms.Button btnSquare31;
        private System.Windows.Forms.Button btnSquare32;
        private System.Windows.Forms.Button btnSquare33;
        private System.Windows.Forms.Button btnSquare34;
        private System.Windows.Forms.Button btnSquare40;
        private System.Windows.Forms.Button btnSquare41;
        private System.Windows.Forms.Button btnSquare42;
        private System.Windows.Forms.Button btnSquare43;
        private System.Windows.Forms.Button btnSquare44;
    }
}

