/*
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Text;

public class CallOpenAIAPI : MonoBehaviour
{
    private string apiKey = "sk-proj-4dGRRMLBooF12IjcmJLnT3BlbkFJGKPMpkLQjGrz3dFfUJNJ"; // OpenAI API�L�[�����
    private string prompt = "Hello, I'd like you to act as a helpful assistant."; // �v�����v�g�����
    private string model = "text-davinci-003"; // �g�p���郂�f�����w��

    void Start()
    {
        Debug.Log("�����܂ł���");
        StartCoroutine(SendRequest(prompt));
    }

    IEnumerator SendRequest(string prompt)
    {
        // ���N�G�X�gURL���쐬
        string url = "https://api.openai.com/v1/chat/completions";

        // ���N�G�X�g�{�f�B���쐬
        string jsonBody = "{\"model\":\"" + model + "\",\"prompt\":\"" + prompt + "\",\"max_tokens\":50}";

        // UnityWebRequest���쐬
        using (UnityWebRequest request = new UnityWebRequest(url, "POST"))
        {
            // ���N�G�X�g�{�f�B��ݒ�
            byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonBody);
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);

            // �w�b�_�[��ݒ�
            request.SetRequestHeader("Authorization", "Bearer " + apiKey);
            request.SetRequestHeader("Content-Type", "application/json");

            // ���N�G�X�g�𑗐M
            yield return request.SendWebRequest();

            // ���X�|���X������
            if (request.result == UnityWebRequest.Result.Success)
            {
                // ���X�|���X�̕�������擾
                string responseText = request.downloadHandler.text;
                Debug.Log("Response: " + responseText);
            }
            //���s�����Ƃ���
            else
            {
                Debug.Log("�G��������������������������");
                Debug.LogError("Error: " + request.responseCode + " - " + request.error);
            }
        }
    }
}
*/