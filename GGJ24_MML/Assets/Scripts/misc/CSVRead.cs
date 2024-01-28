using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;

public class CSVRead : MonoBehaviour
{
    // Lists to hold data for each column
    public List<string> column1 = new List<string>();
    public List<string> column2 = new List<string>();
    public List<string> column3 = new List<string>();
    public List<string> column4 = new List<string>();

    void Start()
    {
        string filePath = Path.Combine(Application.dataPath, "JokeData/Jokes.csv");
        string[] data = File.ReadAllLines(filePath);

        foreach (string line in data)
        {
            // Regex to split on comma that is not within quotes
            string pattern = ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";
            string[] fields = Regex.Split(line, pattern);

            // Assuming the CSV file has at least four columns
            if (fields.Length >= 4)
            {
                column1.Add(fields[0].Trim('"'));
                column2.Add(fields[1].Trim('"'));
                column3.Add(fields[2].Trim('"'));
                column4.Add(fields[3].Trim('"'));
            }
        }

        // Example to show how to use the data
        Debug.Log("First entry in Column 1: " + column1[0]);
        Debug.Log("First entry in Column 2: " + column2[0]);
        Debug.Log("First entry in Column 3: " + column3[0]);
        Debug.Log("First entry in Column 4: " + column4[0]);
    }
}
