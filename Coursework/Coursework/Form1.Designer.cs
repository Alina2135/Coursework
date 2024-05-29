namespace Coursework
{
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            addProduct1 = new Button();
            textBoxName1 = new TextBox();
            name1 = new Label();
            product1 = new Label();
            comboBoxProduct1 = new ComboBox();
            creator1 = new Label();
            textBoxCreator1 = new TextBox();
            dateTimePickerDatePost1 = new DateTimePicker();
            datePost1 = new Label();
            count1 = new Label();
            textBoxCount1 = new TextBox();
            save1 = new Label();
            dateTimePickerSave1 = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            sortButton1 = new Button();
            search1 = new Button();
            restart = new Button();
            tabel1 = new Label();
            buy = new Button();
            dataGridView2 = new DataGridView();
            order = new Button();
            tabel2 = new Label();
            sortButton2 = new Button();
            restart2 = new Button();
            Back = new Button();
            oform = new Button();
            Back1 = new Button();
            deletProduct = new Button();
            deleteTable = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1011, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Товари";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "Замовлення";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Звіт";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "Зберегти xml файл";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "Завантажити xml файл";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // addProduct1
            // 
            addProduct1.Location = new Point(224, 303);
            addProduct1.Name = "addProduct1";
            addProduct1.Size = new Size(118, 23);
            addProduct1.TabIndex = 1;
            addProduct1.Text = "Додати товар";
            addProduct1.UseVisualStyleBackColor = true;
            addProduct1.Click += addProduct1_Click;
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(28, 84);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(121, 23);
            textBoxName1.TabIndex = 2;
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.Location = new Point(28, 66);
            name1.Name = "name1";
            name1.Size = new Size(39, 15);
            name1.TabIndex = 3;
            name1.Text = "Назва";
            // 
            // product1
            // 
            product1.AutoSize = true;
            product1.Location = new Point(28, 130);
            product1.Name = "product1";
            product1.Size = new Size(67, 15);
            product1.TabIndex = 5;
            product1.Text = "Тип товару";
            // 
            // comboBoxProduct1
            // 
            comboBoxProduct1.FormattingEnabled = true;
            comboBoxProduct1.Items.AddRange(new object[] { "Зерно", "Чай", "М'ясо", "Овочі", "Фрукти", "Консерви", "Солодощі", "Молочні продукти" });
            comboBoxProduct1.Location = new Point(28, 148);
            comboBoxProduct1.Name = "comboBoxProduct1";
            comboBoxProduct1.Size = new Size(121, 23);
            comboBoxProduct1.TabIndex = 6;
            // 
            // creator1
            // 
            creator1.AutoSize = true;
            creator1.Location = new Point(220, 130);
            creator1.Name = "creator1";
            creator1.Size = new Size(62, 15);
            creator1.TabIndex = 8;
            creator1.Text = "Виробник";
            // 
            // textBoxCreator1
            // 
            textBoxCreator1.Location = new Point(220, 148);
            textBoxCreator1.Name = "textBoxCreator1";
            textBoxCreator1.Size = new Size(121, 23);
            textBoxCreator1.TabIndex = 7;
            // 
            // dateTimePickerDatePost1
            // 
            dateTimePickerDatePost1.Format = DateTimePickerFormat.Short;
            dateTimePickerDatePost1.Location = new Point(220, 209);
            dateTimePickerDatePost1.Name = "dateTimePickerDatePost1";
            dateTimePickerDatePost1.Size = new Size(121, 23);
            dateTimePickerDatePost1.TabIndex = 9;
            // 
            // datePost1
            // 
            datePost1.AutoSize = true;
            datePost1.Location = new Point(220, 191);
            datePost1.Name = "datePost1";
            datePost1.Size = new Size(105, 15);
            datePost1.TabIndex = 10;
            datePost1.Text = "Дата поставлення";
            // 
            // count1
            // 
            count1.AutoSize = true;
            count1.Location = new Point(220, 66);
            count1.Name = "count1";
            count1.Size = new Size(56, 15);
            count1.TabIndex = 12;
            count1.Text = "Кількість";
            // 
            // textBoxCount1
            // 
            textBoxCount1.Location = new Point(220, 84);
            textBoxCount1.Name = "textBoxCount1";
            textBoxCount1.Size = new Size(121, 23);
            textBoxCount1.TabIndex = 11;
            // 
            // save1
            // 
            save1.AutoSize = true;
            save1.Location = new Point(28, 191);
            save1.Name = "save1";
            save1.Size = new Size(107, 15);
            save1.TabIndex = 14;
            save1.Text = "Термін зберігання";
            // 
            // dateTimePickerSave1
            // 
            dateTimePickerSave1.Format = DateTimePickerFormat.Short;
            dateTimePickerSave1.Location = new Point(28, 209);
            dateTimePickerSave1.Name = "dateTimePickerSave1";
            dateTimePickerSave1.Size = new Size(121, 23);
            dateTimePickerSave1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(359, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(641, 182);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // sortButton1
            // 
            sortButton1.Location = new Point(28, 303);
            sortButton1.Name = "sortButton1";
            sortButton1.Size = new Size(190, 23);
            sortButton1.TabIndex = 16;
            sortButton1.Text = "Сортування товару за назвою";
            sortButton1.UseVisualStyleBackColor = true;
            sortButton1.Click += sortButton1_Click;
            // 
            // search1
            // 
            search1.Location = new Point(224, 349);
            search1.Name = "search1";
            search1.Size = new Size(118, 23);
            search1.TabIndex = 17;
            search1.Text = "Пошук товару";
            search1.UseVisualStyleBackColor = true;
            search1.Click += search1_Click;
            // 
            // restart
            // 
            restart.Location = new Point(28, 349);
            restart.Name = "restart";
            restart.Size = new Size(190, 23);
            restart.TabIndex = 18;
            restart.Text = "Оновлення таблиці";
            restart.UseVisualStyleBackColor = true;
            restart.Click += restart_Click;
            // 
            // tabel1
            // 
            tabel1.AutoSize = true;
            tabel1.Location = new Point(359, 66);
            tabel1.Name = "tabel1";
            tabel1.Size = new Size(101, 15);
            tabel1.TabIndex = 19;
            tabel1.Text = "Наявність товара";
            tabel1.Click += label1_Click;
            // 
            // buy
            // 
            buy.Location = new Point(359, 281);
            buy.Name = "buy";
            buy.Size = new Size(118, 23);
            buy.TabIndex = 20;
            buy.Text = "Придбати";
            buy.UseVisualStyleBackColor = true;
            buy.Click += buy_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(359, 84);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(641, 182);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // order
            // 
            order.Location = new Point(483, 281);
            order.Name = "order";
            order.Size = new Size(118, 23);
            order.TabIndex = 22;
            order.Text = "Оформити заказ";
            order.UseVisualStyleBackColor = true;
            order.Click += order_Click;
            // 
            // tabel2
            // 
            tabel2.AutoSize = true;
            tabel2.Location = new Point(359, 66);
            tabel2.Name = "tabel2";
            tabel2.Size = new Size(81, 15);
            tabel2.TabIndex = 24;
            tabel2.Text = "Оформлення";
            // 
            // sortButton2
            // 
            sortButton2.Location = new Point(28, 303);
            sortButton2.Name = "sortButton2";
            sortButton2.Size = new Size(190, 23);
            sortButton2.TabIndex = 25;
            sortButton2.Text = "Сортування товару за назвою";
            sortButton2.UseVisualStyleBackColor = true;
            sortButton2.Click += sortButton2_Click;
            // 
            // restart2
            // 
            restart2.Location = new Point(28, 349);
            restart2.Name = "restart2";
            restart2.Size = new Size(190, 23);
            restart2.TabIndex = 26;
            restart2.Text = "Оновлення таблиці";
            restart2.UseVisualStyleBackColor = true;
            restart2.Click += restart2_Click;
            // 
            // Back
            // 
            Back.Location = new Point(28, 257);
            Back.Name = "Back";
            Back.Size = new Size(118, 23);
            Back.TabIndex = 27;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // oform
            // 
            oform.Location = new Point(359, 281);
            oform.Name = "oform";
            oform.Size = new Size(118, 23);
            oform.TabIndex = 28;
            oform.Text = "Оформити";
            oform.UseVisualStyleBackColor = true;
            oform.Click += oform_Click;
            // 
            // Back1
            // 
            Back1.Location = new Point(28, 257);
            Back1.Name = "Back1";
            Back1.Size = new Size(118, 23);
            Back1.TabIndex = 29;
            Back1.Text = "Назад";
            Back1.UseVisualStyleBackColor = true;
            Back1.Click += Back1_Click;
            // 
            // deletProduct
            // 
            deletProduct.Location = new Point(359, 281);
            deletProduct.Name = "deletProduct";
            deletProduct.Size = new Size(118, 23);
            deletProduct.TabIndex = 30;
            deletProduct.Text = "Списання";
            deletProduct.UseVisualStyleBackColor = true;
            deletProduct.Click += deletProduct_Click;
            // 
            // deleteTable
            // 
            deleteTable.AutoSize = true;
            deleteTable.Location = new Point(220, 66);
            deleteTable.Name = "deleteTable";
            deleteTable.Size = new Size(116, 15);
            deleteTable.TabIndex = 31;
            deleteTable.Text = "Товар для списання";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 395);
            Controls.Add(deleteTable);
            Controls.Add(deletProduct);
            Controls.Add(Back1);
            Controls.Add(oform);
            Controls.Add(Back);
            Controls.Add(restart2);
            Controls.Add(sortButton2);
            Controls.Add(tabel2);
            Controls.Add(order);
            Controls.Add(dataGridView2);
            Controls.Add(buy);
            Controls.Add(tabel1);
            Controls.Add(restart);
            Controls.Add(search1);
            Controls.Add(sortButton1);
            Controls.Add(dataGridView1);
            Controls.Add(save1);
            Controls.Add(dateTimePickerSave1);
            Controls.Add(count1);
            Controls.Add(textBoxCount1);
            Controls.Add(datePost1);
            Controls.Add(dateTimePickerDatePost1);
            Controls.Add(creator1);
            Controls.Add(textBoxCreator1);
            Controls.Add(comboBoxProduct1);
            Controls.Add(product1);
            Controls.Add(name1);
            Controls.Add(textBoxName1);
            Controls.Add(addProduct1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Cистеми ведення обліку товарів";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private Button addProduct1;
        private TextBox textBoxName1;
        private Label name1;
        private Label product1;
        private ComboBox comboBoxProduct1;
        private Label creator1;
        private TextBox textBoxCreator1;
        private DateTimePicker dateTimePickerDatePost1;
        private Label datePost1;
        private Label count1;
        private TextBox textBoxCount1;
        private Label save1;
        private DateTimePicker dateTimePickerSave1;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Button sortButton1;
        private Button search1;
        private Button restart;
        private Label tabel1;
        private Button buy;
        private DataGridView dataGridView2;
        private Button order;
        private Label tabel2;
        private Button sortButton2;
        private Button restart2;
        private Button Back;
        private Button oform;
        private Button Back1;
        private Button deletProduct;
        private Label deleteTable;
        private ToolStripButton toolStripButton4;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripButton toolStripButton5;
    }
}