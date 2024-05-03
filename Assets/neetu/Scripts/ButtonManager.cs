using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonmanager : MonoBehaviour
{
    [SerializeField] GameObjectManager manager;
    [SerializeField] VideoLoader videoLoaderScript;
    [SerializeField] GameObject videoPlayerPrefab;

    private void Start()
    {
        manager.panel1.SetActive(true);
        videoPlayerPrefab.SetActive(false);
        
    }

    public void Button2010Clicked()
    {
        manager.panel1.SetActive(false);
        manager.panel2.SetActive(true);
        manager.grid1.SetActive(true);

        BackButtonClicked();
    }

    public void Button2011Clicked()
    {
        manager.panel1.SetActive(false);
        manager.panel2.SetActive(true);
        manager.grid2.SetActive(true);

        BackButtonClicked();
    }

    public void Button2012Clicked()
    {
        manager.panel1.SetActive(false);
        manager.panel2.SetActive(true);
        manager.grid3.SetActive(true);

        BackButtonClicked();
    }

    public void video1Clicked()
    {
        videoLoaderScript.LoadVideo("Bahara");
        manager.panel2.SetActive(false);
        manager.grid1.SetActive(false);

        ActivateVideoPlayerPrefab();

        BackButtonClicked();
    }

    public void video2Clicked()
    {
        videoLoaderScript.LoadVideo("Sadka");
        manager.panel2.SetActive(false);
        manager.grid2.SetActive(false);

        ActivateVideoPlayerPrefab();
    }

    public void video3Clicked()
    {
        videoLoaderScript.LoadVideo("Sugar");
        manager.panel2.SetActive(false);
        manager.grid1.SetActive(false);

        ActivateVideoPlayerPrefab();
    }

    public void video4Clicked()
    {
        videoLoaderScript.LoadVideo("Masakali");
        manager.panel2.SetActive(false);
        manager.grid2.SetActive(false);

        ActivateVideoPlayerPrefab();
    }

    public void video5Clicked()
    {
        videoLoaderScript.LoadVideo("Give me everything tonight");
        manager.panel2.SetActive(false);
        manager.grid2.SetActive(false);

        ActivateVideoPlayerPrefab();
    }

    public void video6Clicked()
    {
        videoLoaderScript.LoadVideo("Ik Junoon");
        manager.panel2.SetActive(false);
        manager.grid2.SetActive(false);

        ActivateVideoPlayerPrefab();
    }

    public void video7Clicked()
    {
        videoLoaderScript.LoadVideo("Te Amo");
        manager.panel2.SetActive(false);
        manager.grid3.SetActive(false);

        ActivateVideoPlayerPrefab();
    }

    public void video8Clicked()
    {
        videoLoaderScript.LoadVideo("Ik Junoon");
        manager.panel2.SetActive(false);
        manager.grid3.SetActive(false);

        ActivateVideoPlayerPrefab();
    }

    public void video9Clicked()
    {
        videoLoaderScript.LoadVideo("What makes you beautiful");
        manager.panel2.SetActive(false);
        manager.grid3.SetActive(false);

        ActivateVideoPlayerPrefab();
    }

    private void ActivateVideoPlayerPrefab()
    {
        if (videoPlayerPrefab != null)
        {
            Instantiate(videoPlayerPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Video player prefab is not assigned in the inspector.");
        }
    }

    private void BackButtonClicked()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ;
        }
    }
}
