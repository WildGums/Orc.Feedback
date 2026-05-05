# Orc.Feedback

Orc.Feedback is a WPF library that allows users to easily collect feedback from end-users. It is built on top of Catel MVVM and provides a simple service-based API for launching a feedback URL in the user's browser.

---

## Critical Rules (Read First)

These rules are **non-negotiable**. Violating them causes broken builds, crashes, or downstream breakage.

### 1. Never Edit Generated Files

Files matching `*.generated.cs`, `*.generated.xaml` are auto-generated.

- **NEVER** manually edit these files

### 2. ABI / API Stability

This project maintains a stable public API. Breaking changes break downstream apps and will be caught by the `PublicApiFacts` test.

| Allowed | Never |
|---------|-------|
| Add new overloads | Modify existing signatures |
| Add new methods | Remove public APIs |
| Add new classes | Change return types |

If a public API change is intentional, update the verified snapshot file:
`src/Orc.Feedback.Tests/PublicApiFacts.Orc_Feedback_HasNoBreakingChanges_Async.verified.txt`

### 3. Tests Are Mandatory

**Building alone is NOT sufficient.** Run tests before claiming completion (see [Commands](#commands)).

### 4. Branch Protection (COMPLIANCE REQUIRED)

**Direct commits to protected branches are a policy violation.**

| Repository | Protected Branches |
|------------|-------------------|
| Orc.Feedback | `master` |
| Orc.Feedback | `develop` |

**Required workflow:**

1. **Create a feature branch FIRST** — Use naming convention: `feature/issue-NNNN-description`
2. **Make all commits on the feature branch** — Never commit directly to protected branches
3. **Submit a Pull Request** — Changes must be reviewed by a human before merging

```bash
# CORRECT — Always create a feature branch first
git checkout -b feature/issue-1234-fix-description

# NEVER DO THIS — Policy violation
git checkout develop && git commit  # FORBIDDEN

# NEVER DO THIS — Policy violation
git checkout master && git commit  # FORBIDDEN
```

---

## Commands

Single source of truth for all commands:

| Task | Command |
|------|---------|
| **Build** | `dotnet cake --target=build` |
| **Test** | `dotnet cake --target=test` |
| **Build and test** | `dotnet cake --target=buildandtest` |

---

## Architecture & Directories

### Solution Overview

```
src/
  Orc.Feedback/           => Main library (WPF, net8.0-windows / net9.0-windows / net10.0-windows)
  Orc.Feedback.Tests/     => NUnit test project
```

### Key Types

| Type | Purpose |
|------|---------|
| `IFeedbackService` | Service interface for providing user feedback |
| `FeedbackService` | Default implementation; opens a URL in the browser via `IProcessService` |
| `OrcFeedbackModule` | Extension method to register services with DI (`AddOrcFeedback`) |

### Directory Guide

| Directory / File | Editable? | Notes |
|-----------------|-----------|-------|
| `*.generated.cs` | No | Leave as-is |
| `*.generated.xaml` | No | Leave as-is |
| `deployment/` | No | Deployment / build scripts |
| `src/Orc.Feedback/Services/` | Yes | Service implementations |
| `src/Orc.Feedback.Tests/` | Yes | Test project |
| `PublicApiFacts.*.verified.txt` | Yes (intentional API changes only) | Snapshot of public API |

---

## Writing Code

### Anti-Patterns (Never Do This)

| Anti-Pattern | Why |
|-------------|-----|
| Modifying public method signatures | ABI breaking |
| Manual edits to `*.generated.cs`, `*.generated.xaml` | Overwritten on regenerate |
| Using default parameters in public APIs | ABI breaking |
| **Skipping failing tests** | **Unacceptable — tests must pass** |

---

## Testing & Debugging

### Running Tests

```bash
dotnet cake --target=test
```

### Tests MUST Pass

> **NON-NEGOTIABLE:** Tests must PASS before claiming completion.
>
> - Do NOT skip failing tests
> - Do NOT claim completion if tests fail
> - Do NOT use `SkipException` to work around failures

### Writing Tests

1. Use NUnit to write tests
2. Create a Facts class for a feature
3. Combine Pascal / Snake case for test methods (e.g. `Feature_Does_Work`)

```csharp
[Test]
public void Feature_Does_Work()
{
    var result = 47 - 5;

    Assert.That(result, Is.EqualTo(42));
}
```

**Philosophy:** Tests FAIL when wrong, never skip (except missing hardware).

### Public API Snapshot Tests

The `PublicApiFacts` test verifies no unintentional breaking changes are introduced. If you intentionally change the public API:

1. Run the tests — they will fail with a diff showing the change.
2. Review the diff carefully.
3. Update the verified snapshot:
   `src/Orc.Feedback.Tests/PublicApiFacts.Orc_Feedback_HasNoBreakingChanges_Async.verified.txt`
4. Re-run the tests to confirm they pass.

### Debugging Methodology

1. **Establish baseline** — What's the known-good state?
2. **One change at a time** — Verify each change before proceeding
3. **Track changes in a table** — Log what you changed and the result
4. **Platform differences are signals** — If X works and Y fails, the difference IS the answer
5. **Revert if worse** — Don't pile fixes on top of failures

---

## Further Reading

| Topic | Document |
|-------|---------|
| Contributing guidelines | [CONTRIBUTING.md](CONTRIBUTING.md) |
| Catel documentation | https://docs.catelproject.com |
| WildGums open-source portal | https://opensource.wildgums.com |
