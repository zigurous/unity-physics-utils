# Physics Utils

[![](https://img.shields.io/badge/github-repo-blue?logo=github)](https://github.com/zigurous/unity-physics-utils)
[![](https://img.shields.io/github/package-json/v/zigurous/unity-physics-utils)](https://github.com/zigurous/unity-physics-utils/releases)
[![](https://img.shields.io/badge/docs-link-success)](https://docs.zigurous.com/com.zigurous.physics)
[![](https://img.shields.io/github/license/zigurous/unity-physics-utils)](https://github.com/zigurous/unity-physics-utils/blob/main/LICENSE.md)

The Physics Utils package contains physics-related scripts and utilities for Unity projects. The package is still early in development, and more functionality will be added over time.

## Reference

- [Event Behaviors](https://docs.zigurous.com/com.zigurous.physics/manual/events.html)
- [Physics Materials](https://docs.zigurous.com/com.zigurous.physics/manual/materials.html)
- [Explosion (Script)](https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Explosion.html)
- [Magnet (Script)](https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Magnet.html)
- [Magnetic (Script)](https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Magnetic.html)

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
