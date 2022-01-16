using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class RomanNumeralsCalculator : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _responseText;

	[SerializeField]
	private TMP_InputField _inputField;


	/*
		Use this class for your assigment. 
		Roman numerals are as follow:

		I -> 1
		V -> 5
		X -> 10
		L -> 50
		C -> 100
		D -> 500
		M -> 1000

		For this example we'll use the simple conversion, where all numbers are
		translated straigt into their integer value (IIII -> 4) but feel free
		to add the correct conversion as an extra challenge (IV -> 4)

		Example input:

		MDLXX     ->    1570
		CCCLXVII  ->    367
	
	*/
	private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
	{
		{'I', 1},
		{'V', 5},
		{'X', 10},
		{'L', 50},
		{'C', 100},
		{'D', 500},
		{'M', 1000}
	};
	public void CalculateRomanNumerals()
	{
		string romanNumeral = _inputField.text;
		int response = RomanToArabic(romanNumeral);
		_responseText.text = $"{response}";
	}

	private int RomanToArabic(string romanNumber)
	{
		romanNumber.ToUpper();

		int arabicNumber = 0;
		//Your logic here
		for (int i = 0; i < romanNumber.Length; i++)
		{
			if (i + 1 < romanNumber.Length && RomanMap[romanNumber[i]] < RomanMap[romanNumber[i + 1]])
			{
				arabicNumber -= RomanMap[romanNumber[i]];
			}
			else
			{
				arabicNumber += RomanMap[romanNumber[i]];
			}
		}
		return arabicNumber;
	}

}
