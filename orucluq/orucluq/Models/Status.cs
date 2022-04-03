using System;
using System.Collections.Generic;
using System.Text;

namespace orucluq.Models
{
    class Status
    {
        private static int _id;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }
        public Status(string title, string content)
        {
            DateTime data = DateTime.Now;
            _id++;
            Id = _id;
            Title = title;
            Content = content;
            SharedDate = data;

            
            
        }

        public void GetStatusInfo()
        {
            DateTime EndTime = DateTime.Now;
            TimeSpan Ago = EndTime - SharedDate;
            
            Console.WriteLine( $"Id:{Id}\nTitle: {Title}\nContent: {Content}\nShared {Math.Round(Ago.TotalSeconds)} seconds ago");
        }
    }

    


}
