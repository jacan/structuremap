namespace StructureMap.Pipeline
{
    /// <summary>
    /// Plugin interface to create custom build or lifecycle policies for a Plugin Type
    /// </summary>
    [PluginFamily]
    public interface IBuildInterceptor : IBuildPolicy
    {
        IBuildPolicy InnerPolicy { get; set; }
    }
}