using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {
    int bulletLayer;

    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;

    public float fireDelay = 0.50f;
    float cooldownTimer = 0;
    Transform player;
    void Start(){
        bulletLayer = gameObject.layer;
    }
    void Update(){

        if(player == null) {
            GameObject go = GameObject.FindWithTag("Player");
            if (go != null)
            {
                player = go.transform;
            }
        }
        cooldownTimer -= Time.deltaTime;
        if(cooldownTimer <=0 ){
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
             bulletGO.layer = bulletLayer;
        }
    }
}

