using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Reflection;

namespace CoursesAndroid
{
    public static class ResourceHelper
    {
        public static int TranslateDrawable(String drawableName)
        {
            Type drawableType = typeof(Resource.Drawable);
            FieldInfo resourceFieldInfo = drawableType.GetField(drawableName);
            return (int)resourceFieldInfo.GetValue(null);
        }
    }
}