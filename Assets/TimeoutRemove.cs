using UnityEngine;
using System.Collections;

public class TimeoutRemove : MonoBehaviour {

	void Start () {
        Invoke("Hide", 2f);
	}

    void Hide()
    {
        gameObject.SetActive(false);
    }
}
