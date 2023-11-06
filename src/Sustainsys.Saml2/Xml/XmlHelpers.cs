﻿using System.Security.Cryptography;
using System.Xml;

namespace Sustainsys.Saml2.Xml;

/// <summary>
/// Xml utilities
/// </summary>
public static class XmlHelpers
{
    /// <summary>
    /// Create a valid xs:ID
    /// </summary>
    /// <returns>Id as string</returns>
    public static string CreateId()
    {
        var bytes = RandomNumberGenerator.GetBytes(20);
        return FormatId(bytes);
    }

    // Split to separate function to enable testing of formatting.
    internal static string FormatId(byte[] bytes)
    {
        // Ensure starting char will be a letter.
        bytes[0] = (byte)(bytes[0] & 0x7F);

        // Manually do Base 64 URL as we do not have a reference to Base64UrlTextEncoder here.
        return Convert.ToBase64String(bytes).Replace('+', '-').Replace('/', '_').TrimEnd('=');
    }

    /// <summary>
    /// Get an Xml traverser for an XmlDocument
    /// </summary>
    /// <param name="xmlElement">Source XmlElement. Typically the document element</param>
    /// <returns>XmlTraverser located at DocumentElement</returns>
    public static XmlTraverser GetXmlTraverser(this XmlElement xmlElement)
        => new(xmlElement ?? throw new ArgumentException("DocumentElement cannot be null"));

    /// <summary>
    /// Sets an attribute if the value is not null.
    /// </summary>
    /// <param name="element">Element to set attribute on.</param>
    /// <param name="name">Name of attribute</param>
    /// <param name="value">String value. If null, no attribute is set/created</param>
    public static void SetAttributeIfValue(this XmlElement element, string name, string? value)
    {
        if(value != null)
        {
            element.SetAttribute(name, value);
        }
    }
}
