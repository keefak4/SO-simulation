using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="object",menuName ="ObjcectStandart")]
public class SO : ScriptableObject
{
    [SerializeField]
    private string nameObject;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private float damage;
    [SerializeField]
    private int coins;

    public string NameObject
    {
        get
        {
            return nameObject;
        }
    }
    public string Description
    {
        get
        {
            return description;
        }
    }
    public Sprite IconImage
    {
        get
        {
            return icon;
        }
    }
    public float Damage
    {
        get
        {
            return damage;
        }
    }
    public int Coins
    {
        get
        {
            return coins;
        }
    }
}
