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
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        button1 = new Button();
        listBox2 = new ListBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = SystemColors.Info;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Price, Weight });
        dataGridView1.Location = new Point(33, 68);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(344, 123);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellClick += dataGridView1_CellClick;
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
        label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(205, 6);
        label1.Name = "label1";
        label1.Size = new Size(23, 28);
        label1.TabIndex = 1;
        label1.Text = "0";
        // 
        // listBox1
        // 
        listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 21;
        listBox1.Location = new Point(659, 68);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(258, 193);
        listBox1.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(659, 44);
        label2.Name = "label2";
        label2.Size = new Size(90, 21);
        label2.TabIndex = 3;
        label2.Text = "Your order";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(33, 44);
        label3.Name = "label3";
        label3.Size = new Size(54, 21);
        label3.TabIndex = 4;
        label3.Text = "Menu";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(33, 9);
        label4.Name = "label4";
        label4.Size = new Size(166, 25);
        label4.TabIndex = 5;
        label4.Text = "Restaurant wealth:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(659, 285);
        label5.Name = "label5";
        label5.Size = new Size(96, 25);
        label5.TabIndex = 6;
        label5.Text = "Total sum:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        label6.ForeColor = Color.ForestGreen;
        label6.Location = new Point(761, 282);
        label6.Name = "label6";
        label6.Size = new Size(23, 28);
        label6.TabIndex = 7;
        label6.Text = "0";
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(691, 355);
        button1.Name = "button1";
        button1.Size = new Size(170, 44);
        button1.TabIndex = 8;
        button1.Text = "Make an order";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // listBox2
        // 
        listBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        listBox2.FormattingEnabled = true;
        listBox2.ItemHeight = 21;
        listBox2.Location = new Point(51, 386);
        listBox2.Name = "listBox2";
        listBox2.Size = new Size(245, 130);
        listBox2.TabIndex = 9;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1048, 572);
        Controls.Add(listBox2);
        Controls.Add(button1);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
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
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Button button1;
    private ListBox listBox2;
}