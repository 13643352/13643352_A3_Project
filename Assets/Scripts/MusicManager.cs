using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource startMusic;
    public AudioSource BGM;
    public float BGMDelay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BGMDelay = BGM.time;

        BGM.Play((ulong)BGMDelay);
    }
}
