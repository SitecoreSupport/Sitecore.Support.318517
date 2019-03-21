namespace Sitecore.Support.Jobs
{
  using Sitecore.Jobs;
  using Sitecore.Security.Accounts;
  public class JobRunner
  {
    /// <summary>
    /// Restores the original context user
    /// </summary>
    /// <param name="args">The arguments.</param>
    public static void RestoreContextUser(JobArgs args)
    {
      if (args.Job.Options.ContextUser != null)
      {
        UserSwitcher.Exit();
      }
    }
  }
}