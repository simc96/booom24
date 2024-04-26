using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Event/LoadStateEventSO")]
public class LoadStateEventSO : ScriptableObject
{
    public UnityAction OnMenuEventRaised;
    public UnityAction OnStartTalkEventRaised;
    public UnityAction OnFixEventRaised;
    public UnityAction OnContinueTalkEventRaised;

    public void RaiseEvent(LoadState loadState)
    {
        switch (loadState)
        {
            case LoadState.Menu:
                OnMenuEventRaised?.Invoke(); 
                break;
            case LoadState.StartTalk:
                OnStartTalkEventRaised?.Invoke();
                break;
            case LoadState.Fix:
                OnFixEventRaised?.Invoke();
                break;
            case LoadState.ContinueTalk:
                OnContinueTalkEventRaised?.Invoke();
                break;
        }
    }
}