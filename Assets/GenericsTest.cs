using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    GenericContainer<float> FloatContainer = new();
    GenericContainer<int> IntContainer = new();
    GenericContainer<MonoBehaviour> MonoBehaviourContainer = new();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; ++i)
        {
            FloatContainer.Add(Random.Range(0f, 1f));
            IntContainer.Add(Random.Range(0, 10));
        }

        MonoBehaviourContainer.Add(this);

        //IntContainer.Add(1.234f);

        //foreach(var Element in FloatContainer)
        //    Debug.Log($"{nameof(FloatContainer)}: {Element}");
        //foreach (var Element in IntContainer)
        //    Debug.Log($"{nameof(IntContainer)}: {Element}");
        //foreach (var Element in MonoBehaviourContainer)
        //    Debug.Log($"{nameof(MonoBehaviourContainer)}: {Element}");

        PrintContainer(FloatContainer, nameof(FloatContainer));
        PrintContainer(IntContainer, nameof(IntContainer));
        PrintContainer(MonoBehaviourContainer, nameof(MonoBehaviourContainer));
    }

    void PrintContainer<ContainerType>(ContainerType container, string containerName) where ContainerType : IEnumerable
    {
        foreach (var Element in container)
            Debug.Log($"{containerName}: {Element}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
