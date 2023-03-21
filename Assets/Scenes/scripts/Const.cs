using System.Collections.Generic;

public enum BioObjectType{
    BASE = 0,
    CONTAINER = 1,
}

class BioEnumUtils{
    private static List<string> all_type_str = new List<string>{
        "BASE","CONTAINER"
    };
    public static List<string> GetAllStr(){
        return all_type_str;
    }

    public static BioObjectType Str2Enum(string obj_type){
        switch(obj_type){
            case "BASE":
            return BioObjectType.BASE;
            case "CONTAINER":
            return BioObjectType.CONTAINER;
        }
        return BioObjectType.BASE;
    }
}


