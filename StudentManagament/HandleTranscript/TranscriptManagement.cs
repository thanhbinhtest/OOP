using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentManagament.HandleTranscript
{
    internal class TranscriptManagement : IManagement<Transcript>
    {
        public bool WriteDataToFile(List<Transcript> transcripts)
        {

            List<object> list = new List<object>();

            foreach (Transcript transcript in transcripts)
            {
                List<object> list1 = new List<object>();

                List<ClassScore> scores = transcript.GetListScores();

                foreach (ClassScore score in scores)
                {
                    var obj1 = new
                    {
                        ClassID = score.GetClassID(),
                        Score = score.GetScore(),
                        Status = score.GetStatus()
                    };

                    list1.Add(obj1);
                }    

                var obj = new
                {
                    StudentID = transcript.GetStudentID(),
                    ListScores = list1,
                };

                list.Add(obj);
            }

            string pathFile = Environment.CurrentDirectory + "\\data_transcripts.xml";

            if (!File.Exists(pathFile))
            {
                FileStream file = File.Create(pathFile);
                file.Close();
            }

            FileStream stream = File.OpenWrite(pathFile);

            if (stream == null)
                return false;

            try
            {
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(writer, list);
            }
            catch (Exception e)
            {
                stream.Close();
                return false;
            }

            stream.Close();

            return true;
        }
        public bool Add(Transcript transcript)
        {
            List<Transcript> transcripts = GetAll();

            if (transcripts == null)
                transcripts = new List<Transcript>();

            transcripts.Add(transcript);

            return WriteDataToFile(transcripts);
        }

        public List<Transcript>? GetAll()
        {
            List<Transcript> transcripts = new List<Transcript>();

            string pathFile = Environment.CurrentDirectory + "\\data_transcripts.xml";

            if (!File.Exists(pathFile))
            {
                FileStream file = File.Create(pathFile);
                file.Close();
            }

            FileStream stream = File.OpenRead(pathFile);

            if (stream == null)
                return null;

            List<object> list = new List<object>();

            try
            {
                StreamReader reader = new StreamReader(stream);
                JsonSerializer serializer = new JsonSerializer();
                list = serializer.Deserialize(reader, typeof(List<object>)) as List<object>;
            }
            catch (Exception e)
            {
                stream.Close();
                return null;
            }

            if (list == null)
            {
                stream.Close();
                return transcripts;
            }

            for (int i = 0; i < list.Count; ++i)
            {
                Newtonsoft.Json.Linq.JObject obj = (Newtonsoft.Json.Linq.JObject)list[i];

                Transcript transcript = new Transcript(
                    (string)obj["StudentID"]
                    );

                List<ClassScore> scores = new List<ClassScore>();

                foreach(var item in obj["ListScores"])
                {
                    ClassScore score = new ClassScore((string)item["ClassID"], (double)item["Score"], (int)item["Status"]);
                    scores.Add(score);
                }

                transcript.SetListScores(scores);

                transcripts.Add(transcript);

            }

            stream.Close();

            return transcripts;
        }

        public Transcript? GetByID(string ID)
        {
            List<Transcript> transcripts = GetAll();

            foreach (Transcript item in transcripts)
            {
                if (item.GetStudentID() == ID)
                    return item;
            }

            return null;
        }

        public bool Update(Transcript transcript)
        {
            List<Transcript> transcripts = GetAll();

            if (transcripts == null)
                return false;

            for (int i = 0; i < transcripts.Count; ++i)
            {
                if (transcripts[i].GetStudentID() == transcript.GetStudentID())
                {
                    transcripts[i] = transcript;
                    return WriteDataToFile(transcripts);
                }
            }

            return false;
        }

        public bool Delete(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
