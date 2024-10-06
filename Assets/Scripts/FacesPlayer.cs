//using UnityEngine;
//using System.Collections;

//public class FacesPlayer : MonoBehaviour {
    
//    public float rotSpeed = 90f;
//    Transform player;

//    void Update () {
//        if(player == null) {
//            GameObject.Find ("PlayerShip");

//            if(global != null) {
//                player = global.transfrom;
//            }
//        }

//        if(player == null)
//            return;

//            Vector3 dir = player.position - transform.position;
//            dir.Normalize();

//            float zAngle = Math.Atan2(dir.y, dir.x) * Mathf. Rad2Deg - 90;
//            Quanternion desiredRot = Quaternion.Euler(0, 0, zAngle);
//            transfrom.rotation = Quaternion.RotateTowards( transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
//    }
//}

