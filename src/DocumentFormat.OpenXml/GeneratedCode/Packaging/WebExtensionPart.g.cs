﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WebExtensionPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class WebExtensionPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.webextension+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/webextension";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the WebExtensionPart OpenXmlType
        /// </summary>
        internal protected WebExtensionPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the ImageParts of the WebExtensionPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "webextension";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../webextensions";

        /// <summary>
        /// Adds a ImagePart to the WebExtensionPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the WebExtensionPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType, string id)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the WebExtensionPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType, string id)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the WebExtensionPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType);
        }

        /// <inheritdoc/>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }

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
                _partConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal)
                {
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                        new PartConstraintRule(nameof(ImagePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    }
                };
            }

            return _partConstraint;
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2013);
        }
    }
}
