using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TestDictionary : MonoBehaviour
{
    private delegate int Sorter(KeyValuePair<string, int> pair);
    
    private void Awake()
    {
        var dict = new Dictionary<string, int>()
        {
            { "four", 4 },
            { "two", 2 },
            { "one", 1 },
            { "three", 3 }
        };

        var sorted = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });
        var sorted1 = dict.OrderBy(pair => pair.Value);
        var sorted2 = dict.OrderBy(Sort);
        var sorted3 = dict.OrderBy(pair => { return pair.Value; });

        Sorter sorter = Sort;
        var sorted4 = dict.OrderBy(pair => sorter(pair));

        Print(sorted);
        Print(sorted1);
        Print(sorted2);
        Print(sorted3);
        Print(sorted4);
    }

    private static void Print(IEnumerable<KeyValuePair<string, int>> collection)
    {
        foreach (var pair in collection)
        {
            Debug.Log($"{pair.Key} - {pair.Value}");
        }
    }

    private static int Sort(KeyValuePair<string, int> pair)
    {
        return pair.Value;
    }

}

