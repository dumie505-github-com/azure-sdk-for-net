// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Models;

namespace Azure.Search
{
    /// <summary> Parameters for filtering, sorting, faceting, paging, and other search query behaviors. </summary>
    public partial class SearchOptions
    {
        /// <summary> A string tag that is appended to hit highlights. Must be set with highlightPreTag. Default is &amp;lt;/em&amp;gt;. </summary>
        public string HighlightPostTag { get; set; }
        /// <summary> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. Default is &amp;lt;em&amp;gt;. </summary>
        public string HighlightPreTag { get; set; }
        /// <summary> A number between 0 and 100 indicating the percentage of the index that must be covered by a search query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 100. </summary>
        public double? MinimumCoverage { get; set; }
        /// <summary> A value that specifies the syntax of the search query. The default is &apos;simple&apos;. Use &apos;full&apos; if your query uses the Lucene query syntax. </summary>
        public SearchQueryType? QueryType { get; set; }
        /// <summary> The name of a scoring profile to evaluate match scores for matching documents in order to sort the results. </summary>
        public string ScoringProfile { get; set; }
        /// <summary> A value that specifies whether any or all of the search terms must be matched in order to count the document as a match. </summary>
        public SearchMode? SearchMode { get; set; }
        /// <summary> The number of search results to skip. This value cannot be greater than 100,000. If you need to scan documents in sequence, but cannot use skip due to this limitation, consider using orderby on a totally-ordered key and filter with a range query instead. </summary>
        public int? Skip { get; set; }
    }
}