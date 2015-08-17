﻿using Microsoft.Xrm.Sdk.Client;

namespace JosephM.Xrm.WorkflowScheduler
{
    public interface IXrmConfiguration
    {
        AuthenticationProviderType AuthenticationProviderType { get; }
        string DiscoveryServiceAddress { get; }
        string OrganizationUniqueName { get; }
        string Domain { get; }
        string Username { get; }
        string Password { get; }
    }
}