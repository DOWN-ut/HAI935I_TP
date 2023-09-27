using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, 0, z);
    }
}
