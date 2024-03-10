using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public static int Money;
    public static int rate = 1;
    public Text moneyText;

    public void Click()
    {
        Money += rate;
    }
    
    public void Update()
    {
        moneyText.text = Money.ToString();
    }

}
