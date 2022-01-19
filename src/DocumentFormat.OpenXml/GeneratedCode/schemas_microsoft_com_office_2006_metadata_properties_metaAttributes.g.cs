﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.MetaAttributes
{
    /// <summary>
    /// <para>Defines the Dummy Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ma:DummyContentTypeElement.</para>
    /// </summary>
    [SchemaAttr("ma:DummyContentTypeElement")]
    public partial class Dummy : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Dummy class.
        /// </summary>
        public Dummy() : base()
        {
        }

        /// <summary>
        /// <para>decimals</para>
        /// <para>Represents the following attribute in the schema: decimals</para>
        /// </summary>
        [SchemaAttr("decimals")]
        public StringValue? Decimals
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>default</para>
        /// <para>Represents the following attribute in the schema: default</para>
        /// </summary>
        [SchemaAttr("default")]
        public StringValue? Default
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>displayName</para>
        /// <para>Represents the following attribute in the schema: displayName</para>
        /// </summary>
        [SchemaAttr("displayName")]
        public StringValue? DisplayName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fieldsID</para>
        /// <para>Represents the following attribute in the schema: fieldsID</para>
        /// </summary>
        [SchemaAttr("fieldsID")]
        public StringValue? FieldsID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>format</para>
        /// <para>Represents the following attribute in the schema: format</para>
        /// </summary>
        [SchemaAttr("format")]
        public StringValue? Format
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr("hidden")]
        public StringValue? Hidden
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>index</para>
        /// <para>Represents the following attribute in the schema: index</para>
        /// </summary>
        [SchemaAttr("index")]
        public Int32Value? Index
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>internalName</para>
        /// <para>Represents the following attribute in the schema: internalName</para>
        /// </summary>
        [SchemaAttr("internalName")]
        public StringValue? InternalName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>LCID</para>
        /// <para>Represents the following attribute in the schema: LCID</para>
        /// </summary>
        [SchemaAttr("LCID")]
        public Int32Value? LCID
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>list</para>
        /// <para>Represents the following attribute in the schema: list</para>
        /// </summary>
        [SchemaAttr("list")]
        public StringValue? List
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>percentage</para>
        /// <para>Represents the following attribute in the schema: percentage</para>
        /// </summary>
        [SchemaAttr("percentage")]
        public StringValue? Percentage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>readOnly</para>
        /// <para>Represents the following attribute in the schema: readOnly</para>
        /// </summary>
        [SchemaAttr("readOnly")]
        public StringValue? ReadOnly
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>requiredMultiChoice</para>
        /// <para>Represents the following attribute in the schema: requiredMultiChoice</para>
        /// </summary>
        [SchemaAttr("requiredMultiChoice")]
        public StringValue? RequiredMultiChoice
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>root</para>
        /// <para>Represents the following attribute in the schema: root</para>
        /// </summary>
        [SchemaAttr("root")]
        public EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues>? Root
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showField</para>
        /// <para>Represents the following attribute in the schema: showField</para>
        /// </summary>
        [SchemaAttr("showField")]
        public StringValue? ShowField
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>web</para>
        /// <para>Represents the following attribute in the schema: web</para>
        /// </summary>
        [SchemaAttr("web")]
        public StringValue? Web
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ma:DummyContentTypeElement");
            builder.AddElement<Dummy>()
                .AddAttribute("decimals", a => a.Decimals)
                .AddAttribute("default", a => a.Default)
                .AddAttribute("description", a => a.Description)
                .AddAttribute("displayName", a => a.DisplayName)
                .AddAttribute("fieldsID", a => a.FieldsID)
                .AddAttribute("format", a => a.Format)
                .AddAttribute("hidden", a => a.Hidden)
                .AddAttribute("index", a => a.Index, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
                })
                .AddAttribute("internalName", a => a.InternalName)
                .AddAttribute("LCID", a => a.LCID)
                .AddAttribute("list", a => a.List)
                .AddAttribute("percentage", a => a.Percentage)
                .AddAttribute("readOnly", a => a.ReadOnly)
                .AddAttribute("requiredMultiChoice", a => a.RequiredMultiChoice)
                .AddAttribute("root", a => a.Root)
                .AddAttribute("showField", a => a.ShowField)
                .AddAttribute("web", a => a.Web, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { Pattern = ("[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Dummy>(deep);
    }

    /// <summary>
    /// Defines the TrueOnlyValues enumeration.
    /// </summary>
    public enum TrueOnlyValues
    {
        /// <summary>
        /// true.
        /// <para>When the item is serialized out as xml, its value is "true".</para>
        /// </summary>
        [EnumString("true")]
        True
    }
}