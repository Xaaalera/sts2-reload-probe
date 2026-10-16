# StS2 Reload Probe

Private acceptance mod for the StS2 SDK. Its first job is to demonstrate behavior changing from generation A to B in the same owned game process and session, with verified cleanup of the previous generation.

## Status

Acceptance specification only; no installable mod exists yet. Do not copy this repository into the game's mods directory. Runtime code, manifests, package references, build commands, and live evidence will be added with the implementation.

## Standalone use

```powershell
git clone https://github.com/Xaaalera/sts2-reload-probe.git
cd sts2-reload-probe
```

Read [AGENTS.md](AGENTS.md). There are no build dependencies to initialize yet. Future build instructions must work without the parent workspace.

## Acceptance boundary

- Start an isolated owned game with the selected BaseLib and RitsuLib runtime versions.
- Record process/session identity, package identities, source hashes, and generation A behavior through diagnostics.
- Change and compile owned reloadable behavior; activate generation B without restarting the game.
- Verify B's actual effect, old subscriptions/tasks/registrations cleanup, and unload status.
- Preserve working behavior on a controlled compile/load failure and explain recovery.
- Measure the complete edit-build-reload loop and repeated-cycle behavior.
- Package and run the mod through ordinary game loading without SDK development tools or source paths.

Success on one reload does not establish arbitrary DLL replacement, resource/UI reload, multiplayer compatibility, or player-package readiness.

## Related projects

[Workspace and research](https://github.com/Xaaalera/sts2-workshop) · [SDK](https://github.com/Xaaalera/sts2-mod-devkit) · [BaseLib](https://github.com/Alchyr/BaseLib-StS2) · [RitsuLib](https://github.com/BAKAOLC/STS2-RitsuLib) · [Working standards](https://github.com/Xaaalera/claude-skills).

[Xaaalera](https://github.com/Xaaalera) · [Email](mailto:dampirsimpl@gmail.com) · [Telegram](https://t.me/Victima). Unofficial fan project, not affiliated with Mega Crit.
