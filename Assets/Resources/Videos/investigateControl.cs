using UnityEngine;
using UnityEngine.Video;

public class investigateControl : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private MeshRenderer quadRenderer;
    void Start()
    {
        videoPlayer = GetComponentInChildren<VideoPlayer>();
        quadRenderer = GetComponentInChildren<MeshRenderer>();

        videoPlayer.loopPointReached += OnVideoFinished;

        quadRenderer.enabled = true;

        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        quadRenderer.enabled = false;
    }
}
