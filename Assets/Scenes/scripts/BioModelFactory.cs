using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BioModelFactory{
    public static void AddBioModelComponent(BioObjectType bio_model_type, string name){
        Vector3 init_pos=new Vector3(0,0,0);
        Quaternion init_rotation=new Quaternion(0,0,0,0);
        GameObject parent_object=GameObject.FindWithTag("bio_ancestor");

        switch(bio_model_type){
            case BioObjectType.BASE:
            GameObject prefab = (GameObject)Resources.Load("Prefabs/BioModel");
            GameObject.Instantiate(prefab,init_pos,init_rotation,parent_object.transform);
            break;
        }
    }
}