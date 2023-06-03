using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    // The class houses the variable that control the HP of the player
    [SerializeField]
    float maxHp;
    [SerializeField]
    float currentHp;
    // In this line we're initializing the currentHp and giving a max Hp value
    private void Awake()
    {
        currentHp = maxHp;
    }
    // The method is used within an event in editor and it takes in an amount to substract from the current hp if it's low then the player died
    public void DecreaseHP(float amount)
    {
        if (currentHp > amount)
        {
            currentHp -= amount;
            EventManager.Instance.OnPlayerHurt.Raise(currentHp / maxHp);
        }
        else
        {
            EventManager.Instance.OnPlayerDeath.Raise();
        }

    }
}
