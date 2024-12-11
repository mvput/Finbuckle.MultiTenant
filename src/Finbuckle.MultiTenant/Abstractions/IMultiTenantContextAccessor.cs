// Copyright Finbuckle LLC, Andrew White, and Contributors.
// Refer to the solution LICENSE file for more information.

namespace Finbuckle.MultiTenant.Abstractions;

/// <summary>
/// Provides access the current MultiTenantContext.
/// </summary>
public interface IMultiTenantContextAccessor<out TId> where TId : IEquatable<TId>, ISpanParsable<TId>
{
    /// <summary>
    /// Gets the current MultiTenantContext.
    /// </summary>
    IMultiTenantContext<TId> MultiTenantContext { get; }
}

/// <summary>
/// Provides access the current MultiTenantContext.
/// </summary>
/// <typeparam name="TTenantInfo">The ITenantInfo implementation type.</typeparam>
public interface IMultiTenantContextAccessor<TTenantInfo, TId> : IMultiTenantContextAccessor<TId>
    where TTenantInfo : class, ITenantInfo<TId>, new() where TId : IEquatable<TId>, ISpanParsable<TId>
{
    /// <summary>
    /// Gets the current MultiTenantContext.
    /// </summary>
    new IMultiTenantContext<TTenantInfo, TId> MultiTenantContext { get; }
}