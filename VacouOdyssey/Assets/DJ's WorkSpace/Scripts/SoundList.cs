using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class SoundList : MonoBehaviour
{
    public SoundGroup[] soundGroups = new SoundGroup[0];

    Dictionary<string, AudioClip[]> groupDictionary = new Dictionary<string, AudioClip[]>();


    void Awake()
    {

        //DontDestroyOnLoad(transform.gameObject);
        foreach (SoundGroup soundGroup in soundGroups)
        {
            groupDictionary.Add(soundGroup.audioGroupID, soundGroup.group);
        }

    }

    public AudioClip GetClipFromName(string audioName)
    {
        if (groupDictionary.ContainsKey(audioName))
        {
            AudioClip[] sounds = groupDictionary[audioName];
            //return sounds[0];
            return sounds[Random.Range(0, sounds.Length)];
        }
        return null;
    }

    [System.Serializable]
    public class SoundGroup
    {
        public string audioGroupID;
        public AudioClip[] group;
        [Range(0.0f, 1.0f)]
        static float sliderFloat;

    }
}