using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoBreakMusicPLS : MonoBehaviour {

    public void MusicNoBreakJutsu()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
