using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class SendScore : MonoBehaviour
{
    public void Send(int score)
    {
        StartCoroutine(PostScore(score));
    }

    IEnumerator PostScore(int score)
    {
        WWWForm form = new WWWForm();
        form.AddField("score", score);

        UnityWebRequest www = UnityWebRequest.Post("http://yourserver.com", form);
        yield return www.SendWebRequest();
    }
}
