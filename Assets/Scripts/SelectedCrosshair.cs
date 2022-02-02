using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCrosshair : MonoBehaviour
{
    private static readonly string celownik = "celownik";
    public Sprite Celownik_1;
    public Sprite Celownik_2;
    public Sprite Celownik_3;
    public Sprite Celownik_4;
    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerPrefs.GetInt(celownik))
        {
            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Celownik_1;
                break;
            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Celownik_2;
                break;
            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Celownik_3;
                break;
            case 4:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Celownik_4;
                break;
            default:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Celownik_1;
                break;
        }

        
    }

}
