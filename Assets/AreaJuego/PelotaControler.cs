using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PelotaControler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float force;
    [SerializeField] GameManager manager;
    [SerializeField]const float MAX_Y = 2.5f;
    [SerializeField] const float MIN_Y = -2.5f;
    [SerializeField] float delay;
    [SerializeField] AudioClip sfxPelota;
    [SerializeField] AudioClip sfxPorteria;

    const float MIN_ANG = 20.0f;
    const float MAX_ANG = 40.0f;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector2(1, 1) * force, ForceMode2D.Impulse);
        int direccionX= UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        StartCoroutine(LanzarPelota(direccionX));
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        string tag = other.gameObject.tag;
        if (tag == "Pala1" || tag == "Pala2")
        {
            AudioSource.PlayClipAtPoint(sfxPelota, Camera.main.transform.position);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Gol en "+other.tag+"!!");

        if (other.tag == "Porteria2")
        {
            manager.addPointP1();
            AudioSource.PlayClipAtPoint(sfxPorteria, Camera.main.transform.position);
            StartCoroutine(LanzarPelota(1));
        }else if (other.tag == "Porteria1")
        {
            manager.addPointP2();
            AudioSource.PlayClipAtPoint(sfxPorteria, Camera.main.transform.position);
            StartCoroutine(LanzarPelota(-1));
        }
    }

    IEnumerator LanzarPelota(int direccionX)
    {
        yield return new WaitForSeconds(delay);
        // calculo la posicion vertical de lanzamiento

        float posY = UnityEngine.Random.Range(MIN_Y, MAX_Y);
        transform.position=new Vector3(0, posY, 0);

        // calculo del vector de lanzamiento

        float angulo = UnityEngine.Random.Range(MIN_ANG, MAX_ANG)* Mathf.Deg2Rad;
        float x = Mathf.Cos(angulo) * direccionX;
        int direccionY = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Mathf.Sin(angulo) * direccionY;
        Vector2 impulso = new Vector2(x, y);

        // Reseteamos la velocidad lineal de la pelota
        rb.velocity = Vector2.zero; // es igual que poner rb.velocity=new Vector2(0,0);

        // Aplicamos el impulso

        rb.AddForce(impulso * force, ForceMode2D.Impulse);
     }
}
