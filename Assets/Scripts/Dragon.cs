using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField]
    new Light light;

    private void Update()
    {
        light.gameObject.SetActive(GameManager.instance.EnoughCatBotKilled);
    }
    void OnTriggerEnter(Collider other)
 {
 if (other.tag == "Player" && GameManager.instance.EnoughCatBotKilled )
 {
 GameManager.instance.ChangeScene();
}
 }
}
