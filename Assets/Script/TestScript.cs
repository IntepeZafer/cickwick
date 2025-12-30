using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public void myFunction1()

    {
        int number = 5;
        float decimalNumber = 3.14f;
        string message = "Hello, Unity!";
        bool isActive = true;

        void TestFunction()
        {
            Debug.Log("Integer: " + number);
            Debug.Log("Float: " + decimalNumber);
            Debug.Log("String: " + message);
            Debug.Log("Boolean: " + isActive);
        }
        int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
    public void myFunction2()
    {
        void Awake() // Awake Fonksiyonu, oyun nesnesi etkinleştirildiğinde çağrılır.
        {
            
        }
        void Start() // Start Fonksiyonu, oyun nesnesi ilk kez etkinleştirildiğinde çağrılır.
        {
            
        }
        void Update() // Update Fonksiyonu, her karede bir kez çağrılır.
        {
            
        }
        void FixedUpdate() // FixedUpdate Fonksiyonu, fizik hesaplamaları için sabit zaman aralıklarında çağrılır.
        {
            
        }
        void LateUpdate() // LateUpdate Fonksiyonu, tüm Update fonksiyonları çalıştıktan sonra çağrılır.
        {
            
        }
    }
    public void myFunction3()
    {
        Debug.Log("This is a debug message."); // Konsola bilgi mesajı yazdırır.
        Debug.LogWarning("This is a warning message."); // Konsola uyarı mesajı yazdırır.
        Debug.LogError("This is an error message."); // Konsola hata mesajı yazdırır.
        Debug.LogFormat("Formatted message: {0}, {1}", "Hello", 123); // Formatlı mesaj yazdırır.
        Debug.Assert(1 + 1 == 2, "Math is broken!"); // Koşul yanlışsa hata mesajı gösterir.
        // Debug.ClearDeveloperConsole(); // Konsolu temizler.
    }
    public void myFunction4()
    {
        int S1 = 10;
        int S2 = 20;
        if(S1 % 2 == 0 && S2 % 2 == 0)
        {
            Debug.Log($"{S1} ve {S2} çift sayılardır.");
        }
        else
        {
            Debug.Log($"{S1} ve {S2} çift sayılar değildir.");
        }
        switch(S1 % 2 == 0 && S2 % 2 == 0)
        {
            case true:
                Debug.Log($"{S1} ve {S2} çift sayılardır.");
                break;
            case false:
                Debug.Log($"{S1} ve {S2} çift sayılar değildir.");
                break;
        }
    }
    public void myFunction5()
    {
        int i = 0;
        for(i = 0; i < 10; i++)
        {
            Debug.Log("For Döngüsü İterasyonu: " + i);
        }
        while(i < 10)
        {
            Debug.Log("While Döngüsü İterasyonu: " + i);
            i++;
        }
        do
        {
            Debug.Log("Do-While Döngüsü İterasyonu: " + i);
            i++;
        } while(i < 10);

        foreach(char c in "Unity")
        {
            Debug.Log("Foreach Döngüsü Karakteri: " + c);
        }
    }
    public void myFunction6()
    {
        string[] myArray = new string[4] { "Unity", "C#", "Scripting" , "Test" };
        string[] myArray2 = { "Hello", "World", "from", "Unity" };
        int[] myArray3 = new int[5];
        foreach(string str in myArray)
        {
            Debug.Log("Array Elemanı: " + str);
        }
        for(int i =0; i < myArray2.Length; i++)
        {
            Debug.Log("Array2 Elemanı: " + myArray2[i]);
        }
        while(myArray.Length > 0)
        {
            Debug.Log("Array Uzunluğu: " + myArray.Length);
            break;
        }
        List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };
        myList.Add(6);
        myList.Remove(3);
        for(int i = 0; i < myList.Count; i++)
        {
            Debug.Log("List Elemanı: " + myList[i]);
        }
    }
}
