using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class GameEventListener{
    public String name;
    public List<GameEvent> events;
    public UnityEvent response;


    public void OnEventRaised() {
        response.Invoke();
    }

}
