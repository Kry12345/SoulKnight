using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private bool lockedOn = false;
    private bool shooting = false;
    private float startTime;
    [SerializeField] float health;
    PlayerStats playerStats;
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerStats check = col.gameObject.GetComponent<PlayerStats>();
        if (check != null)
        {
            playerStats = col.gameObject.GetComponent<PlayerStats>();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        PlayerStats check = col.gameObject.GetComponent<PlayerStats>();
        if (check != null)
        {
            playerStats = null;
            lockedOn = false;
        }
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (playerStats != null)
        {
            Debug.DrawRay(transform.position, transform.right * 5, Color.red);
            if (!lockedOn)
            {
                lockedOn = true;
                startTime = Time.realtimeSinceStartup;
            }
            if (!shooting)
            {
                Vector3 playerPos = playerStats.transform.position;
                Vector3 rotation = playerPos - transform.position;
                float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
                Quaternion q = Quaternion.AngleAxis(rotZ, Vector3.forward);
                transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 20);
                if (3 <= Time.realtimeSinceStartup - startTime)
                {
                    shooting = true;
                    StartCoroutine(shoot());
                }
            }
        }
    }

    IEnumerator shoot()
    {
        yield return new WaitForSeconds(1f);
        float tempStartTime = Time.realtimeSinceStartup;
        bool run = true;
        while (1 > Time.realtimeSinceStartup - tempStartTime)
        {
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, transform.right, 5f);
            foreach (RaycastHit2D hit in hits)
            {
                PlayerStats playerStats = hit.transform.gameObject.GetComponent<PlayerStats>();
                if (run && playerStats != null)
                {
                    PlayerMovement playerMovement = hit.transform.gameObject.GetComponent<PlayerMovement>();
                    playerStats.recieveDamage(50f);
                    playerMovement.knockback(Mathf.Cos(transform.eulerAngles.z * Mathf.Deg2Rad), Mathf.Sin(transform.eulerAngles.z * Mathf.Deg2Rad), 1000);

                    run = false;
                }
            }
            yield return new WaitForSeconds(0.04f);
        }
        shooting = false;
        lockedOn = false;
        
    }

    public void recieveDamage(float damage)
    {
        health -= damage;
    }
}
