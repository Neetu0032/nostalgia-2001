using UnityEngine;
using UnityEditor;
using UnityEngine.Video;

public class VideoLoader : MonoBehaviour
{
    public VideoPlayerSO videoData;
    public VideoPlayer videoPlayerComponent;

    public void LoadVideo(string videoName)
    {
        foreach (var videoInfo in videoData.videos)
        {
            if (videoInfo.videoName == videoName)
            {
                string videoPath = videoInfo.videoPath;

                var videoClip = AssetDatabase.LoadAssetAtPath<VideoClip>(videoPath);
                if (videoClip != null)
                {
                    videoPlayerComponent.source = VideoSource.VideoClip;
                    videoPlayerComponent.clip = videoClip;
                    videoPlayerComponent.Play();

                    videoData.currentlyPlayingVideo = videoName;

                    return;
                }
            }
        }
        Debug.LogWarning("Video not found: " + videoName);
    }
}
