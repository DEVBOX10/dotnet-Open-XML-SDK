﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the SlicersPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicersPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.slicer+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/slicer";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the SlicersPart OpenXmlType
        /// </summary>
        internal protected SlicersPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "slicer";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../slicers";

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint is null)
            {
                _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
            }

            return _dataPartReferenceConstraint;
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint is null)
            {
                _partConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
            }

            return _partConstraint;
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2010);
        }
    }
}
