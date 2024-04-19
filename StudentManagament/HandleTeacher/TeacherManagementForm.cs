using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament.HandleTeacher
{
    public partial class TeacherManagementForm : Form
    {
        private string teacherID;
        public TeacherManagementForm()
        {
            InitializeComponent();

            dataTeachers.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataTeachers.CurrentRow;

            if (currentRow == null)
                return;

            teacherID = dataTeachers.CurrentRow.Cells[0].Value.ToString();
        }

        private void LoadTeachers(List<Teacher> list)
        {
            if (list == null)
                list = new List<Teacher>();

            DataTable dt = new DataTable();

            dt.Columns.Add("MSGV");
            dt.Columns.Add("Tên giảng viên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Email");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Địa chỉ");

            foreach (Teacher item in list)
            {
                string sex = "Nam";
                if (item.GetSex() == 2)
                    sex = "Nữ";

                dt.Rows.Add(new object[] {
                    item.GetTeacherID(),
                    item.GetName(),
                    item.GetBirthday(),
                    sex,
                    item.GetCitizenIdentificationCode(),
                    item.GetEmail(),
                    item.GetPhone(),
                    item.GetAddress(),
                });
            }

            dataTeachers.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherManagamentForm_Load(object sender, EventArgs e)
        {
            TeacherManagement teacherManagament = new TeacherManagement();

            LoadTeachers(teacherManagament.GetAll());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();

            addTeacherForm.ShowDialog();

            TeacherManagement teacherManagament = new TeacherManagement();

            LoadTeachers(teacherManagament.GetAll());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTeacherForm updateTeacherForm = new UpdateTeacherForm();

            updateTeacherForm.SetData(teacherID);

            updateTeacherForm.ShowDialog();

            TeacherManagement teacherManagament = new TeacherManagement();

            LoadTeachers(teacherManagament.GetAll());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TeacherManagement teacherManagament = new TeacherManagement();

            if(teacherManagament.Delete(teacherID))
            {
                MessageBox.Show("Xóa thành công");
            }    
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }    

            LoadTeachers(teacherManagament.GetAll());
        }

        private void txtSeach_Click(object sender, EventArgs e)
        {
            TeacherManagement teacherManagament = new TeacherManagement();

            string search = txtSearch.Text;

            LoadTeachers(teacherManagament.GetByName(search));
        }
    }
}
