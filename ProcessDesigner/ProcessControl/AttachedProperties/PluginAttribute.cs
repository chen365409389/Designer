﻿using System;

namespace ProcessControl
{
    public class PluginAttribute : Attribute
    {
        public string ImageUrl
        {
            get;
            set;
        }

        public string DataTemplatePath
        {
            get;
            set;
        }

        public PluginAttribute()
        {
        }
    }
}
