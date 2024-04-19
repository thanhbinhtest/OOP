namespace StudentManagament.HandleTranscript
{
    internal class ClassScore
    {
        private string classID;
        private double score;
        private int status;
        public ClassScore(string classID, double score, int status)
        {
            this.classID = classID;
            this.score = score;
            this.status = status;
        }

        public string GetClassID() { return classID; }  
        public double GetScore() { return score; }  
        public int GetStatus() { return status; }  
        public void SetScore(double score) { this.score = score;}
        public void SetStatus(int status) { this.status = status; }
    }
}
