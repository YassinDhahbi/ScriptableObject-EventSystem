using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu(fileName = "Event Manager", menuName = "Managers/Event Manager")]

// This is the event manager, it should be in your resources folder
public class EventManager : ScriptableObjectSingleton<EventManager>
{
    // The events in this scriptable object are used within the editor via a game event listener of the same type
    public GameEvent OnPlayerCollision;
    public FloatGameEvent OnPlayerHurt;
    public GameEvent OnPlayerDeath;
    public void Enable()
    {

    }
}