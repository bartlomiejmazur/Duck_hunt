using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCelownik : MonoBehaviour
{

    public void celownik1()
    {
        PlayerPrefs.SetInt("celownik", 1);
    }

    public void celownik2()
    {
        PlayerPrefs.SetInt("celownik", 2);

    }

    public void celownik3()
    {
        PlayerPrefs.SetInt("celownik", 3);

    }

    public void celownik4()
    {
        PlayerPrefs.SetInt("celownik", 4);

    }
}
