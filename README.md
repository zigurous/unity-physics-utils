# Physics Utils

The Physics Utils package contains physics-related scripts and utilities for Unity projects. The package is still very early in development, and new scripts and functionality will be added over time.

## Installation

Use the Unity [Package Manager](https://docs.unity3d.com/Manual/upm-ui.html) to install the Physics Utils package.

1. Open the Package Manager in `Window > Package Manager`
2. Click the add (`+`) button in the status bar
3. Select `Add package from git URL` from the add menu
4. Enter the following Git URL in the text box and click Add:

```http
https://github.com/zigurous/unity-physics-utils.git
```

For more information on the Package Manager and installing packages, see the following pages:

- [Unity's Package Manager](https://docs.unity3d.com/Manual/Packages.html)
- [Installing from a Git URL](https://docs.unity3d.com/Manual/upm-ui-giturl.html)

### Importing

Import the package namespace in each script or file you want to use it.

> **Note**: You may need to regenerate project files/assemblies first.

```csharp
using Zigurous.Physics;
```
