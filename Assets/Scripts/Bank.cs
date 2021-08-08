using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    [SerializeField] private int income;
    [SerializeField] private int cost;
    [SerializeField] private float rate = 1;
    private bool exists = true;
    private void Start()
    {
        FindObjectOfType<CurrencyManager>().AddReward(-cost);
        StartCoroutine(EarnIncome());
    }

    private IEnumerator EarnIncome()
    {
        //initial delay
        while (exists)
        {
            yield return new WaitForSeconds(rate);
            var _currencyManager = FindObjectOfType<CurrencyManager>();
            _currencyManager.AddReward(income);
        }
        
    }
    
}
