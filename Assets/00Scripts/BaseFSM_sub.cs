using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Idle,
    Run,
    Jump,
}

public class BaseFSM_sub : BaseFSM<PlayerState>
{
    public BaseFSM_sub() : base()
    {
        this.nowState = PlayerState.Idle;
        this.dictionaryTransition = new Dictionary<StateTransitionInfo, PlayerState>
        {
            {new StateTransitionInfo(PlayerState.Idle, PlayerState.Run), PlayerState.Run },
            {new StateTransitionInfo(PlayerState.Run, PlayerState.Jump), PlayerState.Jump},
        };
    }
}
