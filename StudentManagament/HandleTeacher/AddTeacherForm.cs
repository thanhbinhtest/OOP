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
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
            btnMen.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TeacherManagement teacherManagament = new TeacherManagement();

            string citizenIdentificationCode = txtCCCD.Text;
            string name = txtName.Text;
            string birthday = txtBirthday.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            int sex = 1;

            if (btnWoman.Checked)
                sex = 2;

            if (citizenIdentificationCode.Length == 0
                || name.Length == 0
                || email.Length == 0
                || phone.Length == 0
                || address.Length == 0)
            {
                MessageBox.Show("Không được để trống");
                return;
            }


            if (!email.Contains("@"))
            {
                MessageBox.Show("Sai cấu trúc email");
                return;
            }

            if (phone.Length != 10)
            {
                MessageBox.Show("Sai cấu trúc số điện thoại");
                return;
            }

            string teacherID = "T-" + DateTime.Now.Year.ToString();

            List<Teacher> teachers = teacherManagament.GetAll();

            int Count = 0;

            if (teachers == null || teachers.Count == 0)
                Count = 0;
            else
            {
                string ID = teachers[teachers.Count - 1].GetTeacherID();

                string numberID = ID.Substring(teacherID.Length, ID.Length - teacherID.Length);

                Count = Int32.Parse(numberID);
            }

            if (Count >= 0 && Count < 10)
            {
                Count++;
                teacherID += "000" + Count.ToString();
            }
            else if (Count >= 10 && Count < 100)
            {
                Count++;
                teacherID += "00" + Count.ToString();
            }
            else if (Count >= 100 && Count < 1000)
            {
                Count++;
                teacherID += "0" + Count.ToString();
            }
            else
            {
                teacherID += Count.ToString();
            }

            Teacher teacher =
                new Teacher(citizenIdentificationCode,
                name,
                birthday,
                sex,
                phone,
                address,
                email,
                teacherID);

            teacher.SetPassword(teacherID);

            if (teacherManagament.Add(teacher))
            {
                MessageBox.Show("Thêm thành công");

                txtCCCD.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";

                txtBirthday.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
