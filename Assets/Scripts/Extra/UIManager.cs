using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Image hpBar;
    // This UIManager is used man in the middle that takes in a percentage that helps update the HP bar fill amount
    // The method is used within an event in editor
    public void ManagerHPBarState(float percentage)
    {
        hpBar.fillAmount = percentage;
    }

}
