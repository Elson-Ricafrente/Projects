
namespace Lab6_Elson
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("John");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Paul");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("George");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Ringo");
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MC_button1 = new System.Windows.Forms.Button();
            this.MC_button2 = new System.Windows.Forms.Button();
            this.MC_button3 = new System.Windows.Forms.Button();
            this.MC_button4 = new System.Windows.Forms.Button();
            this.Bet_button1 = new System.Windows.Forms.Button();
            this.Bet_button2 = new System.Windows.Forms.Button();
            this.Bet_button3 = new System.Windows.Forms.Button();
            this.Bet_button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Deal_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Final_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Results_label = new System.Windows.Forms.Label();
            this.Status_label = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab6_Elson.Properties.Resources.John_Lennon;
            this.pictureBox1.Location = new System.Drawing.Point(71, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab6_Elson.Properties.Resources.Paul_Mccartney;
            this.pictureBox2.Location = new System.Drawing.Point(301, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Lab6_Elson.Properties.Resources.George_Harrison;
            this.pictureBox3.Location = new System.Drawing.Point(526, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 193);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Lab6_Elson.Properties.Resources.Ringo_Starr;
            this.pictureBox4.Location = new System.Drawing.Point(749, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 193);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // MC_button1
            // 
            this.MC_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_button1.Location = new System.Drawing.Point(71, 303);
            this.MC_button1.Name = "MC_button1";
            this.MC_button1.Size = new System.Drawing.Size(155, 46);
            this.MC_button1.TabIndex = 4;
            this.MC_button1.Text = "More Cards";
            this.MC_button1.UseVisualStyleBackColor = true;
            this.MC_button1.Click += new System.EventHandler(this.MC_button1_Click);
            // 
            // MC_button2
            // 
            this.MC_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_button2.Location = new System.Drawing.Point(301, 301);
            this.MC_button2.Name = "MC_button2";
            this.MC_button2.Size = new System.Drawing.Size(155, 48);
            this.MC_button2.TabIndex = 5;
            this.MC_button2.Text = "More Cards";
            this.MC_button2.UseVisualStyleBackColor = true;
            this.MC_button2.Click += new System.EventHandler(this.MC_button2_Click);
            // 
            // MC_button3
            // 
            this.MC_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_button3.Location = new System.Drawing.Point(526, 303);
            this.MC_button3.Name = "MC_button3";
            this.MC_button3.Size = new System.Drawing.Size(155, 46);
            this.MC_button3.TabIndex = 6;
            this.MC_button3.Text = "More Cards";
            this.MC_button3.UseVisualStyleBackColor = true;
            this.MC_button3.Click += new System.EventHandler(this.MC_button3_Click);
            // 
            // MC_button4
            // 
            this.MC_button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC_button4.Location = new System.Drawing.Point(749, 303);
            this.MC_button4.Name = "MC_button4";
            this.MC_button4.Size = new System.Drawing.Size(155, 46);
            this.MC_button4.TabIndex = 7;
            this.MC_button4.Text = "More Cards";
            this.MC_button4.UseVisualStyleBackColor = true;
            this.MC_button4.Click += new System.EventHandler(this.MC_button4_Click);
            // 
            // Bet_button1
            // 
            this.Bet_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bet_button1.Location = new System.Drawing.Point(71, 379);
            this.Bet_button1.Name = "Bet_button1";
            this.Bet_button1.Size = new System.Drawing.Size(155, 41);
            this.Bet_button1.TabIndex = 8;
            this.Bet_button1.Text = "Bet";
            this.Bet_button1.UseVisualStyleBackColor = true;
            this.Bet_button1.Click += new System.EventHandler(this.Bet_button1_Click);
            // 
            // Bet_button2
            // 
            this.Bet_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bet_button2.Location = new System.Drawing.Point(301, 379);
            this.Bet_button2.Name = "Bet_button2";
            this.Bet_button2.Size = new System.Drawing.Size(155, 41);
            this.Bet_button2.TabIndex = 9;
            this.Bet_button2.Text = "Bet";
            this.Bet_button2.UseVisualStyleBackColor = true;
            this.Bet_button2.Click += new System.EventHandler(this.Bet_button2_Click);
            // 
            // Bet_button3
            // 
            this.Bet_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bet_button3.Location = new System.Drawing.Point(526, 379);
            this.Bet_button3.Name = "Bet_button3";
            this.Bet_button3.Size = new System.Drawing.Size(155, 41);
            this.Bet_button3.TabIndex = 10;
            this.Bet_button3.Text = "Bet";
            this.Bet_button3.UseVisualStyleBackColor = true;
            this.Bet_button3.Click += new System.EventHandler(this.Bet_button3_Click);
            // 
            // Bet_button4
            // 
            this.Bet_button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bet_button4.Location = new System.Drawing.Point(749, 379);
            this.Bet_button4.Name = "Bet_button4";
            this.Bet_button4.Size = new System.Drawing.Size(155, 41);
            this.Bet_button4.TabIndex = 11;
            this.Bet_button4.Text = "Bet";
            this.Bet_button4.UseVisualStyleBackColor = true;
            this.Bet_button4.Click += new System.EventHandler(this.Bet_button4_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(71, 479);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(833, 175);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Deal_button
            // 
            this.Deal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deal_button.Location = new System.Drawing.Point(411, 692);
            this.Deal_button.Name = "Deal_button";
            this.Deal_button.Size = new System.Drawing.Size(155, 46);
            this.Deal_button.TabIndex = 13;
            this.Deal_button.Text = "Deal";
            this.Deal_button.UseVisualStyleBackColor = true;
            this.Deal_button.Click += new System.EventHandler(this.Deal_button_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.Location = new System.Drawing.Point(203, 692);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(155, 46);
            this.Reset_button.TabIndex = 14;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Final_button
            // 
            this.Final_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Final_button.Location = new System.Drawing.Point(613, 692);
            this.Final_button.Name = "Final_button";
            this.Final_button.Size = new System.Drawing.Size(155, 46);
            this.Final_button.TabIndex = 15;
            this.Final_button.Text = "Final Result";
            this.Final_button.UseVisualStyleBackColor = true;
            this.Final_button.Click += new System.EventHandler(this.Final_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "John";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Paul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "George";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ringo";
            // 
            // Results_label
            // 
            this.Results_label.AutoSize = true;
            this.Results_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results_label.Location = new System.Drawing.Point(451, 443);
            this.Results_label.Name = "Results_label";
            this.Results_label.Size = new System.Drawing.Size(73, 20);
            this.Results_label.TabIndex = 20;
            this.Results_label.Text = "Results";
            this.Results_label.Click += new System.EventHandler(this.Results_label_Click);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_label.Location = new System.Drawing.Point(237, 759);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(519, 20);
            this.Status_label.TabIndex = 21;
            this.Status_label.Text = "Place your bet by clicking the bet buttons under  each player";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Player";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Card 1";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Card 2";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Card 3";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 811);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.Results_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Final_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Deal_button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Bet_button4);
            this.Controls.Add(this.Bet_button3);
            this.Controls.Add(this.Bet_button2);
            this.Controls.Add(this.Bet_button1);
            this.Controls.Add(this.MC_button4);
            this.Controls.Add(this.MC_button3);
            this.Controls.Add(this.MC_button2);
            this.Controls.Add(this.MC_button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button MC_button1;
        private System.Windows.Forms.Button MC_button2;
        private System.Windows.Forms.Button MC_button3;
        private System.Windows.Forms.Button MC_button4;
        private System.Windows.Forms.Button Bet_button1;
        private System.Windows.Forms.Button Bet_button2;
        private System.Windows.Forms.Button Bet_button3;
        private System.Windows.Forms.Button Bet_button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Deal_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Final_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Results_label;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

