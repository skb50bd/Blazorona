using System;

namespace Blazorona
{
    public class Data {
        public int Cases { get; set; }
        public string _Cases => Cases.ToString("n0");
        
        public int Deaths { get; set; }
        public string _Deaths => Deaths.ToString("n0");
        
        public int Recovered { get; set; }
        public string _Recovered => Recovered.ToString("n0");

        public int Active { get; set; }
        public string _Active => Active.ToString("n0");

        public int Closed => Cases - Active;
        public string _Closed => Closed.ToString("n0");

        public long Updated { get; set; }
        public DateTime UpdateTime => 
            DateTime.UnixEpoch.AddMilliseconds(Updated);

        public string _Updated => 
            UpdateTime.ToString("MMMM dd, yyyy, HH:mm");
    }
}