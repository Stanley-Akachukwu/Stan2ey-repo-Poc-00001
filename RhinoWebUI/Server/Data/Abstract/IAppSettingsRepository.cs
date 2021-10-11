namespace RhinoWebUI.Server.Data.Abstract
{
    public interface IAppSettingsRepository
    {
        string RhinoBasedUrl { get; }
        string BasicAuthorization { get; }
    }
}
