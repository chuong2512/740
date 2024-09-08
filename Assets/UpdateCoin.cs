using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCoin : MonoBehaviour
{
    [SerializeField] private Text text;

    private void Update()
    {
        var coinAmount = PlayerPrefs.GetFloat(Constants.COIN, 0);
        text.text = ((int)coinAmount).ToString();
    }
}
