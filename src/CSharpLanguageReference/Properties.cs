using System;
using System.Collections.Generic;

namespace CSharpLanguageReference
{
    public class Properties
    {
        // Basic syntaxes
        public int Property1 { get; set; }
        public MyType Property2 { get; set; }
        public MyType.MySubType Property3 { get; set; }
        public List<string> Property4 { get; set; }
        public string[] Property5 { get; set; }
        public object Property6 { get; set; }
        public ISomething Property7 { get; set; }
        public MyType.MyGenericType<int> Property8 { get; set; }

        // nullables
        public int? Property11 { get; set; }
        public MyType.MySubStruct? Property12 { get; set; }
        public Nullable<int> Property13 { get; set; }
        public Nullable<MyType.MySubStruct> Property14 { get; set; }
        public object? Property15 { get; set; }
        public ISomething? Property16 { get; set; }
        public Nullable<object> Property17 { get; set; }
        public Nullable<ISomething> Property18 { get; set; }
        public Nullable<MyType.MyGenericType<int>> Property19 { get; set; }


        // Generic variations
        public List<Nullable<int>> Property21 { get; set; }
        public List<MyType> Property22 { get; set; }
        public List<MyType.MySubType> Property23 { get; set; }
        public List<int?> Property24 { get; set; }
        public List<string[]> Property25 { get; set; }
        public List<object> Property26 { get; set; }
        public List<ISomething> Property27 { get; set; }
        public List<List<string>> Property28 { get; set; }
        public List<MyType.MyGenericType<int>> Property29 { get; set; }
    }
}
