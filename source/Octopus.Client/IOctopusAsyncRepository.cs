using Octopus.Client.Repositories.Async;

namespace Octopus.Client
{
    /// <summary>
    /// A simplified interface to commonly-used parts of the API.
    /// Functionality not exposed by this interface can be accessed
    /// using <see cref="IOctopusAsyncRepository.Client" />.
    /// </summary>
    public interface IOctopusAsyncRepository
    {
        /// <summary>
        /// The client over which the repository is run.
        /// </summary>
        IOctopusAsyncClient Client { get; }

        IAccountRepository Accounts { get; }
        IActionTemplateRepository ActionTemplates { get; }
        IArtifactRepository Artifacts { get; }
        IBackupRepository Backups { get; }
        IBuiltInPackageRepositoryRepository BuiltInPackageRepository { get; }
        ICertificateConfigurationRepository CertificateConfiguration { get; }
        ICertificateRepository Certificates { get; }
        IChannelRepository Channels { get; }
        ICommunityActionTemplateRepository CommunityActionTemplates { get; }
        IConfigurationRepository Configuration { get; }
        IDashboardConfigurationRepository DashboardConfigurations { get; }
        IDashboardRepository Dashboards { get; }
        IDefectsRepository Defects { get; }
        IDeploymentProcessRepository DeploymentProcesses { get; }
        IDeploymentRepository Deployments { get; }
        IEnvironmentRepository Environments { get; }
        IEventRepository Events { get; }
        IFeaturesConfigurationRepository FeaturesConfiguration { get; }
        IFeedRepository Feeds { get; }
        IInterruptionRepository Interruptions { get; }
        ILibraryVariableSetRepository LibraryVariableSets { get; }
        ILifecyclesRepository Lifecycles { get; }
        IMachinePolicyRepository MachinePolicies { get; }
        IMachineRepository Machines { get; }
        IMachineRoleRepository MachineRoles { get; }
        IMigrationRepository Migrations { get; }
        IOctopusServerNodeRepository OctopusServerNodes { get; }
        IPerformanceConfigurationRepository PerformanceConfiguration { get; }
        IProjectGroupRepository ProjectGroups { get; }
        IProjectRepository Projects { get; }
        IProjectTriggerRepository ProjectTriggers { get; }
        IProxyRepository Proxies { get; }
        IReleaseRepository Releases { get; }
        IRetentionPolicyRepository RetentionPolicies { get; }
        ISchedulerRepository Schedulers { get; }
        IServerStatusRepository ServerStatus { get; }
        ISubscriptionRepository Subscriptions { get; }
        ITagSetRepository TagSets { get; }
        ITaskRepository Tasks { get; }
        ITeamsRepository Teams { get; }
        ITenantRepository Tenants { get; }
        ITenantVariablesRepository TenantVariables { get; }
        IUserRepository Users { get; }
        IUserRolesRepository UserRoles { get; }
        IVariableSetRepository VariableSets { get; }
        IWorkerPoolRepository WorkerPools { get; }
        IWorkerRepository Workers { get; }
    }
}