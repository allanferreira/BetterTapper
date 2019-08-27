using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawn : MonoBehaviour
{

    public List<GameObject> customers;
    public ListIntegerScriptable ordersPerTable;

    IEnumerator Start()
    {

        yield return StartCoroutine(CreateACustomer());

    }

    IEnumerator CreateACustomer()
    {
        while (hasTableAvailable())
        {
            //yield return new WaitForSeconds(5.0f);
            yield return new WaitForSeconds(1f);
            GameObject randomCustomer = customers[Random.Range(0, customers.Count)];
            Instantiate(randomCustomer, new Vector3(0, 0), Quaternion.identity);
        }
    }

    bool hasTableAvailable()
    {
        bool hasTable = false;
        foreach(int order in ordersPerTable.value)
        {
            if(!hasTable) hasTable = order == 0;
        }
        return hasTable;
    }

}
