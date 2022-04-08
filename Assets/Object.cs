using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;
    private void OnMouseDown()
    {
        gameEvent.Raise();
    }
}
