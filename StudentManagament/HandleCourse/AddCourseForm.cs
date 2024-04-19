using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament.HandleCourse
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
            radioReg.Checked = true;
            txtHour.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void radioReg_CheckedChanged(object sender, EventArgs e)
        {
            txtHour.Enabled = false;
            txtCredit.Enabled = true;
        }

        private void radioPost_CheckedChanged(object sender, EventArgs e)
        {
            txtCredit.Enabled = false;
            txtHour.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if(txtName.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }    

            if(radioReg.Checked)
            {
                if(txtCredit.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }

                CourseManagement courseManagament = new CourseManagement();

                List<RegularCourse> list = courseManagament.GetAllRegularCourse();

                string courseID = "RC";

                int Count = 0;

                if (list == null || list.Count == 0)
                    Count = 0;
                else
                {
                    string ID = list[list.Count - 1].GetCourseID();

                    string numberID = ID.Substring(courseID.Length, ID.Length - courseID.Length);

                    Count = Int32.Parse(numberID);
                }

                if (Count >= 0 && Count < 10)
                {
                    Count++;
                    courseID += "000" + Count.ToString();
                }
                else if (Count >= 10 && Count < 100)
                {
                    Count++;
                    courseID += "00" + Count.ToString();
                }
                else if (Count >= 100 && Count < 1000)
                {
                    Count++;
                    courseID += "0" + Count.ToString();
                }
                else
                {
                    courseID += Count.ToString();
                }

                int creditsNumber = 0;

                if (!Int32.TryParse(txtCredit.Text, out creditsNumber))
                {
                    MessageBox.Show("Định dạng số tín chỉ sai");
                    return;
                }

                if (creditsNumber > 10 || creditsNumber < 1)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0 và nhỏ hơn 10");
                    return;
                }

                RegularCourse course = new RegularCourse(courseID, name, creditsNumber);

                if(courseManagament.Add(course))
                {
                    MessageBox.Show("Thêm môn học thành công");
                    txtName.Text = "";
                    txtCredit.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm môn học thất bại");
                }    
            }
            else if(radioPost.Checked)
            {
                if (txtHour.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }

                CourseManagement courseManagament = new CourseManagement();

                List<PostgraduateCourse> list = courseManagament.GetAllPostgraduateCourse();

                string courseID = "RP";

                int Count = 0;

                if (list == null || list.Count == 0)
                    Count = 0;
                else
                {
                    string ID = list[list.Count - 1].GetCourseID();

                    string numberID = ID.Substring(courseID.Length, ID.Length - courseID.Length);

                    Count = Int32.Parse(numberID);
                }

                if (Count >= 0 && Count < 10)
                {
                    Count++;
                    courseID += "000" + Count.ToString();
                }
                else if (Count >= 10 && Count < 100)
                {
                    Count++;
                    courseID += "00" + Count.ToString();
                }
                else if (Count >= 100 && Count < 1000)
                {
                    Count++;
                    courseID += "0" + Count.ToString();
                }
                else
                {
                    courseID += Count.ToString();
                }

                int hour = 0;

                if (!Int32.TryParse(txtHour.Text, out hour))
                {
                    MessageBox.Show("Định dạng số giờ nghiên cứu sai");
                    return;
                }

                if (hour < 1)
                {
                    MessageBox.Show("Số giờ nghiên cứu phải lớn hơn 0");
                    return;
                }

                PostgraduateCourse course = new PostgraduateCourse(courseID, name, hour);

                if (courseManagament.Add(course))
                {
                    MessageBox.Show("Thêm môn học thành công");
                    txtName.Text = "";
                    txtHour.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm môn học thất bại");
                }
            }    
        }
    }
}
