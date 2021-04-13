using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;
 
public class SEND_INFO : MonoBehaviour {

     [SerializeField] InputField flag;
     
     [SerializeField] string url;

    public void Start() {
        url="http://127.0.0.1:5000/";
        WWWForm form = new WWWForm();
        form.AddField("flag",flag.text);
        form.AddField("Content-Type", "application/json");


        WWW www=new WWW(url,form);

        StartCoroutine(Upload(www));
    }
     
    IEnumerator Upload(WWW www) {
        yield return www;
     
        // UnityWebRequest www = UnityWebRequest.Post("http://127.0.0.1:5000/", form);
        // yield return www.SendWebRequest();
     
        // if (www.result != UnityWebRequest.Result.Success) {
        //     Debug.Log(www.error);
        // }
        // else {
        //     Debug.Log("Form upload complete!");
        // }
    }
}