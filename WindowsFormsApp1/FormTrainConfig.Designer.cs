namespace WindowsFormsApp1
{
    partial class FormTrainConfig
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_locomotive = new System.Windows.Forms.Label();
            this.label_train = new System.Windows.Forms.Label();
            this.panel_train = new System.Windows.Forms.Panel();
            this.label_carriagecolor = new System.Windows.Forms.Label();
            this.label_windowcolor = new System.Windows.Forms.Label();
            this.label_maincolor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_train.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_locomotive);
            this.groupBox1.Controls.Add(this.label_train);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип транспорта";
            // 
            // label_locomotive
            // 
            this.label_locomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_locomotive.Location = new System.Drawing.Point(20, 78);
            this.label_locomotive.Name = "label_locomotive";
            this.label_locomotive.Size = new System.Drawing.Size(162, 33);
            this.label_locomotive.TabIndex = 1;
            this.label_locomotive.Text = "Локомотив";
            this.label_locomotive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_locomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_locomotive_MouseDown);
            // 
            // label_train
            // 
            this.label_train.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_train.Location = new System.Drawing.Point(20, 28);
            this.label_train.Name = "label_train";
            this.label_train.Size = new System.Drawing.Size(162, 34);
            this.label_train.TabIndex = 0;
            this.label_train.Text = "Поезд";
            this.label_train.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_train.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_train_MouseDown);
            // 
            // panel_train
            // 
            this.panel_train.AllowDrop = true;
            this.panel_train.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_train.Controls.Add(this.label_carriagecolor);
            this.panel_train.Controls.Add(this.label_windowcolor);
            this.panel_train.Controls.Add(this.label_maincolor);
            this.panel_train.Controls.Add(this.pictureBox1);
            this.panel_train.Location = new System.Drawing.Point(231, 12);
            this.panel_train.Name = "panel_train";
            this.panel_train.Size = new System.Drawing.Size(211, 297);
            this.panel_train.TabIndex = 2;
            this.panel_train.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_train_DragDrop);
            this.panel_train.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_train_DragEnter);
            // 
            // label_carriagecolor
            // 
            this.label_carriagecolor.AllowDrop = true;
            this.label_carriagecolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_carriagecolor.Location = new System.Drawing.Point(3, 243);
            this.label_carriagecolor.Name = "label_carriagecolor";
            this.label_carriagecolor.Size = new System.Drawing.Size(204, 50);
            this.label_carriagecolor.TabIndex = 3;
            this.label_carriagecolor.Text = "Цвет вагона";
            this.label_carriagecolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_carriagecolor.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_carriagecolor_DragDrop);
            this.label_carriagecolor.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_maincolor_DragEnter);
            // 
            // label_windowcolor
            // 
            this.label_windowcolor.AllowDrop = true;
            this.label_windowcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_windowcolor.Location = new System.Drawing.Point(3, 193);
            this.label_windowcolor.Name = "label_windowcolor";
            this.label_windowcolor.Size = new System.Drawing.Size(204, 50);
            this.label_windowcolor.TabIndex = 2;
            this.label_windowcolor.Text = "Цвет окон";
            this.label_windowcolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_windowcolor.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_windowcolor_DragDrop);
            this.label_windowcolor.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_maincolor_DragEnter);
            // 
            // label_maincolor
            // 
            this.label_maincolor.AllowDrop = true;
            this.label_maincolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_maincolor.Location = new System.Drawing.Point(3, 143);
            this.label_maincolor.Name = "label_maincolor";
            this.label_maincolor.Size = new System.Drawing.Size(204, 50);
            this.label_maincolor.TabIndex = 1;
            this.label_maincolor.Text = "Основной цвет";
            this.label_maincolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_maincolor.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_maincolor_DragDrop);
            this.label_maincolor.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_maincolor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(463, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 283);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel9.Location = new System.Drawing.Point(73, 193);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(40, 40);
            this.panel9.TabIndex = 7;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Yellow;
            this.panel8.Location = new System.Drawing.Point(73, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(40, 40);
            this.panel8.TabIndex = 6;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Lime;
            this.panel7.Location = new System.Drawing.Point(73, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(40, 40);
            this.panel7.TabIndex = 5;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(73, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 40);
            this.panel6.TabIndex = 4;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Aqua;
            this.panel5.Location = new System.Drawing.Point(7, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 40);
            this.panel5.TabIndex = 3;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(7, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 40);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(7, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 40);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(32, 343);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(116, 61);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(250, 343);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 61);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // FormTrainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel_train);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTrainConfig";
            this.Text = "FormTrainConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel_train.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_locomotive;
        private System.Windows.Forms.Label label_train;
        private System.Windows.Forms.Panel panel_train;
        private System.Windows.Forms.Label label_carriagecolor;
        private System.Windows.Forms.Label label_windowcolor;
        private System.Windows.Forms.Label label_maincolor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_cancel;
    }
}