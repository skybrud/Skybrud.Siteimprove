using Newtonsoft.Json.Linq;
using Skybrud.Siteimprove.Objects.Common.Aggregations;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Siteimprove.Objects.Analytics.Visitors {
    
    public class SiteimproveAnalyticsDevicesListAggregations : SiteimproveObject {

        #region Properties
            
        public SiteimproveAnalyticsSumAggregation Visits { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsDevicesListAggregations(JObject obj) : base(obj) {
            Visits = obj.GetObject("visits", SiteimproveAnalyticsSumAggregation.Parse);
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsDevicesListAggregations Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsDevicesListAggregations(obj);
        }

        #endregion

    }

}