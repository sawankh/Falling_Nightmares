using UnityEngine;
using System.Collections;

public class SlowPickup : MonoBehaviour {

    public float slowAmount = 2f;

    private bool busy = false;

    void OnTriggerEnter(Collider other)
    {
        if (!IsPlayer(other.gameObject) || busy)
            return;

        busy = true;
        Destroy(transform.parent.gameObject); //#! gradual
        Time.timeScale = Mathf.Max(1, Time.timeScale - slowAmount);
    }

    bool IsPlayer(GameObject o)
    {
        while (o.tag != "Player")
        {
            if (o.transform.parent == null)
                return false;

            o = o.transform.parent.gameObject;
        }
        return true;
    }
}
