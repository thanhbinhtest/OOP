using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
           
            InitializeComponent();

            List<string> list = new List<string>();

            list.Add("Thạc sĩ");
            list.Add("Tiến sĩ");

            cbType.DataSource = list;

            btnMen.Checked = true;
            checkReg.Checked = true;
            txtBirthday.Format= DateTimePickerFormat.Long;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkReg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReg.Checked)
            {
                checkPost.Checked = false;
                cbType.Enabled = false;
            }
        }

        private void checkPost_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPost.Checked)
            {
                checkReg.Checked = false;
                cbType.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagament = new StudentManagement();

            string citizenIdentificationCode = txtCCCD.Text;
            string name = txtName.Text;
            string birthday = txtBirthday.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string major = txtMajor.Text;
            string dayAddmission = txtDayAdd.Text;
            int sex = 1;
            if (btnWoman.Checked)
                sex = 2;

            if (citizenIdentificationCode.Length == 0
                || name.Length == 0
                || email.Length == 0
                || phone.Length == 0
                || address.Length == 0
                || major.Length == 0)
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

            if (checkPost.Checked)
            {
                string type = cbType.Text;

                string studentID = "PS-" + DateTime.Now.Year.ToString();

                List<PostgraduateStudent> postgraduateStudents = studentManagament.GetAllPostgraduateStudents();

                int Count = 0;

                if (postgraduateStudents == null || postgraduateStudents.Count == 0)
                    Count = 0;
                else
                {
                    string ID = postgraduateStudents[postgraduateStudents.Count - 1].GetStudentID();

                    string numberID = ID.Substring(studentID.Length, ID.Length - studentID.Length);

                    Count = Int32.Parse(numberID);
                }

                if (Count >= 0 && Count < 10)
                {
                    Count++;
                    studentID += "000" + Count.ToString();
                }
                else if (Count >= 10 && Count < 100)
                {
                    Count++;
                    studentID += "00" + Count.ToString();
                }
                else if (Count >= 100 && Count < 1000)
                {
                    Count++;
                    studentID += "0" + Count.ToString();
                }
                else
                {
                    studentID += Count.ToString();
                }

                PostgraduateStudent postgraduateStudent =
                    new PostgraduateStudent(citizenIdentificationCode,
                    name,
                    birthday,
                    sex,
                    phone,
                    address,
                    email,
                    studentID,
                    dayAddmission,
                    major,
                    type);

                postgraduateStudent.SetPassword(studentID);

                if (studentManagament.Add(postgraduateStudent))
                {
                    MessageBox.Show("Thêm thành công");

                    txtCCCD.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    txtMajor.Text = "";

                    txtBirthday.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    txtDayAdd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else if (checkReg.Checked)
            {
                string studentID = "RE-" + DateTime.Now.Year.ToString();

                List<RegularStudent> regularStudents = studentManagament.GetAllRegularStudents();

                int Count = 0;

                if (regularStudents == null || regularStudents.Count == 0)
                    Count = 0;
                else
                {
                    string ID = regularStudents[regularStudents.Count - 1].GetStudentID();

                    string numberID = ID.Substring(studentID.Length, ID.Length - studentID.Length);

                    Count = Int32.Parse(numberID);
                }

                if (Count >= 0 && Count < 10)
                {
                    Count++;
                    studentID += "000" + Count.ToString();
                }
                else if (Count >= 10 && Count < 100)
                {
                    Count++;
                    studentID += "00" + Count.ToString();
                }
                else if (Count >= 100 && Count < 1000)
                {
                    Count++;
                    studentID += "0" + Count.ToString();
                }
                else
                {
                    studentID += Count.ToString();
                }

                RegularStudent regularStudent =
                    new RegularStudent(citizenIdentificationCode,
                    name,
                    birthday,
                    sex,
                    phone,
                    address,
                    email,
                    studentID,
                    dayAddmission,
                    major);

                regularStudent.SetPassword(studentID);

                if (studentManagament.Add(regularStudent))
                {
                    MessageBox.Show("Thêm thành công");

                    txtCCCD.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    txtMajor.Text = "";

                    txtBirthday.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    txtDayAdd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
