using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text kills;
    [SerializeField]
    TMP_Text timer;

    private void Update()
    {
        kills.text = " CatBot elimines : " + GameManager.instance.CatBotKills.ToString();
        timer.text = " Time : " + GameManager.instance.CurrentTime.ToString("F2");
    }
}
