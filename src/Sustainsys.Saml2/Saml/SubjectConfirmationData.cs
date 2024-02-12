﻿namespace Sustainsys.Saml2.Saml;

/// <summary>
/// SubjectConfirmationData, Core 2.4.1.2
/// </summary>
public class SubjectConfirmationData
{
    /// <summary>
    /// Not before
    /// </summary>
    public DateTime? NotBefore { get; set; }

    /// <summary>
    /// Not on or after
    /// </summary>
    public DateTime? NotOnOrAfter {  get; set; }

    /// <summary>
    /// Recipient, for Web SSO this must be the 
    /// AssertionConsumerService URL (Profile 4.1.4.3)
    /// </summary>
    public string? Recipient { get; set; }

    /// <summary>
    /// Id of the request that this assertion was created to respond to.
    /// </summary>
    public string? InResponseTo { get; set; }

    /// <summary>
    /// Expected IP address of the user agent.
    /// </summary>
    public string? Address { get; set; }
}