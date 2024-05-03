using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VideoPlayerController : MonoBehaviour
{
    public VideoLoader videoLoaderScript;
    public VideoPlayerSO videoData;
    public TextMeshProUGUI videoInfoText;

    private GameObject videoPlayerPrefab;
    private float timer = 0f;
    private bool isShowing = false;

    void Update()
    {
        string currentlyPlayingVideo = videoData.currentlyPlayingVideo;
        if (!string.IsNullOrEmpty(currentlyPlayingVideo))
        {
            videoInfoText.text = "Currently playing: " + currentlyPlayingVideo;
        }

        if (isShowing)
        {
            timer += Time.deltaTime;
            if (timer >= 5f) 
            {
                videoPlayerPrefab.SetActive(false);
                isShowing = false;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == videoPlayerPrefab)
                {
                    videoPlayerPrefab.SetActive(true);
                    isShowing = true;
                    timer = 0f;
                }
            }
        }
    }
}
