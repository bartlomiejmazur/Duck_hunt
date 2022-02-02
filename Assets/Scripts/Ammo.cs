using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject[] ammo;
    [SerializeField]
    private GameObject end;
    
    AudioSource m_shootingSound;
    AudioSource m_looseSound;
    public static int ammoAmount;
    public AudioSource ShootSound;
    public AudioSource LooseSound;
    public Texture2D cursorArrow;
    public GameObject crossheir;
    // Start is called before the first frame update
    void Start()
    {
        m_shootingSound = ShootSound;
        m_looseSound = LooseSound;
        ammoAmount = 4;
    }
  
   
    // Update is called once per frame
     public void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && ammoAmount > 0)
        {
           
                ammoAmount -= 1;
                ammo[ammoAmount].gameObject.SetActive(false);
                m_shootingSound.Play();
            if (ammoAmount == 0)
                {
                m_looseSound.Play();
                end.gameObject.SetActive(true);
                crossheir.gameObject.SetActive(false);
                Cursor.visible = true;
                Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
            }
            

        }

    }

    
    
        
}
