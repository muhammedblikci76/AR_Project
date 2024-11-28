using System;
using UnityEngine;
using UnityEngine.UI; // Eğer UI Text kullanacaksanız gerekli

public class CalendarManager : MonoBehaviour
{
    public Text resultText; // Sonuç göstereceğimiz UI Text

    public void CalculateDay(int daysToAdd)
    {
        // Bugünün tarihi
        DateTime today = DateTime.Now;

        // İleriye gün ekleme
        DateTime futureDate = today.AddDays(daysToAdd);

        // Haftanın gününü al
        string futureDay = futureDate.ToString("dddd"); // Örneğin: "Monday"

        // Sonucu göster
        resultText.text = $"{daysToAdd} gün sonra: {futureDay}";
    }
}
