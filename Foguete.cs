using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foguete : MonoBehaviour
{
    public ParticleSystem particle;
    public AudioSource som;
    bool decolar;
    bool pousar;
    public float time;

    void Update()
    {
        if (decolar & time <= 3)
        {
            time += Time.deltaTime;
            transform.Translate(0, 0, 3 * Time.deltaTime);
            particle.transform.Translate(0, 3 * Time.deltaTime, 0);
        }
        else if(pousar == false & time >= 3)
        {
            som.Stop();
        }
        else if (pousar & time > 0)
        {
            time -= Time.deltaTime;
            transform.Translate(0, 0, -3 * Time.deltaTime);
            particle.transform.Translate(0, -3 * Time.deltaTime, 0);
        }
        else if (decolar == false & time <= 0)
        {
            som.Stop();
        }
    }
    public void Decolar()
    {
        decolar = true;
        pousar = false;

        if (!som.isPlaying)
        {
            som.Play();
        }
    }
    public void Pousar()
    {
        pousar = true;
        decolar = false;

        if (!som.isPlaying)
        {
            som.Play();
        }
    }
}
