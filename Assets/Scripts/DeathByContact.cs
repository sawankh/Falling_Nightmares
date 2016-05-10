using UnityEngine;
using System.Collections.Generic;

public class DeathByContact : MonoBehaviour {

    public DeathScreen deathScreen;

    private bool dead = false;

    void OnTriggerEnter(Collider other)
    {
        Die();
    }

    void OnCollisionEnter(Collision other)
    {
        GameObject o = other.collider.gameObject;
        int obstacleLayer = LayerMask.NameToLayer("Obstacle");

        while (o.layer != obstacleLayer)
        {
            if (o.transform.parent == null)
                return;

            o = o.transform.parent.gameObject;
        }

        Die();
    }

    void Die()
    {
        if (dead) return;

        deathScreen.Dead();

        dead = true;
    }
}
