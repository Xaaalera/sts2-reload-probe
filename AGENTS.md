# Reload probe working instructions

- Write repository content in English. Read README before changing the acceptance mod.
- Native game facilities are the first choice: reuse actual game APIs/components/scenes/assets, palette, fonts, animations and interactions before library adapters or custom code. Record a demonstrated gap before choosing a custom implementation.
- Use this repository's README and local instructions for standalone development. Linked maintainers may additionally read the private workspace instructions/handoff; public contributors must not need private repository access.
- Original probe code is MIT-licensed with Xaaalera attribution; preserve all third-party licenses. Use Kreon Bold for authored SDK/mod UI labels and promotional titles, reusing native typography/fallback handling and actual font rendering for exact external lettering.
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
- The pinned review harness and pre-push hook are installed; unattested pushes are verified to fail. Use the configured independent roles and never bypass the gate. Do not claim hosted CI or branch protection without evidence.
