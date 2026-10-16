# Reload probe working instructions

- Write repository content in English. Read README before changing the acceptance mod.
- Follow the shared [workspace instructions](https://github.com/Xaaalera/sts2-workshop/blob/main/AGENTS.md) and current [handoff](https://github.com/Xaaalera/sts2-workshop/blob/main/docs/handoff.md), including standalone development.
- Search retained findings and primary internet sources before implementing a mechanism. Reuse established game/library capabilities; preserve URLs, revisions, hypotheses, failed attempts, and verification limits.
- Apply installed relevant [marketplace guides](https://github.com/Xaaalera/claude-skills). Do not claim a guide, review gate, or test ran unless it actually did.
- Keep this mod's behavior independent of SDK tooling. Only its integration adapter knows the runtime/extension contract.
- Pin compatible BaseLib/RitsuLib compile-time packages and declare matching runtime dependencies when code is introduced. Do not reference sibling workspace source paths as build requirements.
- Verify real generation-A/B effects in the same owned process/session. Activation, disposal, collection, thread safety, and standalone packaging are separate acceptance properties.
- Use only owned game processes. Shared input is authorized for SDK work; pause immediately when requested and resume only on instruction.
- Reuse the saved test scenario and active session. Restart only for a verified need. Do not close the game merely because a test or assistant turn ends.
- Use API/hooks/log/process evidence where possible; screenshots require an explicit owner request for the image or comparison.
- Retain exact source, dependency, game, artifact, and session identities. Prefer the fastest sufficient check and do not repeat unchanged accepted experiments.
- Do not modify the owner's existing mods, profile, or saves. Keep local artifacts under ignored `.local/`; never commit game content, secrets, or personal logs.
- This bootstrap contains plugin declarations but no verified review harness. Install and validate targeted review/secret-scan gates before substantive implementation.
