﻿using System;
using Skybrud.Essentials.Http;
using Skybrud.Integrations.Siteimprove.Models.Analytics.Behavior;

namespace Skybrud.Integrations.Siteimprove.Responses.Analytics.Behavior {

    public class SiteimproveAnalyticsVisitLengthResponse : SiteimproveResponse<SiteimproveAnalyticsVisitLengthGraphList> {

        #region Constructors

        private SiteimproveAnalyticsVisitLengthResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SiteimproveAnalyticsVisitLengthGraphList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SiteimproveAnalyticsVisitLengthResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SiteimproveAnalyticsVisitLengthResponse"/>.</returns>
        public static SiteimproveAnalyticsVisitLengthResponse ParseResponse(IHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new SiteimproveAnalyticsVisitLengthResponse(response);

        }

        #endregion

    }

}