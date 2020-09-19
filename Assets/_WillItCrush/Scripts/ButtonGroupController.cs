using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGroupController : MonoBehaviour
{
    GameInUpgrade GameInUpgrade = new GameInUpgrade();
    void Start()
    {
        //InvokeRepeating("SpeedButtonFunc", 0.5f, 0.5f);
    }
    public void Controller(int ButtonValue,Button Button)
   {
      if (Money.money < ButtonValue)
      {
        Button.interactable = false;
      }

   }
    public void SpeedButtonFunc()
    {
        Controller(GameInUpgrade.SpeedPrice, GameInUpgrade.ButtonSpeed);
    }
}
