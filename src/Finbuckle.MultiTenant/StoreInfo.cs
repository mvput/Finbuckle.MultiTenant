// Copyright Finbuckle LLC, Andrew White, and Contributors.
// Refer to the solution LICENSE file for more information.

using Finbuckle.MultiTenant.Abstractions;

namespace Finbuckle.MultiTenant;

public class StoreInfo<TTenantInfo, TId> where TTenantInfo : class, ITenantInfo<TId>, new() where TId : IEquatable<TId>, ISpanParsable<TId>
{
    public Type? StoreType { get; internal set; }
    public IMultiTenantStore<TTenantInfo, TId>? Store { get; internal set; }
}