//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;


namespace Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy
{
    
    
    public enum Voting
    {
        
        Direct,
        
        Delegating,
    }
    
    /// <summary>
    /// >> 177 - Variant[pallet_democracy.vote.Voting]
    /// </summary>
    public sealed class EnumVoting : BaseEnumExt<Voting, BaseTuple<BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumAccountVote>>, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.Delegations, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.PriorLock>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumConviction, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.Delegations, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.PriorLock>>
    {
    }
}
