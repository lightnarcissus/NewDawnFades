using UnityEngine;
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class ReadText : MonoBehaviour
{
    //StreamReader sr = new StreamReader("Assets/Music/music.txt");
    //StreamReader fq = new StreamReader("Assets/Music/freq.txt");
    public static string str;
    public static float num;
    public static float freqNum;
    public GameObject renderQuad;
    public static float timer = 280f;
    public GameObject text;
    public static bool close = false;
    public GameObject dirLight;
    public TextAsset music;

    public GameObject endScreen;
    public TextAsset freq;
  //  private string pathName = "/Users/Ansh/Desktop/music.txt";
   // private string freqPathName = "/Users/Ansh/Desktop/freq.txt";
    private int musicCount = 0;
    private int freqCount = 0;
    public GameObject model;
    public GameObject sprite;
    private string[] musicString;
    private string[] freqStrings;

    private string freqString;

    private StreamWriter fw;
    private StreamWriter sw;

    private float countTimer = 0f;
    public AudioSource audioSource;
    private float okTimer = 0f;
    public static bool allow = true;
    private bool once=true;
    // Use this for initialization
    void Start()
    {
        endScreen.SetActive(false);
      //  audioSource.time = timer;
        renderQuad.SetActive(false);
        musicString = music.text.Split("\n"[0]);
        freqStrings = freq.text.Split("\n"[0]);
        model.SetActive(false);
        sprite.SetActive(false);
        //str = sr.ReadLine ();
        //str = sr.();
        //sr.Close();    
    }

    void FixedUpdate()
    {
        if(freqNum > 0.8f && allow)
        {
            model.SetActive(false);
            sprite.SetActive(true);
        }
        else
        {
            if(allow)
            { 
            model.SetActive(true);
            sprite.SetActive(false);
            }
            else
            {
                if(once)
                { 
                StartCoroutine("SwitchBoth");
                    once = false;
                }

            }
        }
        if(freqCount <14179)
        { 
           float.TryParse(freqStrings[freqCount], out freqNum);
         float.TryParse(musicString[musicCount], out num);
         freqCount++;
        musicCount++;
        }
        /*
        sw = new StreamWriter(pathName,true);
        fw = new StreamWriter(freqPathName,true);
        
        sw.WriteLine(num);
        fw.WriteLine(freqNum);
        sw.Close();
        fw.Close();
        */
        // sr = new StreamReader(pathName);
        //fq = new StreamReader(freqPathName);
        //str = sr.ReadLine();
        // freqString = fq.ReadLine();
        //sr.Close();
        //fq.Close();
    }
    // Update is called once per frame
    void Update()
    {

      //  countTimer += Time.deltaTime;
        //   okTimer += Time.deltaTime;
      
        timer += Time.deltaTime;
       
        if (timer > 10f && !close)
        {
            model.SetActive(true);
            renderQuad.SetActive(true);
            text.SetActive(false);
        }
        if (timer > 280f)
        {
            close = true;
            allow = false;
            dirLight.GetComponent<Light>().color = Color.white;

            dirLight.GetComponent<Light>().intensity = 1f;
        }
        if (timer > 290f)
        {
            StartCoroutine("ThankYou");
        }
    }

    IEnumerator ThankYou()
    {
        endScreen.SetActive(true);
        yield return null;
    }

    IEnumerator SwitchBoth()
    {
        Debug.Log("hi");
        model.SetActive(true);
        sprite.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        model.SetActive(false);
        sprite.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        model.SetActive(true);
        sprite.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        model.SetActive(false);
        sprite.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        model.SetActive(true);
        sprite.SetActive(true);
        yield return null;
    }
}