using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordGen : MonoBehaviour
{
    public TMP_Text word;
    public string[] lines;
    // Start is called before the first frame update
    void Start()
    {
        lines = System.IO.File.ReadAllLines(@"Assets/text.txt");
        Debug.Log(lines.Length);
        InvokeRepeating(nameof(UpdateText), 0, 4.0f);
    }

    // Update is called once per frame
    void UpdateText()
    {
        Debug.Log(lines.Length);
        int rnd = Random.Range(0, 103796);
        Debug.Log(lines[rnd]);
        this.word.text = lines[rnd];
    }
}
