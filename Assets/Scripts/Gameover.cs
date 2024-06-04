using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Text gameOverText;      // "�Q�[���I�[�o�[" �e�L�X�g
    public Button restartButton;   // "�X�^�[�g��ʂɖ߂�" �{�^��
    public Text scoreText;         // ���𐔂�\������e�L�X�g

    void Start()
    {
        // UI�v�f��\������
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);

        // �X�R�A���O������󂯎�� (��FPlayerPrefs����擾)
        int score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Score: " + score;
    }

    public void OnRestartButton()
    {
        // �X�^�[�g��ʂɖ߂鏈���i�X�^�[�g��ʂ̃V�[�������w��j
        SceneManager.LoadScene("StartScene");
    }
}