using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListenerHandler : MonoBehaviour
{
    public GameEventListener[] listeners;

    private void OnEnable() {
        foreach (var eventListener in listeners){
            foreach (var Event in eventListener.events) {
                //Debug.Log($"subscribing {eventListener} to {Event}");
                Event.RegisterListener(eventListener);
            }
        }
    }

    private void OnDisable() {
        foreach (var eventListener in listeners) {
            foreach (var Event in eventListener.events) {
                Event.UnregisterListener(eventListener);
            }
        }
    }

}
