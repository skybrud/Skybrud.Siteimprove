﻿using Skybrud.Siteimprove.Endpoints.Raw;
using Skybrud.Siteimprove.Options.QualityAssurance.BrokenLinks;
using Skybrud.Siteimprove.Responses.QualityAssurance;
using Skybrud.Siteimprove.Responses.QualityAssurance.BrokenLinks;

namespace Skybrud.Siteimprove.Endpoints {

    public class SiteimproveQualityAssuranceEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Siteimprove service.
        /// </summary>
        public SiteimproveService Service { get; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public SiteimproveQualityAssuranceRawEndpoint Raw => Service.Client.QualityAssurance;

        public SiteimproveBrokenLinksEndpoint BrokenLinks { get; }

        public SiteimproveSpellingEndpoint Spelling { get; }

        #endregion

        #region Constructors

        internal SiteimproveQualityAssuranceEndpoint(SiteimproveService service) {
            Service = service;
            BrokenLinks = new SiteimproveBrokenLinksEndpoint(service);
            Spelling = new SiteimproveSpellingEndpoint(service);
        }

        #endregion

        #region Member methods

        public SiteimproveGetQualityAssuranceSummaryResponse GetSummary(long siteId) {
            return SiteimproveGetQualityAssuranceSummaryResponse.ParseResponse(Raw.GetSummary(siteId));
        }

        public SiteimproveGetQualityAssuranceSummaryResponse GetSummary(long siteId, long groupId) {
            return SiteimproveGetQualityAssuranceSummaryResponse.ParseResponse(Raw.GetSummary(siteId, groupId));
        }

        public SiteimproveGetQualityAssuranceSummaryResponse GetSummary(SiteimproveGetQualityAssuranceSummaryOptions options) {
            return SiteimproveGetQualityAssuranceSummaryResponse.ParseResponse(Raw.GetSummary(options));
        }

        #endregion

    }

}