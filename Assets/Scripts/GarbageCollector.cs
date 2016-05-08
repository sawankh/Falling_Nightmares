using UnityEngine;
using System.Collections;

public class GarbageCollector : MonoBehaviour {

    public GameObject tunnelGenerator;

    void Awake()
    {
        if (tunnelGenerator == null)
            tunnelGenerator = GameObject.Find("Tunnel");
    }


    private bool busy = false;

    void Update()
    {
        busy = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (busy) return;

        GameObject o = other.gameObject;
        while (o != null && o.tag != "TunnelModule")
            o = o.transform.parent.gameObject;

        if (o == null)
            return;

        Destroy(o);
        tunnelGenerator.SendMessage("AppendModule");
        busy = true;
    }
}
