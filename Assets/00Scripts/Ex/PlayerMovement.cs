using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput playerInput;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();    
    }

    private void Update()
    {
        playerInput.dir.Normalize();
        transform.position += new Vector3(playerInput.dir.x * Time.deltaTime * 3, 0, playerInput.dir.z * Time.deltaTime * 3);
    }
}
