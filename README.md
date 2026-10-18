# StS2 Reload Probe

Acceptance mod for the StS2 SDK. Its first job is to demonstrate behavior changing from generation A to B in the same owned game process and session, with verified cleanup of the previous generation.

## Status

The repository implements two adapters over one `src/Behavior.cs`: an SDK extension and a standalone native game mod. A bounded live run verified A-to-B reload in one process/game thread, previous-generation collection, malformed-replacement retention, recovery, and explicit unload. The player adapter has a separate project and no SDK dependency.

## Standalone use

```powershell
git clone --branch feat/sdk-hmr https://github.com/Xaaalera/sts2-reload-probe.git
cd sts2-reload-probe
```

Read [AGENTS.md](AGENTS.md). Requires .NET SDK 9 and an installed StS2 v0.107.1. The parent workspace is optional. Use the SDK implementation branch `feat/intent-lens`. From its checkout, run `dotnet pack src/Contracts/Sts2.Devkit.Contracts.csproj --output .local/package-feed` before restoring this extension. Obtain the local `Sts2.ModDevkit.Contracts` 0.1.0-alpha.1 package by packing the SDK contracts project; pass that feed when restoring the extension.

```powershell
$env:STS2_GAME_DIR = 'D:/Games/Slay the Spire 2'
dotnet restore src/Extension/reload-probe.csproj --source 'D:/Code/sts2-mod-devkit/.local/package-feed'
dotnet build src/Extension/reload-probe.csproj --no-restore
dotnet build src/Player/ReloadProbe.csproj
```

The SDK's [command workflow](https://github.com/Xaaalera/sts2-mod-devkit/blob/feat/intent-lens/README.md#use-the-sdk) builds both variants and stages the extension. Invoke its `probe` command to read value, generation, and initialization/invocation thread IDs. Edit `src/Behavior.cs`, rebuild the extension, reload it, and invoke again.

For a player installation, copy `src/Player/bin/Debug/net9.0/ReloadProbe.dll`, `ReloadProbe.json` and `LICENSE` into `mods/ReloadProbe/`. Install complete BaseLib 3.4.7 and RitsuLib 0.6.7/API-0.107.1 runtime packages. Normal native mod initialization logs `reload-probe.player value=<value>`. SDK tools, contracts, source checkout, and PowerShell are not player dependencies. The SDK provides `package-player` to assemble these three files.

The extension pins the local SDK contract package; the player project pins compile-time BaseLib/RitsuLib packages. Both compile the same behavior file. Game references use `STS2_GAME_DIR` with `Private=false`, and RitsuLib's automatic deployment is disabled.

## Acceptance boundary

- Start an isolated owned game with the selected BaseLib and RitsuLib runtime versions.
- Record process/session identity, package identities, source hashes, and generation A behavior through diagnostics.
- Change and compile owned reloadable behavior; activate generation B without restarting the game.
- Verify B's actual effect, old subscriptions/tasks/registrations cleanup, and unload status.
- Preserve working behavior on a controlled compile/load failure and explain recovery.
- Measure the complete edit-build-reload loop and repeated-cycle behavior.
- Package and run the mod through ordinary game loading without SDK development tools or source paths.

Success on one reload does not establish arbitrary DLL replacement, resource/UI reload, multiplayer compatibility, or player-package readiness.

## Review wiring

Run `npm ci`, then `npm run review:info` or `npm run review:gate`. The pinned harness runs through `scripts/review.mjs`, which fixes its review base to the actual origin/main commit in temporary Git metadata without changing branch tracking. Attest only completed independent results using `npm run review:attest -- <results-file>`. Wrapper configuration failures use `REVIEW_SETUP_FAILURE` (INTERNAL/500). Hosted CI is configured for secrets; a local hook check does not establish a hosted run or branch protection.

## Related projects

[Workspace and research](https://github.com/Xaaalera/sts2-workshop) · [SDK](https://github.com/Xaaalera/sts2-mod-devkit) · [BaseLib](https://github.com/Alchyr/BaseLib-StS2) · [RitsuLib](https://github.com/BAKAOLC/STS2-RitsuLib) · [Working standards](https://github.com/Xaaalera/claude-skills).

[Xaaalera](https://github.com/Xaaalera) · [Email](mailto:dampirsimpl@gmail.com) · [Telegram](https://t.me/Victima). Unofficial fan project, not affiliated with Mega Crit.

## License

Original project code and documentation are licensed under the [MIT License](LICENSE), copyright 2026 [Xaaalera](https://github.com/Xaaalera). Commercial use and redistribution are allowed; retain the copyright and license notice in distributed copies or substantial portions. Third-party code, dependencies and game assets retain their own licenses and ownership.
