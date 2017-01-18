namespace DatabaseTest
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
            this.connect_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.connected_label = new System.Windows.Forms.Label();
            this.loading_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_button.Location = new System.Drawing.Point(12, 21);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(83, 31);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 395);
            this.dataGridView1.TabIndex = 3;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(12, 58);
            this.searchTextbox.Multiline = true;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(697, 54);
            this.searchTextbox.TabIndex = 4;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(715, 58);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 54);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // connected_label
            // 
            this.connected_label.AutoSize = true;
            this.connected_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connected_label.Location = new System.Drawing.Point(355, 26);
            this.connected_label.Name = "connected_label";
            this.connected_label.Size = new System.Drawing.Size(89, 20);
            this.connected_label.TabIndex = 6;
            this.connected_label.Text = "Connected";
            this.connected_label.Visible = false;
            // 
            // loading_label
            // 
            this.loading_label.AutoSize = true;
            this.loading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_label.Location = new System.Drawing.Point(359, 26);
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(80, 20);
            this.loading_label.TabIndex = 7;
            this.loading_label.Text = "Loading...";
            this.loading_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 615);
            this.Controls.Add(this.loading_label);
            this.Controls.Add(this.connected_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.connect_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label connected_label;
        private System.Windows.Forms.Label loading_label;
    }
}

