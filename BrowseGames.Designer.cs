
namespace game_rental_final
{
    partial class Home
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameRentalDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameRentalDatabaseDataSet = new game_rental_final.GameRentalDatabaseDataSet();
            this.gameRentalDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMETableAdapter = new game_rental_final.GameRentalDatabaseDataSetTableAdapters.GAMETableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDatabaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gIDDataGridViewTextBoxColumn,
            this.gNAMEDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.yEARDataGridViewTextBoxColumn,
            this.vNAMEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gAMEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 492);
            this.dataGridView1.TabIndex = 3;
            // 
            // gIDDataGridViewTextBoxColumn
            // 
            this.gIDDataGridViewTextBoxColumn.DataPropertyName = "GID";
            this.gIDDataGridViewTextBoxColumn.HeaderText = "GID";
            this.gIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIDDataGridViewTextBoxColumn.Name = "gIDDataGridViewTextBoxColumn";
            this.gIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gNAMEDataGridViewTextBoxColumn
            // 
            this.gNAMEDataGridViewTextBoxColumn.DataPropertyName = "GNAME";
            this.gNAMEDataGridViewTextBoxColumn.HeaderText = "GNAME";
            this.gNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gNAMEDataGridViewTextBoxColumn.Name = "gNAMEDataGridViewTextBoxColumn";
            this.gNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.Width = 125;
            // 
            // yEARDataGridViewTextBoxColumn
            // 
            this.yEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR";
            this.yEARDataGridViewTextBoxColumn.HeaderText = "YEAR";
            this.yEARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yEARDataGridViewTextBoxColumn.Name = "yEARDataGridViewTextBoxColumn";
            this.yEARDataGridViewTextBoxColumn.Width = 125;
            // 
            // vNAMEDataGridViewTextBoxColumn
            // 
            this.vNAMEDataGridViewTextBoxColumn.DataPropertyName = "VNAME";
            this.vNAMEDataGridViewTextBoxColumn.HeaderText = "VNAME";
            this.vNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vNAMEDataGridViewTextBoxColumn.Name = "vNAMEDataGridViewTextBoxColumn";
            this.vNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // gAMEBindingSource
            // 
            this.gAMEBindingSource.DataMember = "GAME";
            this.gAMEBindingSource.DataSource = this.gameRentalDatabaseDataSetBindingSource1;
            // 
            // gameRentalDatabaseDataSetBindingSource1
            // 
            this.gameRentalDatabaseDataSetBindingSource1.DataSource = this.gameRentalDatabaseDataSet;
            this.gameRentalDatabaseDataSetBindingSource1.Position = 0;
            // 
            // gameRentalDatabaseDataSet
            // 
            this.gameRentalDatabaseDataSet.DataSetName = "GameRentalDatabaseDataSet";
            this.gameRentalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameRentalDatabaseDataSetBindingSource
            // 
            this.gameRentalDatabaseDataSetBindingSource.DataSource = this.gameRentalDatabaseDataSet;
            this.gameRentalDatabaseDataSetBindingSource.Position = 0;
            // 
            // gAMETableAdapter
            // 
            this.gAMETableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(617, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vendor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Browse in the list of games";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Rent a Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 690);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "Return a Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 805);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Home";
            this.Text = "BrowseGames";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDatabaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gameRentalDatabaseDataSetBindingSource1;
        private GameRentalDatabaseDataSet gameRentalDatabaseDataSet;
        private System.Windows.Forms.BindingSource gameRentalDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource gAMEBindingSource;
        private GameRentalDatabaseDataSetTableAdapters.GAMETableAdapter gAMETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}