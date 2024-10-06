using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
   public float maxSpeed = 5f;
   public float rotSpeed = 180f;
    void Start (){

    }

    void Update () {
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;

        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        rot = Quaternion.Euler(0, 0, z);

        transform.rotation = rot;

        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime);

       pos += rot * velocity;
       
        transform.position = pos;
    }
}