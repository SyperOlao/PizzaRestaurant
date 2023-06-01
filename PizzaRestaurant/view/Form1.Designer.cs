namespace PizzaRestaurant.view;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView1 = new DataGridView();
        Name = new DataGridViewTextBoxColumn();
        Price = new DataGridViewTextBoxColumn();
        Weight = new DataGridViewTextBoxColumn();
        label1 = new Label();
        listBox1 = new ListBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = SystemColors.Info;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Price, Weight });
        dataGridView1.Location = new Point(12, 28);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(344, 123);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellClick += dataGridView1_CellClick;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // Name
        // 
        Name.HeaderText = "Name";
        Name.Name = "Name";
        // 
        // Price
        // 
        Price.HeaderText = "Price";
        Price.Name = "Price";
        // 
        // Weight
        // 
        Weight.HeaderText = "Weight";
        Weight.Name = "Weight";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(420, 28);
        label1.Name = "label1";
        label1.Size = new Size(38, 15);
        label1.TabIndex = 1;
        label1.Text = "label1";
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new Point(655, 28);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(258, 124);
        listBox1.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1048, 572);
        Controls.Add(listBox1);
        Controls.Add(label1);
        Controls.Add(dataGridView1);
        this.Name.Name = "Form1";
        Text = "Pizza Resorant";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn Name;
    private DataGridViewTextBoxColumn Price;
    private DataGridViewTextBoxColumn Weight;
    private Label label1;
    private ListBox listBox1;
}