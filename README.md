# ScriptableObject-EventSystem
Hello fellow Unity Developers!
I'd like to share with you a tool I've been working on and testing for a while. It's something I call the Scriptable Object Event System. Before we get into what it is and how it functions, let's talk about scriptable objects and how their concept revolutionized the workflow of a Unity developer.
A scriptable object is an instance of a script, instead of dragging and dropping as a component on an object in the hierarchy, this instance lives among the files of your project. What can we do with this instance, you ask? 
Well, we can use it as a preset of stored data that we can swap and select and use in real time. That was its main purpose at the start. But as time progressed it became possible to use it as a container for methods that you can access whenever you need. You'd probably ask at this point, what's the difference between a singleton and this scriptable object?
The difference is that you don't need to initialize and maintain a scriptable object in order for it to be used. It just exists and works from the moment you create the instance. 
Later something else happened, scriptable objects became capable of holding and subscribing to events. That in itself is amazing. One of its advantages is that it can bind functionality to inputs without the need to even interact with the content of the scene. 

Ryan Hipple, a developer at Schell Games, gave an interesting new use of scriptable objects. 
Using a combination of Unity events and the possibility to create multiple instances from a scriptable game object. It was possible to create an event system that makes your code so modular. This new workflow gave so much-needed refreshment to the way the editor and script interacted. 
But one of the things that was a little annoying is the repetitive actions of creating an event in the script that needed it. 

I thought of a different approach, something that could improve the usability of the event system at the cost of a little setup. It helps make the workflow much easier and modular.
