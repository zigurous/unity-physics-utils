# Event Behaviors

It is very common for scripts in Unity projects to respond to collision/trigger events using Unity's event callback functions, such as `OnCollisionEnter` and `OnTriggerEnter`. In such events, you might need to communicate a state change to another object. This often leads to a lot of boilerplate code and miscellaneous scripts.

The Physics Utils package comes with several behaviors that serialize event callbacks into the editor so all you have to do is pick the function you want to be called on any object on any script anywhere in your scene. It eliminates having to create entirely new scripts whenever you need a simple response to an event.

The great thing about Unity's event system is that it is not limited to only functions. You can also invoke property getters/setters, and you can even pass in arguments to functions. Let's say you want to damage your character's health when they enter an unsafe trigger zone, you could easily do that without writing any new code.

<img src="../images/event.png" width="480"/>

### Behaviors

- [CollisionEnter](xref:Zigurous.Physics.Events.CollisionEnter)
- [CollisionEnter2D](xref:Zigurous.Physics.Events.CollisionEnter2D)
- [CollisionExit](xref:Zigurous.Physics.Events.CollisionExit)
- [CollisionExit2D](xref:Zigurous.Physics.Events.CollisionExit2D)
- [CollisionStay](xref:Zigurous.Physics.Events.CollisionStay)
- [CollisionStay2D](xref:Zigurous.Physics.Events.CollisionStay2D)
- [TriggerEnter](xref:Zigurous.Physics.Events.TriggerEnter)
- [TriggerEnter2D](xref:Zigurous.Physics.Events.TriggerEnter2D)
- [TriggerExit](xref:Zigurous.Physics.Events.TriggerExit)
- [TriggerExit2D](xref:Zigurous.Physics.Events.TriggerExit2D)
- [TriggerStay](xref:Zigurous.Physics.Events.TriggerStay)
- [TriggerStay2D](xref:Zigurous.Physics.Events.TriggerStay2D)
