using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmusic : MonoBehaviour
{
    private AudioSource muzikKaynagi;

    private void Start()
    {
      muzikKaynagi = GetComponent<AudioSource>();
        muzikKaynagi.loop = true;
        muzikKaynagi.Play();
    }
}
