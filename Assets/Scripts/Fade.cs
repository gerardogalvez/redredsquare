using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Fade : MonoBehaviour {

    public Graphic gBlackSquare;
    void Start()
    {
        StartCoroutine("fade");
    }

    IEnumerator fade()
    {
        gBlackSquare.CrossFadeAlpha(0, 0, false);
        yield return new WaitForSeconds(1.0f);
        gBlackSquare.CrossFadeAlpha(1, 1, false);
        yield return new WaitForSeconds(3.0f);
        gBlackSquare.CrossFadeAlpha(0, 1, false);
        yield return new WaitForSeconds(1.0f);
        Application.LoadLevel("mainScene");
    }
   

}
