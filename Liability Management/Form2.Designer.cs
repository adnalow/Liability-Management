namespace Liability_Management
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
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dueDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loggedIn = new System.Windows.Forms.Label();
            this.asignee = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeLiab = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.specificLiab = new System.Windows.Forms.TextBox();
            this.viewSpecified = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "assignee";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(365, 362);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(133, 66);
            this.submit.TabIndex = 11;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(300, 258);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(281, 33);
            this.price.TabIndex = 10;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(300, 196);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(281, 33);
            this.description.TabIndex = 9;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(300, 135);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(281, 33);
            this.name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Liability Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Liability Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Liability Price";
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(300, 310);
            this.dueDate.Multiline = true;
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(281, 33);
            this.dueDate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Due Date";
            // 
            // loggedIn
            // 
            this.loggedIn.AutoSize = true;
            this.loggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedIn.Location = new System.Drawing.Point(359, 39);
            this.loggedIn.Name = "loggedIn";
            this.loggedIn.Size = new System.Drawing.Size(150, 33);
            this.loggedIn.TabIndex = 18;
            this.loggedIn.Text = "Username";
            // 
            // asignee
            // 
            this.asignee.FormattingEnabled = true;
            this.asignee.Items.AddRange(new object[] {
            "general",
            "adrian",
            "kim",
            "gian"});
            this.asignee.Location = new System.Drawing.Point(311, 76);
            this.asignee.Name = "asignee";
            this.asignee.Size = new System.Drawing.Size(270, 21);
            this.asignee.TabIndex = 19;
            this.asignee.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(649, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 190);
            this.dataGridView1.TabIndex = 20;
            // 
            // removeLiab
            // 
            this.removeLiab.Location = new System.Drawing.Point(61, 478);
            this.removeLiab.Name = "removeLiab";
            this.removeLiab.Size = new System.Drawing.Size(282, 20);
            this.removeLiab.TabIndex = 21;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(141, 504);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(110, 23);
            this.btn2.TabIndex = 22;
            this.btn2.Text = "remove";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Remove Liability";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(765, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 33);
            this.label7.TabIndex = 24;
            this.label7.Text = "View Specific Liability";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(654, 402);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(481, 230);
            this.dataGridView2.TabIndex = 25;
            // 
            // specificLiab
            // 
            this.specificLiab.Location = new System.Drawing.Point(771, 330);
            this.specificLiab.Name = "specificLiab";
            this.specificLiab.Size = new System.Drawing.Size(290, 20);
            this.specificLiab.TabIndex = 26;
            // 
            // viewSpecified
            // 
            this.viewSpecified.Location = new System.Drawing.Point(832, 362);
            this.viewSpecified.Name = "viewSpecified";
            this.viewSpecified.Size = new System.Drawing.Size(165, 23);
            this.viewSpecified.TabIndex = 27;
            this.viewSpecified.Text = "view";
            this.viewSpecified.UseVisualStyleBackColor = true;
            this.viewSpecified.Click += new System.EventHandler(this.viewSpecified_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1161, 644);
            this.Controls.Add(this.viewSpecified);
            this.Controls.Add(this.specificLiab);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.removeLiab);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.asignee);
            this.Controls.Add(this.loggedIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.price);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label loggedIn;
        private System.Windows.Forms.ComboBox asignee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox removeLiab;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox specificLiab;
        private System.Windows.Forms.Button viewSpecified;
    }
}