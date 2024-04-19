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
    public partial class UpdateCourseForm : Form
    {
        private Course course;
        public UpdateCourseForm()
        {
            InitializeComponent();
        }

        public void SetData(string courseID)
        {
            CourseManagement courseManagament = new CourseManagement();

            course = courseManagament.GetByID(courseID);

            if (course == null)
                return;

            txtName.Text = course.GetNameCourse();

            if(course.GetType() == typeof(RegularCourse))
            {
                RegularCourse regularCourse = (RegularCourse)course;
                txtCredit.Text = regularCourse.GetCreditsNumber().ToString();
                radioReg.Checked = true;
                radioPost.Enabled = false;
                txtHour.Enabled = false;
            }  
            else if(course.GetType() == typeof(PostgraduateCourse))
            {
                PostgraduateCourse postgraduateCourse = (PostgraduateCourse)course;
                txtHour.Text = postgraduateCourse.GetHourOfResearch().ToString();
                radioReg.Enabled = false;
                radioPost.Checked = true;
                txtCredit.Enabled = false;
            }    
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (txtName.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }

            if (radioReg.Checked)
            {
                if (txtCredit.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }

                CourseManagement courseManagament = new CourseManagement();

                List<RegularCourse> list = courseManagament.GetAllRegularCourse();

                string courseID = this.course.GetCourseID();

                int creditsNumber = 0;

                if(!Int32.TryParse(txtCredit.Text, out creditsNumber))
                {
                    MessageBox.Show("Định dạng số tín chỉ sai");
                    return;
                }    

                if(creditsNumber > 10 || creditsNumber < 1)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0 và nhỏ hơn 10");
                    return;
                }    

                RegularCourse course = new RegularCourse(courseID, name, creditsNumber);

                if (courseManagament.Update(course))
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thất bại");
                }
            }
            else if (radioPost.Checked)
            {
                if (txtHour.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }

                CourseManagement courseManagament = new CourseManagement();

                List<PostgraduateCourse> list = courseManagament.GetAllPostgraduateCourse();

                string courseID = this.course.GetCourseID();

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

                if (courseManagament.Update(course))
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thất bại");
                }
            }
        }
    }
}
