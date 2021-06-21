using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        //Destroy(gameObject);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Score.scoreValue += 50;
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
