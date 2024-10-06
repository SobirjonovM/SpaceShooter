using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            Debug.Log("Pew Pew!");
            cooldownTimer = fireDelay;
        }
    }
}

