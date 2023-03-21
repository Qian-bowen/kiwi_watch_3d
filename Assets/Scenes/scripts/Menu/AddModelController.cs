using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class AddModelController : MonoBehaviour
{
    private Button add_model_button;
    private InputField model_name_input;
    private Dropdown type_dropdown;
    // Start is called before the first frame update
    void Start()
    {
        add_model_button=GameObject.FindWithTag("add_model_button").GetComponent<Button>();
        model_name_input=GameObject.FindWithTag("model_name_input").GetComponent<InputField>();
        type_dropdown=GameObject.FindWithTag("type_dropdown").GetComponent<Dropdown>();
        type_dropdown.ClearOptions();
        type_dropdown.AddOptions(BioEnumUtils.GetAllStr());
        add_model_button.onClick.AddListener(OnStartButtonClick);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnStartButtonClick()
    {
        string select_type_str = type_dropdown.options[type_dropdown.value].text;
        string model_name = model_name_input.text;
        BioObjectType obj_type = BioEnumUtils.Str2Enum(select_type_str);
        Debug.Log("select:"+select_type_str+" model name:"+model_name);
        BioModelFactory.AddBioModelComponent(obj_type,model_name);
    }
}
