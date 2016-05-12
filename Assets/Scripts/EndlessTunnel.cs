using UnityEngine;
using System.Collections.Generic;

public class EndlessTunnel : MonoBehaviour {

    public GameObject walls;
    public List<GameObject> modules;
    private GameObject lastModule;

    void Awake()
    {
        lastModule = transform.GetChild(transform.childCount - 1).gameObject;
    }


    public void AppendModule()
    {
        GameObject module = modules[Random.Range(0, modules.Count)];

        AppendModule(module);
    }

    public void AppendModule(GameObject obstacle)
    {
        CompositeTunnelModule composite = obstacle.GetComponent<CompositeTunnelModule>();
        if (composite != null)
        {
            composite.AttachTo(this);
            return;
        }

            GameObject m = new GameObject("Module");
        m.tag = "TunnelModule";
        m.transform.parent = this.gameObject.transform;
        m.transform.position = lastModule.transform.position - new Vector3(0, 8.25f, 0); //#! Change '10' to a correct value !#

        GameObject w = Instantiate(walls);
        w.transform.parent = m.transform;
        w.transform.position = m.transform.position;

        GameObject o = Instantiate(obstacle);
        o.transform.parent = m.transform;
        o.transform.position = o.transform.position + m.transform.position;

        lastModule = m;
    }
}
