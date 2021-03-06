﻿using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.Analytics.Overview;

namespace Skybrud.Integrations.Siteimprove.Responses.Analytics.Overview {

    public class SiteimproveAnalyticsHistoryResponse : SiteimproveResponse<SiteimproveAnalyticsOverviewList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        public SiteimproveAnalyticsHistoryResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, SiteimproveAnalyticsOverviewList.Parse);
        }

    }

}