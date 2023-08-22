using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFSM<T> : MonoBehaviour
{

    public class StateTransitionInfo
    {
        public T nowState { get; set; }
        public T nextState { get; set; }

        public StateTransitionInfo(T nowState, T nextState)
        {
            this.nowState = nowState;
            this.nextState = nextState;
        }

        public override int GetHashCode()
        {
            return 16 + 30 * this.nowState.GetHashCode() + 30 * this.nextState.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            StateTransitionInfo other = obj as StateTransitionInfo;
            return other != null
                && this.nowState.Equals(other.nowState)
                && this.nextState.Equals(other.nextState);
        }
    }

    protected Dictionary<StateTransitionInfo, T> dictionaryTransition;

    public T nowState;
    public T previousState;

    protected BaseFSM()
    {
        if (!typeof(T).IsEnum)
        {
            Debug.Log($"{typeof(T).FullName} is not state");
        }
    }

    private T getNextState(T nextState)
    {
        StateTransitionInfo transitionInfo = new StateTransitionInfo(nowState, nextState);

        T refNextState;

        if(!dictionaryTransition.TryGetValue(transitionInfo, out refNextState))
        {
            Debug.Log($"Invalid State transition from {nowState} to {nextState}");
        }
        else
        {
            Debug.Log($"Next state {refNextState}");
        }

        return refNextState;
    }

    public bool searchNextState(T nextState)
    {
        StateTransitionInfo stateTransitionInfo = new StateTransitionInfo(nowState, nextState);
        T refNextState;

        if(!dictionaryTransition.TryGetValue(stateTransitionInfo, out refNextState))
        {
            Debug.Log($"Invalid state transition from {nowState} to {refNextState}");
            return false;
        }
        else
        {
            return true;
        }
    }

    public T NextStateMove(T nextState)
    {
        previousState = nextState;
        nowState = getNextState(nextState);
        Debug.Log($"Change state from {previousState} to {nowState}");
        return nextState;
    }
}
