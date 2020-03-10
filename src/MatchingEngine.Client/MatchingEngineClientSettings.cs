namespace MatchingEngine.Client
{
    /// <summary>
    /// Matching engine client settings.
    /// </summary>
    public class MatchingEngineClientSettings
    {
        /// <summary>
        /// The balance service endpoint address.
        /// </summary>
        public string BalancesServiceAddress { get; set; }

        /// <summary>
        /// The balance service endpoint address.
        /// </summary>
        public string OrderBooksServiceAddress { get; set; }
    }
}