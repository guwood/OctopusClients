using System;
using System.Collections.Generic;
using Octopus.Client.Model;

namespace Octopus.Client.Repositories
{
    public interface ITeamsRepository :
        ICreate<TeamResource>,
        IModify<TeamResource>,
        IDelete<TeamResource>,
        IFindByName<TeamResource>,
        IGet<TeamResource>,
        ICanLimitToSpaces<ITeamsRepository>
    {
        List<ScopedUserRoleResource> GetScopedUserRoles(TeamResource team);
    }
    
    class TeamsRepository : BasicRepository<TeamResource>, ITeamsRepository
    {
        public TeamsRepository(IOctopusClient client)
            : base(client, "Teams")
        {
        }

        public List<ScopedUserRoleResource> GetScopedUserRoles(TeamResource team)
        {
            if (team == null) throw new ArgumentNullException(nameof(team));
            var resources = new List<ScopedUserRoleResource>();

            Client.Paginate<ScopedUserRoleResource>(team.Link("ScopedUserRoles"), page =>
            {
                resources.AddRange(page.Items);
                return true;
            });

            return resources;
        }

        public ITeamsRepository LimitTo(bool includeGlobal, params string[] spaceIds)
        {
            return new TeamsRepository(Client)
            {
                LimitedToSpacesParameters = CreateSpacesParameters(includeGlobal, spaceIds)
            };
        }
    }
}