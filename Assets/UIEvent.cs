using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIEvent : MonoBehaviour
{
    [SerializeField]
    private Image iconUI;
    [SerializeField]
    private Text nameUI;
    [SerializeField]
    private Text decriptionUI;
    [SerializeField]
    private Text damageText;
    [SerializeField]
    private Text iconText;

   
    
    public void DisplayUI(SO UIobject)
    {
        nameUI.text = UIobject.NameObject;
        decriptionUI.text = UIobject.Description;
        damageText.text = UIobject.Damage.ToString();
        iconText.text = UIobject.IconImage.ToString();
        iconUI.sprite = UIobject.IconImage;
    }
}
