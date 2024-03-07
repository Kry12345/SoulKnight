using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D col)
    {
        print(Vector3.forward);
        PlayerStats playerStats = col.gameObject.GetComponent<PlayerStats>();
        if (playerStats != null)
        {
            Vector3 playerPos = col.transform.position;
            Vector3 rotation = playerPos - transform.position;
            float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(rotZ, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 4);
        }
    }
}
