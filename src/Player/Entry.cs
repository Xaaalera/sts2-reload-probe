using Godot;
using MegaCrit.Sts2.Core.Modding;

namespace ReloadProbe.Player;

[ModInitializer(nameof(Initialize))]
public static class Entry
{
    public static void Initialize() => GD.Print($"reload-probe.player value={ProbeBehavior.Value}");
}
