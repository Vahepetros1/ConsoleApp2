using System;

namespace ConsoleApp2
{
    public class Students
    {
        public static int id = 0;
        public int StudentId { get; set; }
        public string   FIO { get; set; }
        public DateTime Birthday { get; set; }
        public string Facultet{ get; set; } 
        public string Group{ get; set; }


        public Students()
        {
            id++;
            this.StudentId = id;
        }
        
    }
}