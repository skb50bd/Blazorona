using System.Collections.Generic;
using System.Linq;

namespace Blazorona
{
    public class AllCountryData
    {
        public AllCountryData()
        {
            Countries = new List<CountryData>();
        }

        public AllCountryData(CountryData[] countries)
        {
            Countries = countries.ToList();
        }

        public List<CountryData> Countries { get; set; }

        private int? _affectedCountryCount;
        public int AffectedCountryCount
        {
            get
            {
                _affectedCountryCount ??= Countries.Count(c => c.Cases > 0);
                return (int)_affectedCountryCount;
            }
        }
        public string _AffectedCountryCount =>
            AffectedCountryCount.ToString("n0");

        private int? _totalCases;
        public int TotalCases {
            get {
                _totalCases ??= Countries.Sum(c => c.Cases);
                return (int)_totalCases;
            }
        }
        public string _TotalCases =>
            TotalCases.ToString("n0");

        public int? _totalDeaths;
        public int TotalDeaths {
            get {
                _totalDeaths ??= Countries.Sum(c => c.Deaths);
                return (int)_totalDeaths;
            }
        }
        public string _TotalDeaths =>
            TotalDeaths.ToString("n0");

        public int? _totalRecovered;
        public int TotalRecovered {
            get {
                _totalRecovered ??= Countries.Sum(c => c.Recovered);
                return (int)_totalRecovered;
            }
        }
        public string _TotalRecovered =>
            TotalRecovered.ToString("n0");

        private int? _critical;
        public int Critical
        {
            get
            {
                _critical ??= Countries.Sum(c => c.Critical);
                return (int)_critical;
            }
        }
        public string _Critical 
            => Critical.ToString("n0");

        private float? _criticalPercent;
        public float CriticalPercent {
            get {
                _criticalPercent ??= Critical * 100F / Active;
                return (float)_criticalPercent;
            }
        }
        public string _CriticalPercent =>
            $"{CriticalPercent:n0}%";
        
        private int? _mild;
        public int Mild {
            get {
                _mild ??= Active - Critical;
                return (int)_mild;
            }
        }
        public string _Mild =>
            Mild.ToString("n0");

        private float? _mildPercent;
        public float MildPercent {
            get {
                _mildPercent ??= Mild * 100F / Active;
                return (float)_mildPercent;
            }
        }
        public string _MildPercent =>
            $"{MildPercent:n0}%";


        private int? _todayCases;
        public int TodayCases {
            get {
                _todayCases ??= Countries.Sum(c => c.TodayCases);
                return (int)_todayCases;
            }
        }
        public string _TodayCases =>
            TodayCases.ToString("n0");

        private int? _todayDeaths;
        public int TodayDeaths {
            get {
                _todayDeaths ??= Countries.Sum(c => c.TodayDeaths);
                return (int)_todayDeaths;
            }
        } 
        public string _TodayDeaths =>
            TodayDeaths.ToString("n0");
    
        private int? _active;
        public int Active {
            get {
                _active ??= Countries.Sum(c => c.Active);
                return (int)_active;
            }
        }
        public string _Active =>
            Active.ToString("n0");

        private int? _closed;
        public int Closed {
            get {
                _closed ??= Countries.Sum(c => c.Cases - c.Active);
                return (int)_active;
            }
        }
        public string _Closed =>
            Active.ToString("n0");
    
        private float? _recoveredPercent;
        public float RecoveredPercent {
            get {
                _recoveredPercent ??= TotalRecovered * 100F / Closed;
                return (float)_recoveredPercent;
            }
        }
        public string _RecoveredPercent =>
            $"{RecoveredPercent:n0}%";

        private float? _deathPercent;
        public float DeathPercent {
            get {
                _deathPercent ??= TotalDeaths * 100F / Closed;
                return (float)_deathPercent;
            }
        }
        public string _DeathPercent =>
            $"{DeathPercent:n0}%";
    }
}