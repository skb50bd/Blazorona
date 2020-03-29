namespace Blazorona
{
    public class CountryData
    {
        public string Country { get; set; }
        public CountryInfo CountryInfo { get; set; }
        public int TodayCases { get; set; }
        public int TodayDeaths { get; set; }
        public int Cases { get; set; }
        public int Deaths { get; set; }
        public int Recovered { get; set; }
        public int Active { get; set; }
        public int Critical { get; set; }
        public float? CasesPerOneMillion { get; set; }
        public float? DeathsPerOneMillion { get; set; }
    }
}