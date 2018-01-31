using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ParthenonBuilder : MonoBehaviour {

    public GameObject cubePrefab;
    public GameObject cylinderPrefab;
    

    public float floorWidth = 5.0f;
    public float floorDepth = 10f;
    public float floorHeight = 0.25f;
    public float pillarRadius = 0.2f;
    public float pillarHeight = 2f;
    public float pillarCountWidth = 6f;
    public float pilllarCounterDepth = 10f;
    public float roofHeight = 1f;


    [ContextMenu("Build")]
    void Build()
    {
        var floor1 = Instantiate(cubePrefab, transform);
        floor1.transform.localPosition = new Vector3(0, 0, 0);
        floor1.transform.localScale = new Vector3(floorWidth, floorHeight, floorDepth);

        var floor2 = Instantiate(cubePrefab, transform);
        floor2.transform.localPosition = new Vector3(0, floorHeight, 0);
        floor2.transform.localScale = new Vector3(floorWidth * 0.9f, floorHeight, floorDepth * 0.9f);

        var floor3 = Instantiate(cubePrefab, transform);
        floor3.transform.localPosition = new Vector3(0, floorHeight * 2, 0);
        floor3.transform.localScale = new Vector3(floorWidth * 0.81f, floorHeight, floorDepth * 0.81f);

        var pillar1 = Instantiate(cylinderPrefab, transform);
        pillar1.transform.localPosition = new Vector3(floorWidth*-0.5f, floorHeight*10f, floorDepth*-0.5f);
        pillar1.transform.localScale = new Vector3(pillarRadius, pillarHeight,pillarRadius);//0.2 만큼 들어가는 것을 수식으로 계산하기

        //var pillar2 = Instantiate(cylinderPrefab, transform);






    }

    




    [ContextMenu("Destroy All")]
    void DestroyAllChildren()
    {
        foreach (Transform t in transform.Cast<Transform>().ToArray())
        {
            DestroyImmediate(t.gameObject);
        }
    }
    

}

