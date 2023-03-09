

namespace HttpRequestJSON.Models
{

    public class ExchangeInfo
    {
        public string Timezone { get; set; }
        public long ServerTime { get; set; }
        public object[] RateLimits { get; set; }
        public object[] ExchangeFilters { get; set; }
        public List<SymbolInfo> Symbols { get; set; }
    }

}
