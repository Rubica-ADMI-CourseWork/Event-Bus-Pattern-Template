using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

public class EventBus
{
    static Dictionary<EventType,UnityEvent> events = new Dictionary<EventType,UnityEvent>();
 

    public static void Subsribe(EventType typeToSubscribe, UnityAction listenerSubscribing)
    {
        UnityEvent thisEvent;

        if(events.TryGetValue(typeToSubscribe,out thisEvent)){
            thisEvent.AddListener(listenerSubscribing);
            Debug.Log("Successful subscription!");

        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listenerSubscribing);
            events.Add(typeToSubscribe, thisEvent);
            Debug.Log("Successful subscription!");
        }
    }
    public static void Publish(EventType typeOfEvent)
    {
        UnityEvent thisEvent;

        if (events.TryGetValue(typeOfEvent, out thisEvent))
        {
            thisEvent.Invoke();
        }
    }

    public static void Unsubscribe(EventType typeOfEvent, UnityAction listenerUnsubscribing)
    {
        UnityEvent thisEvent;

        if(events.TryGetValue(typeOfEvent, out thisEvent))
        {
            thisEvent.RemoveListener(listenerUnsubscribing);
        }
    }
}
