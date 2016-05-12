using UnityEngine;
using System.Collections.Generic;

public class CompositeTunnelModule : MonoBehaviour {

    public List<GameObject> obstacles;

    public void AttachTo(EndlessTunnel tunnel)
    {
        foreach (var obstacle in obstacles)
            tunnel.AppendModule(obstacle);

        Debug.Log(transform.parent);
    }
}
