using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace Coursework
{
    public partial class Form1 : Form
    {
        public struct User
        {
            public string Name { get; set; }
            public string Product { get; set; }
            public DateTime Save { get; set; }
            public string Creator { get; set; }
            public int Count { get; set; }
            public DateTime Post { get; set; }

            public User(string name, string product, DateTime save, string creator, int count, DateTime post)
            {
                Name = name;
                Product = product;
                Save = save;
                Creator = creator;
                Count = count;
                Post = post;
            }
        }

        List<User> users = new List<User>();
        DataTable table = new DataTable();
        public struct User1
        {
            public string Name1 { get; set; }
            public string Product1 { get; set; }
            public DateTime Save1 { get; set; }
            public string Creator1 { get; set; }
            public int Count1 { get; set; }
            public DateTime Post1 { get; set; }

            public User1(string name1, string product1, DateTime save1, string creator1, int count1, DateTime post1)
            {
                Name1 = name1;
                Product1 = product1;
                Save1 = save1;
                Creator1 = creator1;
                Count1 = count1;
                Post1 = post1;
            }
        }

        List<User> users1 = new List<User>();
        DataTable table1 = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }
        public User BinnarySearch(List<User> users, string searchName, string searchType)
        {
            int first = 0;
            int last = users.Count - 1;
            DateTime currentDate = DateTime.Now;
            User user = new User(searchName, searchType, DateTime.Now, "", 0, DateTime.Now);
            while (first <= last)
            {
                int middle = (first + last) / 2;
                if (searchName == users[middle].Name && searchType == users[middle].Product && users[middle].Save > currentDate)
                {
                    return users[middle];
                }
                else if (String.Compare(searchName, users[middle].Name) <= -1)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }
            }
            return new User();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Objct
            sortButton2.Visible = false;
            restart2.Visible = false;
            deleteTable.Visible = false;
            buy.Visible = false;
            order.Visible = false;
            oform.Visible = false;
            tabel2.Visible = false;
            dataGridView2.Visible = false;
            tabel1.Visible = false;
            dataGridView1.Visible = false;
            Back.Visible = false;
            Back1.Visible = false;
            deletProduct.Visible = false;

            Width = 525;
            // ������� ��������� �������
            table.Columns.Add("�����", typeof(string));
            table.Columns.Add("�����", typeof(string));
            table.Columns.Add("���� ���������", typeof(DateTime));
            table.Columns.Add("��������", typeof(string));
            table.Columns.Add("ʳ������", typeof(int));
            table.Columns.Add("���� �����������", typeof(DateTime));
            // ������������� �������� ������ ��� DataGridView
            dataGridView1.DataSource = table;
            //Tabel 2
            table1.Columns.Add("�����", typeof(string));
            table1.Columns.Add("�����", typeof(string));
            table1.Columns.Add("���� ���������", typeof(DateTime));
            table1.Columns.Add("��������", typeof(string));
            table1.Columns.Add("ʳ������", typeof(int));
            table1.Columns.Add("���� �����������", typeof(DateTime));
            dataGridView2.DataSource = table1;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Width = 1025;
            creator1.Visible = false;
            deletProduct.Visible = false;
            deleteTable.Visible = false;
            oform.Visible = false;
            textBoxCreator1.Visible = false;
            dataGridView2.Visible = false;
            order.Visible = false;
            Back1.Visible = false;
            count1.Visible = false;
            textBoxCount1.Visible = false;
            datePost1.Visible = false;
            sortButton2.Visible = false;
            restart2.Visible = false;
            sortButton1.Visible = true;
            restart.Visible = true;
            dateTimePickerDatePost1.Visible = false;
            buy.Visible = false;
            addProduct1.Visible = false;
            Back.Visible = true;
            name1.Visible = true;
            textBoxName1.Visible = true;
            product1.Visible = true;
            comboBoxProduct1.Visible = true;
            save1.Visible = true;
            dateTimePickerSave1.Visible = true;
            search1.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.Location = new Point(220, 84);
            tabel1.Visible = true;
            tabel1.Location = new Point(220, 66);


            table.Clear();
            DateTime currentDate = DateTime.Now;
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
            }
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProduct1_Click(object sender, EventArgs e)
        {
            if (textBoxCount1.Text == "" || comboBoxProduct1.Text == "" || textBoxCreator1.Text == "" || textBoxCount1.Text == "")
            {
                MessageBox.Show("�������� ���!!!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ��������� ������ � ������
                User user = new User();
                user.Name = textBoxName1.Text;
                user.Product = comboBoxProduct1.Text;
                user.Save = dateTimePickerSave1.Value;
                user.Creator = textBoxCreator1.Text;
                user.Count = Convert.ToInt32(textBoxCount1.Text);
                user.Post = dateTimePickerDatePost1.Value;
                users.Add(user);
                // ��������� ������ � �������
                table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
                // ������� ���� �����
                textBoxName1.Clear();
                comboBoxProduct1.SelectedIndex = -1;
                textBoxCreator1.Clear();
                textBoxCount1.Clear();

                // ��������� DataGridView
                dataGridView1.Refresh();
            }

        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            // ���������� �����
            int n = users.Count;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    User temp = users[i];
                    int j = i;
                    while (j >= gap && string.Compare(users[j - gap].Name, temp.Name) > 0)
                    {
                        users[j] = users[j - gap];
                        j -= gap;
                    }
                    users[j] = temp;
                }
                gap /= 2;
            }

            // ������� �������
            table.Clear();

            // ���������� ������� ���������������� �������
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
            }

            // ���������� DataGridView
            dataGridView1.Refresh();
        }

        private void search1_Click(object sender, EventArgs e)
        {
            // ���������� �����
            int n = users.Count;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    User temp = users[i];
                    int j = i;
                    while (j >= gap && string.Compare(users[j - gap].Name, temp.Name) > 0)
                    {
                        users[j] = users[j - gap];
                        j -= gap;
                    }
                    users[j] = temp;
                }
                gap /= 2;
            }

            // ������� �������
            table.Clear();
            DateTime currentDate = DateTime.Now;
            // ���������� ������� ���������������� �������
            foreach (var user in users)
            {
                if (user.Save > currentDate)
                {
                    table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
                }

            }

            // ���������� DataGridView
            dataGridView1.Refresh();
            // ������� �������� ����������
            table.Clear();

            User searchedUser = BinnarySearch(users, textBoxName1.Text, comboBoxProduct1.Text);
            table.Rows.Add(searchedUser.Name, searchedUser.Product, searchedUser.Save, searchedUser.Creator, searchedUser.Count, searchedUser.Post);

            // ��������� DataGridView
            dataGridView1.Refresh();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            table.Clear();
            DateTime currentDate = DateTime.Now;
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
            }
            dataGridView1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buy_Click(object sender, EventArgs e)
        {
            // �������� ������ ��������� ������ � DataGridView1
            int selectedIndex = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index : -1;
            if (textBoxCount1.Text == "")
            {
                MessageBox.Show("���� �����, ����� ������� ������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ���������, ���� �� ������� ������
                if (selectedIndex != -1)
                {
                    // �������� ������ ��������� ������ �� DataGridView1
                    string name = dataGridView1.Rows[selectedIndex].Cells["�����"].Value.ToString();
                    string product = dataGridView1.Rows[selectedIndex].Cells["�����"].Value.ToString();
                    DateTime save = (DateTime)dataGridView1.Rows[selectedIndex].Cells["���� ���������"].Value;
                    string creator = dataGridView1.Rows[selectedIndex].Cells["��������"].Value.ToString();
                    int availableCount = (int)dataGridView1.Rows[selectedIndex].Cells["ʳ������"].Value; // �������� �� ������ ���������� ��������� �������

                    // ���������, ��� ���������� ��������� ������� ������ ����
                    if (availableCount > 0)
                    {
                        // ��������� ���������� ���� ��� ����� ���������� ������
                        int selectedCount = (int)Convert.ToInt32(textBoxCount1.Text); // �������� ���������� ������� �� ��������

                        if (selectedCount > 0 && selectedCount <= availableCount)
                        {
                            // ������� ������ User � ������������ ������� � ��������� ����������� ������
                            User user = new User(name, product, save, creator, selectedCount, DateTime.Now);

                            // ��������� ������ User �� ������ ������� � ������
                            users1.Add(user);
                            table1.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);


                            int newAvailableCount = availableCount - selectedCount;
                            dataGridView1.Rows[selectedIndex].Cells["ʳ������"].Value = newAvailableCount;
                            users[selectedIndex] = new User(users[selectedIndex].Name, users[selectedIndex].Product, users[selectedIndex].Save, users[selectedIndex].Creator, newAvailableCount, users[selectedIndex].Post); //���������

                            // ���� ���������� ��������� ������� ����� ������ 0, ������� ������ �� ������ �������
                            if (newAvailableCount == 0)
                            {
                                dataGridView1.Rows.RemoveAt(selectedIndex);
                                users.RemoveAt(selectedIndex);
                            }
                        }
                        else
                        {
                            MessageBox.Show("���� �����, ����� �������� ������� ������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("����� ���������!", "������� ���������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {
            Width = 1025;
            creator1.Visible = false;
            deleteTable.Visible = false;
            textBoxCreator1.Visible = false;
            name1.Visible = false;
            textBoxName1.Visible = false;
            product1.Visible = false;
            comboBoxProduct1.Visible = false;
            count1.Visible = true;
            textBoxCount1.Visible = true;
            datePost1.Visible = false;
            dateTimePickerDatePost1.Visible = false;
            save1.Visible = false;
            dateTimePickerSave1.Visible = false;
            addProduct1.Visible = false;
            Back.Visible = false;
            Back1.Visible = true;
            dataGridView1.Visible = false;
            buy.Visible = true;
            order.Visible = false;
            count1.Visible = false;
            textBoxCount1.Visible = false;
            buy.Visible = false;
            search1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView2.Location = new Point(224, 84);
            tabel1.Visible = true;
            oform.Visible = true;
            tabel1.Location = new Point(224, 66);
            oform.Location = new Point(224, 281);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            table.Clear();
            DateTime currentDate = DateTime.Now;
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
            }
            dataGridView1.Refresh();
            Width = 1025;
            creator1.Visible = false;
            textBoxCreator1.Visible = false;
            deleteTable.Visible = false;
            deletProduct.Visible = false;
            count1.Visible = true;
            textBoxCount1.Visible = true;
            dataGridView2.Visible = false;
            datePost1.Visible = false;
            oform.Visible = false;
            Back1.Visible = false;
            search1.Visible = true;
            sortButton2.Visible = true;
            restart2.Visible = true;
            name1.Visible = true;
            textBoxName1.Visible = true;
            product1.Visible = true;
            comboBoxProduct1.Visible = true;
            save1.Visible = true;
            dateTimePickerSave1.Visible = true;
            dateTimePickerDatePost1.Visible = false;
            addProduct1.Visible = false;
            Back.Visible = true;
            dataGridView1.Visible = true;
            buy.Visible = true;
            order.Visible = true;
            dataGridView1.Location = new Point(359, 84);
            tabel1.Visible = true;
            tabel1.Location = new Point(359, 66);
        }

        private void restart2_Click(object sender, EventArgs e)
        {
            table.Clear();
            DateTime currentDate = DateTime.Now;
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
            }
            dataGridView1.Refresh();
        }


        private void sortButton2_Click(object sender, EventArgs e)
        {
            // ���������� �����
            int n = users.Count;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    User temp = users[i];
                    int j = i;
                    while (j >= gap && string.Compare(users[j - gap].Name, temp.Name) > 0)
                    {
                        users[j] = users[j - gap];
                        j -= gap;
                    }
                    users[j] = temp;
                }
                gap /= 2;
            }

            // ������� �������
            table.Clear();
            DateTime currentDate = DateTime.Now;
            // ���������� ������� ���������������� �������
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
            }

            // ���������� DataGridView
            dataGridView1.Refresh();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Width = 525;
            sortButton1.Visible = true;
            restart2.Visible = false;
            oform.Visible = false;
            buy.Visible = false;
            order.Visible = false;
            tabel2.Visible = false;
            dataGridView2.Visible = false;
            creator1.Visible = true;
            textBoxCreator1.Visible = true;
            count1.Visible = true;
            textBoxCount1.Visible = true;
            datePost1.Visible = true;
            dateTimePickerDatePost1.Visible = true;
            addProduct1.Visible = true;
            Back.Visible = false;
            dataGridView1.Visible = false;
            tabel1.Visible = false;
            search1.Visible = true;
            restart.Visible = true;

        }

        private void oform_Click(object sender, EventArgs e)
        {
            users1.Clear();
            table1.Clear();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Width = 1025;
            dataGridView1.Location = new Point(220, 84);
            deletProduct.Visible = true;
            deleteTable.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            sortButton2.Visible = false;
            addProduct1.Visible = false;
            restart2.Visible = false;
            restart.Visible = false;
            buy.Visible = false;
            order.Visible = false;
            sortButton1.Visible = false;
            sortButton2.Visible = false;
            search1.Visible = false;
            oform.Visible = false;
            tabel2.Visible = false;
            dataGridView2.Visible = false;
            tabel1.Visible = false;
            Back.Visible = true;
            Back1.Visible = false;
            textBoxCount1.Visible = true;
            DateTime currentDate = DateTime.Now;
            table.Clear();
            foreach (var user in users)
            {
                if (user.Save < currentDate)
                {
                    table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
                }
            }
            dataGridView1.Refresh();

        }

        private void Back1_Click(object sender, EventArgs e)
        {
            table.Clear();
            DateTime currentDate = DateTime.Now;
            foreach (var user in users)
            {
                if (user.Save > currentDate)
                {
                    table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);
                }
            }
            dataGridView1.Refresh();
            Width = 1025;
            creator1.Visible = false;
            textBoxCreator1.Visible = false;
            count1.Visible = true;
            textBoxCount1.Visible = true;
            datePost1.Visible = false;
            deleteTable.Visible = false;
            oform.Visible = false;
            dateTimePickerDatePost1.Visible = false;
            addProduct1.Visible = false;
            Back.Visible = true;
            dataGridView1.Visible = true;
            name1.Visible = true;
            textBoxName1.Visible = true;
            product1.Visible = true;
            comboBoxProduct1.Visible = true;
            save1.Visible = true;
            dateTimePickerSave1.Visible = true;
            Back1.Visible = false;
            buy.Visible = true;
            order.Visible = true;
            search1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView1.Location = new Point(359, 84);
            tabel1.Visible = true;
            tabel1.Location = new Point(359, 66);
        }

        private void deletProduct_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            int index = 0;

            // ������� ����� ��������� users ��� �������� ������������ ������� �� �������� ���������
            List<User> usersToRemove = new List<User>();

            // ���������� �������������
            foreach (var user in users.ToList()) // ������� ����� users ��� ����������� �������� ��������� � �����
            {
                // ���� ���� ���������� ������ ������ ������� ����
                if (user.Save < currentDate)
                {
                    // ��������� ������ � ������������ ������ � �������
                    table.Rows.Add(user.Name, user.Product, user.Save, user.Creator, user.Count, user.Post);

                    // ��������� ������������ ����� � ������ ��� �������� �� �������� ���������
                    usersToRemove.Add(user);
                }
                index++;
            }

            // ������� ������������ ������ �� �������� ���������
            foreach (var userToRemove in usersToRemove)
            {
                users.Remove(userToRemove);
            }
            table.Clear();
            // ��������� ����������� DataGridView
            dataGridView1.Refresh();
        }
        private void SaveXML(string filePath, List<User> users)
        {
            // ������� ��������� XmlSerializer
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

            // ������� �������� ����� ��� ������ � XML ����
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                // ����������� ������ ������������� � ���������� ��� � ����
                serializer.Serialize(fs, users);
            }

            MessageBox.Show("������ ������� ��������� � XML ����: " + filePath);
        }
        private void LoadXML(string filePath, List<User> users)
        {
            // ��������� ������������� �����
            if (!File.Exists(filePath))
            {
                MessageBox.Show("���� �� ������: " + filePath);
                return;
            }

            // ������� ��������� XmlSerializer
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

            // ������� �������� ����� ��� ������ �� XML �����
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                // ������������� ������ �� ����� � ������ �������������
                List<User> loadedUsers = (List<User>)serializer.Deserialize(fs);

                // ������� ������������ ������ ������������� � ��������� ����������� ������
                users.Clear();
                users.AddRange(loadedUsers);
            }

            MessageBox.Show("������ ������� ��������� �� XML �����: " + filePath);
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveXML(saveFileDialog.FileName, users);
            }
        }


        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadXML(openFileDialog.FileName, users);
            }
        }
    }
}

