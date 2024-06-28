using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject textObject;

    void Start()
    {
        // ���悪�I�������Ƃ��̃C�x���g��ݒ�
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // ���悪�I�������瓮����\���ɂ���
        videoPlayer.gameObject.SetActive(false);
        
        // �e�L�X�g��\������
        textObject.SetActive(true);
    }
}