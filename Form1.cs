private System.Windows.Forms.TextBox txtID;
private System.Windows.Forms.TextBox txtName;
private System.Windows.Forms.TextBox txtAge;
private System.Windows.Forms.TextBox txtMajor;
private System.Windows.Forms.TextBox txtSearch;
private System.Windows.Forms.Button btnAdd;
private System.Windows.Forms.Button btnDelete;
private System.Windows.Forms.Button btnSearch;
private System.Windows.Forms.DataGridView dataGridView1;

private void InitializeComponent()
{
    this.txtID = new TextBox();
    this.txtName = new TextBox();
    this.txtAge = new TextBox();
    this.txtMajor = new TextBox();
    this.txtSearch = new TextBox();
    this.btnAdd = new Button();
    this.btnDelete = new Button();
    this.btnSearch = new Button();
    this.dataGridView1 = new DataGridView();

    this.SuspendLayout();

    txtID.Location = new System.Drawing.Point(20,20);
    txtID.PlaceholderText = "ID";

    txtName.Location = new System.Drawing.Point(20,50);
    txtName.PlaceholderText = "Tên";

    txtAge.Location = new System.Drawing.Point(20,80);
    txtAge.PlaceholderText = "Tuổi";

    txtMajor.Location = new System.Drawing.Point(20,110);
    txtMajor.PlaceholderText = "Ngành";

    btnAdd.Text = "Thêm";
    btnAdd.Location = new System.Drawing.Point(20,150);
    btnAdd.Click += new EventHandler(btnAdd_Click);

    btnDelete.Text = "Xoá";
    btnDelete.Location = new System.Drawing.Point(100,150);
    btnDelete.Click += new EventHandler(btnDelete_Click);

    txtSearch.Location = new System.Drawing.Point(20,190);
    txtSearch.PlaceholderText = "Tìm theo tên";

    btnSearch.Text = "Tìm";
    btnSearch.Location = new System.Drawing.Point(200,190);
    btnSearch.Click += new EventHandler(btnSearch_Click);

    dataGridView1.Location = new System.Drawing.Point(20,230);
    dataGridView1.Size = new System.Drawing.Size(500,200);

    this.Controls.Add(txtID);
    this.Controls.Add(txtName);
    this.Controls.Add(txtAge);
    this.Controls.Add(txtMajor);
    this.Controls.Add(btnAdd);
    this.Controls.Add(btnDelete);
    this.Controls.Add(txtSearch);
    this.Controls.Add(btnSearch);
    this.Controls.Add(dataGridView1);

    this.ClientSize = new System.Drawing.Size(600,460);
    this.Text = "Quản Lý Sinh Viên";

    this.Load += new EventHandler(Form1_Load);
    this.ResumeLayout(false);
}
