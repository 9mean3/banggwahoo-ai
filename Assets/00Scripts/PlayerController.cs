using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
        BaseFSM_sub hfsm = new BaseFSM_sub();
        Debug.Log($"Now State : {hfsm.nowState}");
        Debug.Log($"Command.begin : now state : {hfsm.NextStateMove(PlayerState.Run)}");
        Debug.Log($"Invalid transition : {hfsm.searchNextState(PlayerState.Idle)}");
        Debug.Log($"Previous state : {hfsm.previousState}");

    }
}
