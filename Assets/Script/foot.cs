using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class foot : StateMachineBehaviour
{
    [SerializeField]
    private AudioClip audioClip;

    [SerializeField]
    private AudioMixerGroup audioMixerGroup;

    [SerializeField]
    private List<float> executeTimeList;

    private bool isInitialized = false;
    private int currentLoopCount = 0;
    private Dictionary<float, bool> executedTimeDictionary;
    private AudioSource audioSource;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!isInitialized)
        {
            audioSource = CreateAudioSource(animator.gameObject);
            executedTimeDictionary = new Dictionary<float, bool>();
            isInitialized = true;
        }

        InitExecutedTimeDictionary();
        currentLoopCount = 0;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var executedTimeList = new List<float>(executedTimeDictionary.Keys);
        foreach (var executedTime in executedTimeList)
        {
            if (executedTime < stateInfo.normalizedTime % 1 && !executedTimeDictionary[executedTime])
            {
                audioSource.Play();
                executedTimeDictionary[executedTime] = true;
            }
        }

        if (currentLoopCount < Mathf.FloorToInt(stateInfo.normalizedTime))
        {
            InitExecutedTimeDictionary();
            currentLoopCount = Mathf.FloorToInt(stateInfo.normalizedTime);
        }
    }

    private AudioSource CreateAudioSource(GameObject animatorGameObject)
    {
        var audioGameObject = new GameObject();
        audioGameObject.name = "AnimationStateSEPlayer";
        audioGameObject.transform.SetParent(animatorGameObject.transform);

        var audioSource = audioGameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.outputAudioMixerGroup = audioMixerGroup;

        return audioSource;
    }

    private void InitExecutedTimeDictionary()
    {
        executedTimeDictionary.Clear();
        executeTimeList.ForEach(t => executedTimeDictionary.Add(t, false));
    }
}
