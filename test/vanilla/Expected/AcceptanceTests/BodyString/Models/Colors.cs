// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsBodyString.Models
{
    using Fixtures.AcceptanceTestsBodyString;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Colors.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Colors
    {
        [EnumMember(Value = "red color")]
        Redcolor,
        [EnumMember(Value = "green-color")]
        GreenColor,
        [EnumMember(Value = "blue_color")]
        BlueColor
    }
    internal static class ColorsEnumExtension
    {
        internal static string ToSerializedValue(this Colors? value)
        {
            return value == null ? null : ((Colors)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Colors value)
        {
            switch( value )
            {
                case Colors.Redcolor:
                    return "red color";
                case Colors.GreenColor:
                    return "green-color";
                case Colors.BlueColor:
                    return "blue_color";
            }
            return null;
        }

        internal static Colors? ParseColors(this string value)
        {
            switch( value )
            {
                case "red color":
                    return Colors.Redcolor;
                case "green-color":
                    return Colors.GreenColor;
                case "blue_color":
                    return Colors.BlueColor;
            }
            return null;
        }
    }
}
