using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    void Update()
    {
        transform.position = PlayerMovement.playerPos;
    }
}
