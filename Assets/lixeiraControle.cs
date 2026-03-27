using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixeiraControle : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); 
        this.transform.position += new Vector3(horizontalInput*velocity,0,0);
    } 
}
