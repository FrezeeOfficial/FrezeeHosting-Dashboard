namespace freeze_uk
{
    partial class frmMachineManager
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ipTbx = new System.Windows.Forms.TextBox();
            this.portTbx = new System.Windows.Forms.TextBox();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_connectionBtn = new System.Windows.Forms.Button();
            this.add_machineBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.machineBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Manager";
            // 
            // ipTbx
            // 
            this.ipTbx.Location = new System.Drawing.Point(160, 397);
            this.ipTbx.Name = "ipTbx";
            this.ipTbx.Size = new System.Drawing.Size(213, 20);
            this.ipTbx.TabIndex = 1;
            // 
            // portTbx
            // 
            this.portTbx.Location = new System.Drawing.Point(160, 437);
            this.portTbx.Name = "portTbx";
            this.portTbx.Size = new System.Drawing.Size(213, 20);
            this.portTbx.TabIndex = 2;
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(160, 362);
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(213, 20);
            this.nameTbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 397);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port";
            // 
            // text_connectionBtn
            // 
            this.text_connectionBtn.Location = new System.Drawing.Point(26, 500);
            this.text_connectionBtn.Name = "text_connectionBtn";
            this.text_connectionBtn.Size = new System.Drawing.Size(166, 49);
            this.text_connectionBtn.TabIndex = 7;
            this.text_connectionBtn.Text = "Test Conection";
            this.text_connectionBtn.UseVisualStyleBackColor = true;
            // 
            // add_machineBtn
            // 
            this.add_machineBtn.Location = new System.Drawing.Point(236, 500);
            this.add_machineBtn.Name = "add_machineBtn";
            this.add_machineBtn.Size = new System.Drawing.Size(137, 49);
            this.add_machineBtn.TabIndex = 8;
            this.add_machineBtn.Text = "Add Machine";
            this.add_machineBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current Machines";
            // 
            // machineBox
            // 
            this.machineBox.FormattingEnabled = true;
            this.machineBox.Location = new System.Drawing.Point(31, 144);
            this.machineBox.Name = "machineBox";
            this.machineBox.Size = new System.Drawing.Size(342, 147);
            this.machineBox.TabIndex = 10;
            this.machineBox.SelectedIndexChanged += new System.EventHandler(this.machineBox_SelectedIndexChanged);
            // 
            // frmMachineManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 573);
            this.Controls.Add(this.machineBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_machineBtn);
            this.Controls.Add(this.text_connectionBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.portTbx);
            this.Controls.Add(this.ipTbx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMachineManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMachineManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button add_machineBtn;
        private System.Windows.Forms.Button text_connectionBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.TextBox portTbx;
        private System.Windows.Forms.TextBox ipTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox machineBox;
        private System.Windows.Forms.Label label5;
    }
}