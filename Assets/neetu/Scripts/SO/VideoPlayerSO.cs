using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VideoData", menuName = "ScriptableObjects/VideoData", order = 1)]
public class VideoPlayerSO : ScriptableObject
{
    [System.Serializable]
    public class VideoInfo
    {
        public string videoName;
        public string videoPath;
    }

    public VideoInfo[] videos = new VideoInfo[10];
    public string currentlyPlayingVideo; 
}
