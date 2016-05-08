using UnityEngine;
using System.Collections.Generic;

public class EndlessTunnel : MonoBehaviour {

    public List<GameObject> modules;
    private GameObject lastModule;

    void Awake()
    {
        lastModule = transform.GetChild(transform.childCount - 1).gameObject;
    }


    void AppendModule()
    {
        GameObject module = modules[Random.Range(0, modules.Count)];
        AppendModule(module);
    }

    void AppendModule(GameObject module)
    {
        GameObject m = Instantiate(module);
        m.transform.parent = this.gameObject.transform;
        m.transform.position = lastModule.transform.position - new Vector3(0, 10, 0); //#! Change '10' to a correct value !#

        lastModule = m;
    }
}
