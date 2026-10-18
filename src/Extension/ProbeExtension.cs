using System.Text.Json;
using HotMod.Contracts;

namespace ReloadProbe;

public sealed class ProbeExtension : IHotLogic
{
    private int _initializedThread;

    public HotLogicManifest Manifest => new("reload-probe", "Reload Probe", "0.1.0-alpha.1", HotContract.ContractVersion,
        new Dictionary<string, string> { ["command:probe"] = "diagnostic" });

    public void Initialize(IHotHost host, HotReloadContext context)
    {
        _initializedThread = Environment.CurrentManagedThreadId;
        host.Log(HotLogLevel.Information, "probe.initialized",
            new Dictionary<string, string> { ["value"] = ProbeBehavior.Value, ["thread"] = _initializedThread.ToString() });
    }

    public HotLogicResult OnHook(HotHookContext context) => new(context.HookId == "command:probe",
        [JsonSerializer.Serialize(new Dictionary<string, object>
        {
            ["value"] = ProbeBehavior.Value,
            ["generation"] = context.Generation,
            ["initializedThread"] = _initializedThread,
            ["invokedThread"] = Environment.CurrentManagedThreadId
        })]);

    public void Dispose() { }
}
