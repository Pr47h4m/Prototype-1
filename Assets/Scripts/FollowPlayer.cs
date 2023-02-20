using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 positionOffset = new Vector3(0, 5, -6);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after Update()
    void LateUpdate()
    {
        transform.position = player.transform.position + positionOffset;
    }
}
