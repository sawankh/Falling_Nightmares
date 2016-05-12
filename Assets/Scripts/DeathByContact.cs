using UnityEngine;
using System.Collections.Generic;

public class DeathByContact : MonoBehaviour {

    public DeathScreen deathScreen;

    private bool dead = false;

    void OnCollisionEnter(Collision other)
    {
        if (IsObstacle(other.collider.gameObject))
            Die();
    }

    bool IsObstacle(GameObject o)
    {
        int obstacleLayer = LayerMask.NameToLayer("Obstacle");

        while (o.layer != obstacleLayer)
        {
            if (o.transform.parent == null)
                return false;

            o = o.transform.parent.gameObject;
        }

        return true;
    }

    void Die()
    {
        if (dead) return;

        deathScreen.Dead();

        dead = true;
    }
}
