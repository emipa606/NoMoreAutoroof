# GitHub Copilot Instructions for NoMoreAutoroof (Continued) Mod Project

## Mod Overview and Purpose

**Mod Name:** NoMoreAutoroof (Continued)  
**Author:** fed1, updated and continued by the community  
**PackageId:** Mlie.NoMoreAutoroof  

NoMoreAutoroof is a mod for RimWorld designed to address the often frustrating automatic roofing system in the game. When a room's perimeter is completed, RimWorld automatically places a roof over the area, which may not align with the player's intended design. This mod stops pawns from building automatic roofs, allowing players more control over their construction projects.

### Mod Features:
- Disables automatic roof generation in newly enclosed spaces.
- Enhances player control and prevents undesired roofing.

## Key Features and Systems

- **User Control:** The mod prioritizes player preference over the game's default behavior, stopping roofs from being automatically built.
- **Seamless Integration:** The mod functions without altering core gameplay elements, providing a smooth, easy experience.

## Coding Patterns and Conventions

- **Project Structure:** The mod is organized into C# files that implement core functionality. Each file encapsulates specific behaviors and settings.
- **Naming Conventions:** Use PascalCase for class names and method identifiers, adhering to C# standards.
- **Commenting:** Provide clear comments for each method to explain its function and the rationale behind any complex logic.

## XML Integration

While this mod does not contain XML files, any future integration with XML should be placed in a structured manner, utilizing RimWorld’s standard XML definitions for settings or game object configurations.

## Harmony Patching

### Core Harmony Usage:
The mod employs Harmony patching to alter the default behavior of RimWorld's roofing system. Below are some key components:

- **AutoBuildRoofAreaSetter_TryGenerateAreaNow.cs**  
  - **Type:** AutoBuildRoofAreaSetter_TryGenerateAreaNow  
  - **Method Hooked:** `TryGenerateAreaNow`  
  - **Patch Type:** Prefix  
  - **Purpose:** Prevents the automatic generation of roof areas by intercepting the call before the default behavior occurs.

### Example:
csharp
// Example of a Harmony Prefix patch
[HarmonyPatch(typeof(AutoBuildRoofAreaSetter), "TryGenerateAreaNow")]
public static class AutoBuildRoofAreaSetter_TryGenerateAreaNow
{
    public static bool Prefix(ref bool __result)
    {
        __result = false;  // Override method result to prevent roof auto-generation
        return false;  // Skip original method execution
    }
}


## Suggestions for Copilot

When using GitHub Copilot for further mod development, consider the following suggestions to optimize efficiency and output quality:

1. **Code Completion:** Leverage Copilot for autocompleting routine syntax and helping adhere to coding conventions.
2. **Harmony Method Hooking:** Use Copilot’s suggestions for identifying correct method signatures for Harmony patches.
3. **Debugging Help:** Utilize Copilot to quickly navigate to relevant sections and suggest fixes for syntax errors or common C# logical issues.
4. **Iterative Design and Testing:** Iteratively refine code using Copilot to rapidly prototype and test features, ensuring robust functionality within the mod environment.

By staying consistent with these instructions and utilizing Copilot effectively, you can streamline the development of updates to NoMoreAutoroof, ensuring a high-quality mod experience for RimWorld players.

---
For additional help or to report errors, please use the provided Discord-channel for direct support or post solutions and discussions in the GitHub repository. Avoid reporting errors through new discussion threads, as these do not trigger notifications. Use RimSort to organize your mods efficiently.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

