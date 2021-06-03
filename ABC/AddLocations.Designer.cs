
namespace ABC
{
    partial class AddLocations
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
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.days = new System.Windows.Forms.ComboBox();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSelectRoom = new System.Windows.Forms.ComboBox();
            this.groupLable = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LectureLable = new System.Windows.Forms.Label();
            this.btnSearch3 = new System.Windows.Forms.Button();
            this.btnEdite = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 42);
            this.button7.TabIndex = 124;
            this.button7.Text = "Home";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 350);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 155);
            this.dataGridView1.TabIndex = 126;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textsearch);
            this.groupBox2.Controls.Add(this.days);
            this.groupBox2.Controls.Add(this.textBoxStartTime);
            this.groupBox2.Controls.Add(this.textBoxEndTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxRoomID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboSelectRoom);
            this.groupBox2.Controls.Add(this.groupLable);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.LectureLable);
            this.groupBox2.Controls.Add(this.btnSearch3);
            this.groupBox2.Controls.Add(this.btnEdite);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.btnclear);
            this.groupBox2.Location = new System.Drawing.Point(-148, -36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1124, 382);
            this.groupBox2.TabIndex = 125;
            this.groupBox2.TabStop = false;
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.Location = new System.Drawing.Point(548, 327);
            this.textsearch.Margin = new System.Windows.Forms.Padding(2);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(243, 28);
            this.textsearch.TabIndex = 46;
            // 
            // days
            // 
            this.days.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.FormattingEnabled = true;
            this.days.Items.AddRange(new object[] {
            "Morning Shifts",
            "Evening Shifts"});
            this.days.Location = new System.Drawing.Point(320, 186);
            this.days.Margin = new System.Windows.Forms.Padding(2);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(202, 30);
            this.days.TabIndex = 45;
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartTime.Location = new System.Drawing.Point(320, 247);
            this.textBoxStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(202, 28);
            this.textBoxStartTime.TabIndex = 44;
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndTime.Location = new System.Drawing.Point(800, 258);
            this.textBoxEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(202, 28);
            this.textBoxEndTime.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(682, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "End Time";
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomID.Location = new System.Drawing.Point(320, 132);
            this.textBoxRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(202, 28);
            this.textBoxRoomID.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(445, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "ADD LOCATION AND TIME";
            // 
            // comboSelectRoom
            // 
            this.comboSelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectRoom.FormattingEnabled = true;
            this.comboSelectRoom.Items.AddRange(new object[] {
            "Morning Shifts",
            "Evening Shifts"});
            this.comboSelectRoom.Location = new System.Drawing.Point(796, 141);
            this.comboSelectRoom.Margin = new System.Windows.Forms.Padding(2);
            this.comboSelectRoom.Name = "comboSelectRoom";
            this.comboSelectRoom.Size = new System.Drawing.Size(202, 30);
            this.comboSelectRoom.TabIndex = 33;
            // 
            // groupLable
            // 
            this.groupLable.AutoSize = true;
            this.groupLable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLable.ForeColor = System.Drawing.Color.Navy;
            this.groupLable.Location = new System.Drawing.Point(656, 147);
            this.groupLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupLable.Name = "groupLable";
            this.groupLable.Size = new System.Drawing.Size(118, 24);
            this.groupLable.TabIndex = 32;
            this.groupLable.Text = "Select Room";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Navy;
            this.label31.Location = new System.Drawing.Point(244, 189);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 24);
            this.label31.TabIndex = 31;
            this.label31.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(198, 251);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "Start Time";
            // 
            // LectureLable
            // 
            this.LectureLable.AutoSize = true;
            this.LectureLable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LectureLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LectureLable.ForeColor = System.Drawing.Color.Navy;
            this.LectureLable.Location = new System.Drawing.Point(211, 136);
            this.LectureLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LectureLable.Name = "LectureLable";
            this.LectureLable.Size = new System.Drawing.Size(83, 24);
            this.LectureLable.TabIndex = 29;
            this.LectureLable.Text = "Room ID";
            // 
            // btnSearch3
            // 
            this.btnSearch3.BackColor = System.Drawing.Color.Gray;
            this.btnSearch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch3.ForeColor = System.Drawing.Color.White;
            this.btnSearch3.Location = new System.Drawing.Point(800, 327);
            this.btnSearch3.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch3.Name = "btnSearch3";
            this.btnSearch3.Size = new System.Drawing.Size(134, 33);
            this.btnSearch3.TabIndex = 28;
            this.btnSearch3.Text = "Search";
            this.btnSearch3.UseVisualStyleBackColor = false;
            this.btnSearch3.Click += new System.EventHandler(this.btnSearch3_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.BackColor = System.Drawing.Color.Blue;
            this.btnEdite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdite.ForeColor = System.Drawing.Color.White;
            this.btnEdite.Location = new System.Drawing.Point(388, 327);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.Size = new System.Drawing.Size(134, 33);
            this.btnEdite.TabIndex = 25;
            this.btnEdite.Text = "EDIT";
            this.btnEdite.UseVisualStyleBackColor = false;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lime;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(250, 327);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(134, 33);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(944, 327);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(134, 33);
            this.btnclear.TabIndex = 22;
            this.btnclear.Text = "DELETE";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(151, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 42);
            this.button2.TabIndex = 123;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button7);
            this.Name = "AddLocations";
            this.Text = "AddLocations";
            this.Load += new System.EventHandler(this.AddLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.ComboBox days;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSelectRoom;
        private System.Windows.Forms.Label groupLable;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LectureLable;
        private System.Windows.Forms.Button btnSearch3;
        private System.Windows.Forms.Button btnEdite;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button2;
    }
}