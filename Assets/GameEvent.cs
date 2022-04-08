using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "gameEvent", menuName = "gameEvent")]

public class GameEvent : ScriptableObject
{
    [SerializeField]
    private List<GameEventList> gameEventLists = new List<GameEventList>();
    public void Raise()
    {
        for (int i = gameEventLists.Count - 1;i >= 0; i--)
        {
            gameEventLists[i].OnEventRaised();
        }
    }
    public void RegisterList(GameEventList gameEventList)
    {
        gameEventLists.Add(gameEventList);
    }
    public void UnRegisterList(GameEventList gameEventList)
    {
        gameEventLists.Remove(gameEventList);
    }
}
