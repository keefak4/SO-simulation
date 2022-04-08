using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventList : MonoBehaviour
{
    [SerializeField]
    private GameEvent gameEvent;
    [SerializeField]
    private UnityEvent unity;

    public void OnEventRaised()
    {
        unity.Invoke();
    }
    private void OnEnable()
    {
        gameEvent.RegisterList(this);
    }
    private void OnDisable()
    {
        gameEvent.UnRegisterList(this);
    }
}
