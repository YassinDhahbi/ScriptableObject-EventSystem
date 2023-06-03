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


Daniel Everland is a developer that created an asset pack that holds the essence of Ryan Hipple's talk. He put quite an effort to make the events and listeners and many other structures of data that could be held within scriptable objects.

Here is a link to the repo:
https://github.com/DanielEverland/ScriptableObject-Architecture

I thought of a different approach, something that could improve the usability of the event system at the cost of a little setup. It helps make the workflow much easier and modular.
This approach is using a singleton instance of a scriptable object. It needs to be initialized once at the start of the game.
This event manager can hold many events from a scriptable object architecture namespace and with them, you can have a very modular calling of events.

_**Note: The managers that are found in the hierarchy of the project could be used as scriptable objects with some modifications**_

# Implementation
## Main Classes
### ScriptableObjectSingleton
This class will serve as the base class that any manager you want to have as a scriptable object will inherit from.
All the managers that are created using this script as a parent, their instance(Scriptable Object Instance) needs to reside within the Resources folder.

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/60ebc8c0-1be9-4fab-ab42-26f6c29c867f)

### Event Manager
This is the event manager that will hold a reference to its instance and many events of many different types that could be raised by accessing it as a singleton from their classes.

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/bc279068-72c0-4127-829b-91ae4fa0ed0c)

## Use of events

### Creation

The creation of game event objects is done by going to Create > Game Events > ... 
Selecting your game event is based on the type of the event you're raising if it's something simple that doesn't have a parameter, you can select the normal game event object. Otherwise, you can select a type for your event from the list.

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/10d69349-fc1b-4d3e-958d-86f5f2f8db13)

For events to work when you call them, there is a Game Event Listener Component that needs to be added to a game object in your hierarchy.

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/bac6e8d0-fffc-45af-91e9-c2eca9cda8f4)

### Code Implementation
All you need to call or raise an event is to define it in the EvenntManager script

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/ca6717bc-fcdd-4a76-aa35-1e0ee1394bdb)

In the HP Manager, I called two types of events one that has a parameter and another that doesn't.
 Here is an example of how to call these events.
![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/c9851894-a944-4d6f-bc62-0a730432719c)

Back in the editor you need to : 
1. Drag your event to the previously created listener 
2. Drag the object that will be affected, you may use the simple Unity pre-defined functionalities or a script that belongs to the object selected
3. If the method you need has a parameter passed through code, then the method will be in the top section with the dynamic parameter category. Otherwise, you'll find it in the bottom section with the static parameters

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/bd45b779-2184-4009-8d4c-f4929f24814f)


## Initialization 
### Example
For this event manager to work or any other script that derives from the singleton parent to work, it needs to have a call to its Instance. For this, I created a relly simple method called Enable().
This should be called in the awake of script that is responsible for initializing these instance. Just like this : 

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/15f87601-86e8-4dab-94a5-260baee88fd9)

Then you just put it on any game object of your game, this initialization only need to happen once. That means it only needs to happen when you game starts.


# TIPS!!

## Tip 1: 
You can use Ctrl + D to duplicate an event and then change its name. This will save the repetitive click using the mouse. You need to make a copy from the correct event type for it to work as intended in your listener.

## Tip 2:
As the examples portrayed, game events could have multiple types from the normal int, float, vector 2, vector 3, and many more. But you could also raise those events as normal game events in case you want to execute functionality that doesn't need a parameter but need to happen simultaneously. 

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/242ec906-10d8-4c2e-9419-9b1d2735a29c)


## Tip 2:
Organizing your event listeners is the hierarchy can be difficult. So you can use this method :

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/1b0da28e-0b0b-4b22-bdd2-683c77def861)

![image](https://github.com/YassinDhahbi/ScriptableObject-EventSystem/assets/90442257/d7f86172-7b91-407d-b6dd-53edb5e34f31)


