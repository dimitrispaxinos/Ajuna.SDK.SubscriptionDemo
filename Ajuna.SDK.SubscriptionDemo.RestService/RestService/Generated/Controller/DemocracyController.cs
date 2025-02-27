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
using Ajuna.ServiceLayer.Attributes;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using Ajuna.SDK.SubscriptionDemo.RestService.Generated.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ajuna.SDK.SubscriptionDemo.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// DemocracyController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class DemocracyController : ControllerBase
    {
        
        private IDemocracyStorage _democracyStorage;
        
        /// <summary>
        /// DemocracyController constructor.
        /// </summary>
        public DemocracyController(IDemocracyStorage democracyStorage)
        {
            _democracyStorage = democracyStorage;
        }
        
        /// <summary>
        /// >> PublicPropCount
        ///  The number of (public) proposals that have been made so far.
        /// </summary>
        [HttpGet("PublicPropCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "PublicPropCountParams")]
        public IActionResult GetPublicPropCount()
        {
            return this.Ok(_democracyStorage.GetPublicPropCount());
        }
        
        /// <summary>
        /// >> PublicProps
        ///  The public proposals. Unsorted. The second item is the proposal's hash.
        /// </summary>
        [HttpGet("PublicProps")]
        [ProducesResponseType(typeof(BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "PublicPropsParams")]
        public IActionResult GetPublicProps()
        {
            return this.Ok(_democracyStorage.GetPublicProps());
        }
        
        /// <summary>
        /// >> DepositOf
        ///  Those who have locked a deposit.
        /// 
        ///  TWOX-NOTE: Safe, as increasing integer keys are safe.
        /// </summary>
        [HttpGet("DepositOf")]
        [ProducesResponseType(typeof(BaseTuple<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>,Ajuna.NetApi.Model.Types.Primitive.U128>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "DepositOfParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetDepositOf(string key)
        {
            return this.Ok(_democracyStorage.GetDepositOf(key));
        }
        
        /// <summary>
        /// >> Preimages
        ///  Map of hashes to the proposal preimage, along with who registered it and their deposit.
        ///  The block number is the block at which it was deposited.
        /// </summary>
        [HttpGet("Preimages")]
        [ProducesResponseType(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumPreimageStatus), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "PreimagesParams", typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256))]
        public IActionResult GetPreimages(string key)
        {
            return this.Ok(_democracyStorage.GetPreimages(key));
        }
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        [HttpGet("ReferendumCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "ReferendumCountParams")]
        public IActionResult GetReferendumCount()
        {
            return this.Ok(_democracyStorage.GetReferendumCount());
        }
        
        /// <summary>
        /// >> LowestUnbaked
        ///  The lowest referendum index representing an unbaked referendum. Equal to
        ///  `ReferendumCount` if there isn't a unbaked referendum.
        /// </summary>
        [HttpGet("LowestUnbaked")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "LowestUnbakedParams")]
        public IActionResult GetLowestUnbaked()
        {
            return this.Ok(_democracyStorage.GetLowestUnbaked());
        }
        
        /// <summary>
        /// >> ReferendumInfoOf
        ///  Information concerning any given referendum.
        /// 
        ///  TWOX-NOTE: SAFE as indexes are not under an attacker���s control.
        /// </summary>
        [HttpGet("ReferendumInfoOf")]
        [ProducesResponseType(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReferendumInfo), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "ReferendumInfoOfParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetReferendumInfoOf(string key)
        {
            return this.Ok(_democracyStorage.GetReferendumInfoOf(key));
        }
        
        /// <summary>
        /// >> VotingOf
        ///  All votes for a particular voter. We store the balance for the number of votes that we
        ///  have recorded. The second item is the total amount of delegations, that will be added.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId`s are crypto hashes anyway.
        /// </summary>
        [HttpGet("VotingOf")]
        [ProducesResponseType(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoting), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "VotingOfParams", typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetVotingOf(string key)
        {
            return this.Ok(_democracyStorage.GetVotingOf(key));
        }
        
        /// <summary>
        /// >> LastTabledWasExternal
        ///  True if the last referendum tabled was submitted externally. False if it was a public
        ///  proposal.
        /// </summary>
        [HttpGet("LastTabledWasExternal")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "LastTabledWasExternalParams")]
        public IActionResult GetLastTabledWasExternal()
        {
            return this.Ok(_democracyStorage.GetLastTabledWasExternal());
        }
        
        /// <summary>
        /// >> NextExternal
        ///  The referendum to be tabled whenever it would be valid to table an external proposal.
        ///  This happens when a referendum needs to be tabled and one of two conditions are met:
        ///  - `LastTabledWasExternal` is `false`; or
        ///  - `PublicProps` is empty.
        /// </summary>
        [HttpGet("NextExternal")]
        [ProducesResponseType(typeof(BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "NextExternalParams")]
        public IActionResult GetNextExternal()
        {
            return this.Ok(_democracyStorage.GetNextExternal());
        }
        
        /// <summary>
        /// >> Blacklist
        ///  A record of who vetoed what. Maps proposal hash to a possible existent block number
        ///  (until when it may not be resubmitted) and who vetoed it.
        /// </summary>
        [HttpGet("Blacklist")]
        [ProducesResponseType(typeof(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "BlacklistParams", typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256))]
        public IActionResult GetBlacklist(string key)
        {
            return this.Ok(_democracyStorage.GetBlacklist(key));
        }
        
        /// <summary>
        /// >> Cancellations
        ///  Record of all proposals that have been subject to emergency cancellation.
        /// </summary>
        [HttpGet("Cancellations")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "CancellationsParams", typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256))]
        public IActionResult GetCancellations(string key)
        {
            return this.Ok(_democracyStorage.GetCancellations(key));
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  New networks start with last version.
        /// </summary>
        [HttpGet("StorageVersion")]
        [ProducesResponseType(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReleases), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage), "StorageVersionParams")]
        public IActionResult GetStorageVersion()
        {
            return this.Ok(_democracyStorage.GetStorageVersion());
        }
    }
}
