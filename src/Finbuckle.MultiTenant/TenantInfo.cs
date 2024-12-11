// Copyright Finbuckle LLC, Andrew White, and Contributors.
// Refer to the solution LICENSE file for more information.

using Finbuckle.MultiTenant.Abstractions;
using Finbuckle.MultiTenant.Internal;

namespace Finbuckle.MultiTenant;

public class TenantInfo : ITenantInfo<string>
{
    private string id;

    public string Id
    {
        get => id;
        set
        {
            if (value.Length > Constants.TenantIdMaxLength)
            {
                throw new MultiTenantException($"The tenant id cannot exceed {Constants.TenantIdMaxLength} characters.");
            }
            id = value;
        }
    }

    public string? Identifier { get; set; }
    public string? Name { get; set; }
}