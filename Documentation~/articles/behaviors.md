---
slug: "/manual/behaviors"
---

# Behaviors

The **Physics Utils** package includes a few scripts for simulating different physics behaviors. These scripts are flexible, customizable and can be used in many different situations.

<hr/>

## 💥 Explosion

It is very common for games to need to simulate explosion physics. The [Explosion](/api/Zigurous.Physics/Explosion) script simulates this behavior on rigidbodies by utilizing the `AddExplosionForce` function provided by Unity. The script detects the objects within a set radius and applies the force to each. You can customize how the explosion is triggered, the strength of the explosion, fuse time, and more.

<hr/>

## 🧲 Magnet

The [Magnet](/api/Zigurous.Physics/Magnet) script can be added to a game object that attracts other objects, and the [Magnetic](/api/Zigurous.Physics/Magnetic) script is added to those objects that can be attracted. This works with or without rigidbodies. A common use case is having the player character attract items or pickups on the ground. This allows the player to collect items from a slight distance as a quality of life improvement.
