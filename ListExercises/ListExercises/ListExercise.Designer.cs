namespace ListExercises
{
    partial class ListExercise
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
            this.listTextBox = new System.Windows.Forms.TextBox();
            this.listAddButton = new System.Windows.Forms.Button();
            this.showListButton = new System.Windows.Forms.Button();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.list2Button = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Element";
            // 
            // listTextBox
            // 
            this.listTextBox.Location = new System.Drawing.Point(191, 87);
            this.listTextBox.Name = "listTextBox";
            this.listTextBox.Size = new System.Drawing.Size(169, 26);
            this.listTextBox.TabIndex = 1;
            // 
            // listAddButton
            // 
            this.listAddButton.Location = new System.Drawing.Point(438, 81);
            this.listAddButton.Name = "listAddButton";
            this.listAddButton.Size = new System.Drawing.Size(75, 39);
            this.listAddButton.TabIndex = 2;
            this.listAddButton.Text = "Add";
            this.listAddButton.UseVisualStyleBackColor = true;
            this.listAddButton.Click += new System.EventHandler(this.listAddButton_Click);
            // 
            // showListButton
            // 
            this.showListButton.Location = new System.Drawing.Point(544, 82);
            this.showListButton.Name = "showListButton";
            this.showListButton.Size = new System.Drawing.Size(75, 37);
            this.showListButton.TabIndex = 3;
            this.showListButton.Text = "Show";
            this.showListButton.UseVisualStyleBackColor = true;
            this.showListButton.Click += new System.EventHandler(this.showListButton_Click);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(438, 142);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(87, 37);
            this.ReverseButton.TabIndex = 4;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(438, 195);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 36);
            this.sumButton.TabIndex = 5;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // list2Button
            // 
            this.list2Button.Location = new System.Drawing.Point(544, 142);
            this.list2Button.Name = "list2Button";
            this.list2Button.Size = new System.Drawing.Size(75, 37);
            this.list2Button.TabIndex = 6;
            this.list2Button.Text = "List 2";
            this.list2Button.UseVisualStyleBackColor = true;
            this.list2Button.Click += new System.EventHandler(this.list2Button_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(544, 246);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(75, 45);
            this.minButton.TabIndex = 7;
            this.minButton.Text = "Min";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(438, 246);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(75, 45);
            this.maxButton.TabIndex = 7;
            this.maxButton.Text = "Max";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(544, 195);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 36);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // ListExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.list2Button);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.showListButton);
            this.Controls.Add(this.listAddButton);
            this.Controls.Add(this.listTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ListExercise";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox listTextBox;
        private System.Windows.Forms.Button listAddButton;
        private System.Windows.Forms.Button showListButton;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button list2Button;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button sortButton;
    }
}

