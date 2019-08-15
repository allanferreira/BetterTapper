using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawn : MonoBehaviour
{

    public List<GameObject> customers;

    IEnumerator Start()
    {

        yield return StartCoroutine(CreateACustomer());

    }

    IEnumerator CreateACustomer()
    {
        while (true)
        {
            yield return new WaitForSeconds(5.0f);
            GameObject randomCustomer = customers[Random.Range(0, customers.Count)];
            Instantiate(randomCustomer, new Vector3(0, 0), Quaternion.identity);
        }
    }
}
