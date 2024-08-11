using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject player;
    private Vector3 camOffset = new Vector3(0,0,-10);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = player.transform.position + camOffset;
    }
}
