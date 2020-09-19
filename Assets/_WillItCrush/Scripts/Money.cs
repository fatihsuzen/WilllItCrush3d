using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static int money;

    public void MoneyValueMinus(int minusValue)
    {
        money -= minusValue;
    }

}
