using System.Collections.Generic;

namespace StudentManagament.HandleTranscript
{
    internal class Transcript
    {
        private string studentID;
        private List<ClassScore> listScores;

        public Transcript(string studentID)
        {
            this.studentID = studentID;
        }

        public string GetStudentID()
        { return studentID; }
        public List<ClassScore> GetListScores() 
        {  
            if(listScores == null)
                listScores = new List<ClassScore>(); 
            return listScores; 
        }
        public void SetListScores(List<ClassScore> listScores) { this.listScores = listScores; }
    }
}
