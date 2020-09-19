using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    private void OnCollisionEnter(Collision collision)
    {
        Money.money++;
        moneyText.text = Money.money.ToString()+"$";
        collision.gameObject.SetActive(false);
    }
}
