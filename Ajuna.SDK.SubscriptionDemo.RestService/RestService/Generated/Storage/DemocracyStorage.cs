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
using Ajuna.ServiceLayer.Storage;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ajuna.SDK.SubscriptionDemo.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IDemocracyStorage interface definition.
    /// </summary>
    public interface IDemocracyStorage : IStorage
    {
        
        /// <summary>
        /// >> PublicPropCount
        ///  The number of (public) proposals that have been made so far.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetPublicPropCount();
        
        /// <summary>
        /// >> PublicProps
        ///  The public proposals. Unsorted. The second item is the proposal's hash.
        /// </summary>
        BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>> GetPublicProps();
        
        /// <summary>
        /// >> DepositOf
        ///  Those who have locked a deposit.
        /// 
        ///  TWOX-NOTE: Safe, as increasing integer keys are safe.
        /// </summary>
        BaseTuple<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>,Ajuna.NetApi.Model.Types.Primitive.U128> GetDepositOf(string key);
        
        /// <summary>
        /// >> Preimages
        ///  Map of hashes to the proposal preimage, along with who registered it and their deposit.
        ///  The block number is the block at which it was deposited.
        /// </summary>
        Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumPreimageStatus GetPreimages(string key);
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetReferendumCount();
        
        /// <summary>
        /// >> LowestUnbaked
        ///  The lowest referendum index representing an unbaked referendum. Equal to
        ///  `ReferendumCount` if there isn't a unbaked referendum.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetLowestUnbaked();
        
        /// <summary>
        /// >> ReferendumInfoOf
        ///  Information concerning any given referendum.
        /// 
        ///  TWOX-NOTE: SAFE as indexes are not under an attacker���s control.
        /// </summary>
        Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReferendumInfo GetReferendumInfoOf(string key);
        
        /// <summary>
        /// >> VotingOf
        ///  All votes for a particular voter. We store the balance for the number of votes that we
        ///  have recorded. The second item is the total amount of delegations, that will be added.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId`s are crypto hashes anyway.
        /// </summary>
        Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoting GetVotingOf(string key);
        
        /// <summary>
        /// >> LastTabledWasExternal
        ///  True if the last referendum tabled was submitted externally. False if it was a public
        ///  proposal.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.Bool GetLastTabledWasExternal();
        
        /// <summary>
        /// >> NextExternal
        ///  The referendum to be tabled whenever it would be valid to table an external proposal.
        ///  This happens when a referendum needs to be tabled and one of two conditions are met:
        ///  - `LastTabledWasExternal` is `false`; or
        ///  - `PublicProps` is empty.
        /// </summary>
        BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold> GetNextExternal();
        
        /// <summary>
        /// >> Blacklist
        ///  A record of who vetoed what. Maps proposal hash to a possible existent block number
        ///  (until when it may not be resubmitted) and who vetoed it.
        /// </summary>
        BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>> GetBlacklist(string key);
        
        /// <summary>
        /// >> Cancellations
        ///  Record of all proposals that have been subject to emergency cancellation.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.Bool GetCancellations(string key);
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  New networks start with last version.
        /// </summary>
        Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReleases GetStorageVersion();
    }
    
    /// <summary>
    /// DemocracyStorage class definition.
    /// </summary>
    public sealed class DemocracyStorage : IDemocracyStorage
    {
        
        /// <summary>
        /// _publicPropCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _publicPropCountTypedStorage;
        
        /// <summary>
        /// _publicPropsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>> _publicPropsTypedStorage;
        
        /// <summary>
        /// _depositOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseTuple<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>,Ajuna.NetApi.Model.Types.Primitive.U128>> _depositOfTypedStorage;
        
        /// <summary>
        /// _preimagesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumPreimageStatus> _preimagesTypedStorage;
        
        /// <summary>
        /// _referendumCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _referendumCountTypedStorage;
        
        /// <summary>
        /// _lowestUnbakedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _lowestUnbakedTypedStorage;
        
        /// <summary>
        /// _referendumInfoOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReferendumInfo> _referendumInfoOfTypedStorage;
        
        /// <summary>
        /// _votingOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoting> _votingOfTypedStorage;
        
        /// <summary>
        /// _lastTabledWasExternalTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> _lastTabledWasExternalTypedStorage;
        
        /// <summary>
        /// _nextExternalTypedStorage typed storage field
        /// </summary>
        private TypedStorage<BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold>> _nextExternalTypedStorage;
        
        /// <summary>
        /// _blacklistTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>> _blacklistTypedStorage;
        
        /// <summary>
        /// _cancellationsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> _cancellationsTypedStorage;
        
        /// <summary>
        /// _storageVersionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReleases> _storageVersionTypedStorage;
        
        /// <summary>
        /// DemocracyStorage constructor.
        /// </summary>
        public DemocracyStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.PublicPropCountTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Democracy.PublicPropCount", storageDataProvider, storageChangeDelegate);
            this.PublicPropsTypedStorage = new TypedStorage<BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>>("Democracy.PublicProps", storageDataProvider, storageChangeDelegate);
            this.DepositOfTypedStorage = new TypedMapStorage<BaseTuple<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>,Ajuna.NetApi.Model.Types.Primitive.U128>>("Democracy.DepositOf", storageDataProvider, storageChangeDelegate);
            this.PreimagesTypedStorage = new TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumPreimageStatus>("Democracy.Preimages", storageDataProvider, storageChangeDelegate);
            this.ReferendumCountTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Democracy.ReferendumCount", storageDataProvider, storageChangeDelegate);
            this.LowestUnbakedTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Democracy.LowestUnbaked", storageDataProvider, storageChangeDelegate);
            this.ReferendumInfoOfTypedStorage = new TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReferendumInfo>("Democracy.ReferendumInfoOf", storageDataProvider, storageChangeDelegate);
            this.VotingOfTypedStorage = new TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoting>("Democracy.VotingOf", storageDataProvider, storageChangeDelegate);
            this.LastTabledWasExternalTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool>("Democracy.LastTabledWasExternal", storageDataProvider, storageChangeDelegate);
            this.NextExternalTypedStorage = new TypedStorage<BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold>>("Democracy.NextExternal", storageDataProvider, storageChangeDelegate);
            this.BlacklistTypedStorage = new TypedMapStorage<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>>("Democracy.Blacklist", storageDataProvider, storageChangeDelegate);
            this.CancellationsTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool>("Democracy.Cancellations", storageDataProvider, storageChangeDelegate);
            this.StorageVersionTypedStorage = new TypedStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReleases>("Democracy.StorageVersion", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _publicPropCountTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> PublicPropCountTypedStorage
        {
            get
            {
                return _publicPropCountTypedStorage;
            }
            set
            {
                _publicPropCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _publicPropsTypedStorage property
        /// </summary>
        public TypedStorage<BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>> PublicPropsTypedStorage
        {
            get
            {
                return _publicPropsTypedStorage;
            }
            set
            {
                _publicPropsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _depositOfTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseTuple<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>,Ajuna.NetApi.Model.Types.Primitive.U128>> DepositOfTypedStorage
        {
            get
            {
                return _depositOfTypedStorage;
            }
            set
            {
                _depositOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _preimagesTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumPreimageStatus> PreimagesTypedStorage
        {
            get
            {
                return _preimagesTypedStorage;
            }
            set
            {
                _preimagesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _referendumCountTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> ReferendumCountTypedStorage
        {
            get
            {
                return _referendumCountTypedStorage;
            }
            set
            {
                _referendumCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lowestUnbakedTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> LowestUnbakedTypedStorage
        {
            get
            {
                return _lowestUnbakedTypedStorage;
            }
            set
            {
                _lowestUnbakedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _referendumInfoOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReferendumInfo> ReferendumInfoOfTypedStorage
        {
            get
            {
                return _referendumInfoOfTypedStorage;
            }
            set
            {
                _referendumInfoOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votingOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoting> VotingOfTypedStorage
        {
            get
            {
                return _votingOfTypedStorage;
            }
            set
            {
                _votingOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lastTabledWasExternalTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> LastTabledWasExternalTypedStorage
        {
            get
            {
                return _lastTabledWasExternalTypedStorage;
            }
            set
            {
                _lastTabledWasExternalTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextExternalTypedStorage property
        /// </summary>
        public TypedStorage<BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold>> NextExternalTypedStorage
        {
            get
            {
                return _nextExternalTypedStorage;
            }
            set
            {
                _nextExternalTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _blacklistTypedStorage property
        /// </summary>
        public TypedMapStorage<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>> BlacklistTypedStorage
        {
            get
            {
                return _blacklistTypedStorage;
            }
            set
            {
                _blacklistTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _cancellationsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> CancellationsTypedStorage
        {
            get
            {
                return _cancellationsTypedStorage;
            }
            set
            {
                _cancellationsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _storageVersionTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReleases> StorageVersionTypedStorage
        {
            get
            {
                return _storageVersionTypedStorage;
            }
            set
            {
                _storageVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await PublicPropCountTypedStorage.InitializeAsync("Democracy", "PublicPropCount");
            await PublicPropsTypedStorage.InitializeAsync("Democracy", "PublicProps");
            await DepositOfTypedStorage.InitializeAsync("Democracy", "DepositOf");
            await PreimagesTypedStorage.InitializeAsync("Democracy", "Preimages");
            await ReferendumCountTypedStorage.InitializeAsync("Democracy", "ReferendumCount");
            await LowestUnbakedTypedStorage.InitializeAsync("Democracy", "LowestUnbaked");
            await ReferendumInfoOfTypedStorage.InitializeAsync("Democracy", "ReferendumInfoOf");
            await VotingOfTypedStorage.InitializeAsync("Democracy", "VotingOf");
            await LastTabledWasExternalTypedStorage.InitializeAsync("Democracy", "LastTabledWasExternal");
            await NextExternalTypedStorage.InitializeAsync("Democracy", "NextExternal");
            await BlacklistTypedStorage.InitializeAsync("Democracy", "Blacklist");
            await CancellationsTypedStorage.InitializeAsync("Democracy", "Cancellations");
            await StorageVersionTypedStorage.InitializeAsync("Democracy", "StorageVersion");
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.PublicPropCount
        /// </summary>
        [StorageChange("Democracy", "PublicPropCount")]
        public void OnUpdatePublicPropCount(string data)
        {
            PublicPropCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> PublicPropCount
        ///  The number of (public) proposals that have been made so far.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetPublicPropCount()
        {
            return PublicPropCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.PublicProps
        /// </summary>
        [StorageChange("Democracy", "PublicProps")]
        public void OnUpdatePublicProps(string data)
        {
            PublicPropsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> PublicProps
        ///  The public proposals. Unsorted. The second item is the proposal's hash.
        /// </summary>
        public BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>> GetPublicProps()
        {
            return PublicPropsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.DepositOf
        /// </summary>
        [StorageChange("Democracy", "DepositOf")]
        public void OnUpdateDepositOf(string key, string data)
        {
            DepositOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DepositOf
        ///  Those who have locked a deposit.
        /// 
        ///  TWOX-NOTE: Safe, as increasing integer keys are safe.
        /// </summary>
        public BaseTuple<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>,Ajuna.NetApi.Model.Types.Primitive.U128> GetDepositOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DepositOfTypedStorage.Dictionary.TryGetValue(key, out BaseTuple<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>,Ajuna.NetApi.Model.Types.Primitive.U128> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.Preimages
        /// </summary>
        [StorageChange("Democracy", "Preimages")]
        public void OnUpdatePreimages(string key, string data)
        {
            PreimagesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Preimages
        ///  Map of hashes to the proposal preimage, along with who registered it and their deposit.
        ///  The block number is the block at which it was deposited.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumPreimageStatus GetPreimages(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PreimagesTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumPreimageStatus result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.ReferendumCount
        /// </summary>
        [StorageChange("Democracy", "ReferendumCount")]
        public void OnUpdateReferendumCount(string data)
        {
            ReferendumCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetReferendumCount()
        {
            return ReferendumCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.LowestUnbaked
        /// </summary>
        [StorageChange("Democracy", "LowestUnbaked")]
        public void OnUpdateLowestUnbaked(string data)
        {
            LowestUnbakedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LowestUnbaked
        ///  The lowest referendum index representing an unbaked referendum. Equal to
        ///  `ReferendumCount` if there isn't a unbaked referendum.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetLowestUnbaked()
        {
            return LowestUnbakedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.ReferendumInfoOf
        /// </summary>
        [StorageChange("Democracy", "ReferendumInfoOf")]
        public void OnUpdateReferendumInfoOf(string key, string data)
        {
            ReferendumInfoOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ReferendumInfoOf
        ///  Information concerning any given referendum.
        /// 
        ///  TWOX-NOTE: SAFE as indexes are not under an attacker���s control.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReferendumInfo GetReferendumInfoOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReferendumInfoOfTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReferendumInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.VotingOf
        /// </summary>
        [StorageChange("Democracy", "VotingOf")]
        public void OnUpdateVotingOf(string key, string data)
        {
            VotingOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VotingOf
        ///  All votes for a particular voter. We store the balance for the number of votes that we
        ///  have recorded. The second item is the total amount of delegations, that will be added.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId`s are crypto hashes anyway.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoting GetVotingOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotingOfTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoting result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.LastTabledWasExternal
        /// </summary>
        [StorageChange("Democracy", "LastTabledWasExternal")]
        public void OnUpdateLastTabledWasExternal(string data)
        {
            LastTabledWasExternalTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LastTabledWasExternal
        ///  True if the last referendum tabled was submitted externally. False if it was a public
        ///  proposal.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.Bool GetLastTabledWasExternal()
        {
            return LastTabledWasExternalTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.NextExternal
        /// </summary>
        [StorageChange("Democracy", "NextExternal")]
        public void OnUpdateNextExternal(string data)
        {
            NextExternalTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextExternal
        ///  The referendum to be tabled whenever it would be valid to table an external proposal.
        ///  This happens when a referendum needs to be tabled and one of two conditions are met:
        ///  - `LastTabledWasExternal` is `false`; or
        ///  - `PublicProps` is empty.
        /// </summary>
        public BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256,Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold> GetNextExternal()
        {
            return NextExternalTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.Blacklist
        /// </summary>
        [StorageChange("Democracy", "Blacklist")]
        public void OnUpdateBlacklist(string key, string data)
        {
            BlacklistTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Blacklist
        ///  A record of who vetoed what. Maps proposal hash to a possible existent block number
        ///  (until when it may not be resubmitted) and who vetoed it.
        /// </summary>
        public BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>> GetBlacklist(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BlacklistTypedStorage.Dictionary.TryGetValue(key, out BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.Cancellations
        /// </summary>
        [StorageChange("Democracy", "Cancellations")]
        public void OnUpdateCancellations(string key, string data)
        {
            CancellationsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Cancellations
        ///  Record of all proposals that have been subject to emergency cancellation.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.Bool GetCancellations(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CancellationsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.StorageVersion
        /// </summary>
        [StorageChange("Democracy", "StorageVersion")]
        public void OnUpdateStorageVersion(string data)
        {
            StorageVersionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  New networks start with last version.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.EnumReleases GetStorageVersion()
        {
            return StorageVersionTypedStorage.Get();
        }
    }
}
