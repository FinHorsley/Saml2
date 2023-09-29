﻿using Sustainsys.Saml2.Metadata.Elements;
using Sustainsys.Saml2.Xml;

namespace Sustainsys.Saml2.Metadata;
partial class MetadataSerializer
{
    /// <summary>
    /// Create extensions object.
    /// </summary>
    /// <returns>Extensions</returns>
    protected virtual Extensions CreateExtensions() => new();

    /// <summary>
    /// Read Extensions node.
    /// </summary>
    /// <param name="source">Soure to read from</param>
    /// <returns>Extensions</returns>
    protected virtual Extensions ReadExtensions(XmlTraverser source)
    {
        source.IgnoreChildren();

        return CreateExtensions();
    }
}