using System;
using Octopus.Client.Editors;
using Octopus.Client.Model;

namespace Octopus.Client.Repositories
{
    public interface ISubscriptionRepository : 
        IFindByName<SubscriptionResource>, 
        ICreate<SubscriptionResource>, 
        IModify<SubscriptionResource>, 
        IGet<SubscriptionResource>, 
        IDelete<SubscriptionResource>, 
        ICanLimitToSpaces<ISubscriptionRepository>
    {
        SubscriptionEditor CreateOrModify(string name, EventNotificationSubscription eventNotificationSubscription, bool isDisabled, string spaceId = null);
    }
    
    class SubscriptionRepository : BasicRepository<SubscriptionResource>, ISubscriptionRepository
    {
        public SubscriptionRepository(IOctopusClient client) : base(client, "Subscriptions")
        {
        }

        public SubscriptionEditor CreateOrModify(string name, EventNotificationSubscription eventNotificationSubscription, bool isDisabled, string spaceId = null)
        {
            return new SubscriptionEditor(this).CreateOrModify(name, eventNotificationSubscription, isDisabled, spaceId);
        }

        public ISubscriptionRepository LimitTo(bool includeGlobal, params string[] spaceIds)
        {
            return new SubscriptionRepository(Client)
            {
                LimitedToSpacesParameters = CreateSpacesParameters(includeGlobal, spaceIds)
            };
        }
    }
}