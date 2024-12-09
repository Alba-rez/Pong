using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    int p1Score;

    int p2Score;

    bool running = false;

    [SerializeField] Text txtScoreP1;

    [SerializeField] Text txtScoreP2;
    
    [SerializeField] GameObject pelota;
    public void addPointP1() { p1Score++; }
    public void addPointP2() { p2Score++; }

    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        
            Application.Quit();
        
        if (!running && Input.GetKeyDown(KeyCode.Space))
        {
            pelota.SetActive(true);
            running = true;

        }
        // Debug.Log("p1 = " + p1Score + " p2= " + p2Score);
    }
   void OnGUI()
    {
        txtScoreP1.text = p1Score.ToString();
        txtScoreP2.text = p2Score.ToString();
    }
}
