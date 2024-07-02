using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WindowDelayEffect : MonoBehaviour
{
    public GameObject targetUI;  // �\��������UI�I�u�W�F�N�g
    public float delay = 2.0f;   // �\���܂ł̒x������

    void Awake()
    {
        StartCoroutine(ShowUIAfterDelay());
    }

    IEnumerator ShowUIAfterDelay()
    {
        yield return new WaitForSeconds(delay); // �x��
        targetUI.SetActive(true); // UI��\��
    }
}
