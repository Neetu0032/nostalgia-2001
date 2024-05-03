using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoUIController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Slider videoSlider;
    public Button playButton;
    public Button pauseButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayVideo);
        pauseButton.onClick.AddListener(PauseVideo);
    }

    private void Update()
    {
        if (videoPlayer != null && videoPlayer.isPlaying)
        {
            videoSlider.value = (float)(videoPlayer.time / videoPlayer.length);
        }
    }

    private void PlayVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }

    private void PauseVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Pause();
        }
    }
}
