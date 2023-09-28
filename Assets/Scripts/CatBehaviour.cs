using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject deathEffect;

    private void Awake()
    {
        deathEffect.gameObject.SetActive(false);
    }

    void Death()
    {
        GameManager.instance.KilledCatBot();

        deathEffect.gameObject.SetActive(true);
        deathEffect.transform.parent = null;

        Destroy(gameObject);
        Destroy(deathEffect, 3f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Death();
        }
    }
}