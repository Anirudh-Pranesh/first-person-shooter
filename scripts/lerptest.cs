using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerptest : MonoBehaviour
{
    public Vector3 newpos;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = Vector3.Lerp(obj.transform.position, newpos, Time.deltaTime);
    }
}
