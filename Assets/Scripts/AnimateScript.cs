using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateScript : MonoBehaviour
{
    public Sprite[] ImageToAnimate;
    public Image ImageObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ImageObject.sprite = ImageToAnimate[(int)(Time.time * (Shader.GetGlobalFloat(1)*15)) % ImageToAnimate.Length];
    }
}
