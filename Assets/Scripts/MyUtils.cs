public static class MyUtils {

    /**
     * Source: https://stackoverflow.com/a/1415187
     */
    public static string GetEnumDescription(this Enum value) {
        Type type = value.GetType();
        string name = Enum.GetName(type, value);
        if (name != null) {
            FieldInfo field = type.GetField(name);
            if (field != null) {
                DescriptionAttribute attr = 
                    Attribute.GetCustomAttribute(field, 
                        typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attr != null) {
                    return attr.Description;
                }
            }
        }
        return null;
    }
}