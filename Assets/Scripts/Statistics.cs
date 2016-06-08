using UnityEngine;
using System.Collections;

public class Statistics : MonoBehaviour
{
    int deathCounter = 0;
    static GameObject thisObject;

    void Awake()
    {
        if (thisObject == null)
            thisObject = this.gameObject;
        else
            Destroy(this.gameObject);

        Object.DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        //Object.DontDestroyOnLoad(this.gameObject);
    }

    void OnLevelWasLoaded()
    {
        deathCounter++;
        Debug.Log("Deaths: " + deathCounter);
    }
}
