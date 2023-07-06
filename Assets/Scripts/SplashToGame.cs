using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashToGame : MonoBehaviour
{
    public GameObject splashWhite;
    public GameObject splashText;

    void Start()
    {
        StartCoroutine(SplashEnd());
    }

    IEnumerator SplashEnd()
    {
        // zobrazení úvodní obrazovky
        yield return new WaitForSeconds(3);
        splashText.SetActive(false);
        splashWhite.SetActive(false);
    }

}
