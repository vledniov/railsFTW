﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace railsFTW
{
    class Globals
    {
        private static String  PROJECT_DIR = "";
        private static Boolean RSPEC;
        private static Boolean CAPYBARA;
        private static List<String> MODELS = new List<String>();
        private static List<String> CONTROLLERS = new List<String>();

        public static void setDirectory(String dir)
        {
            PROJECT_DIR = dir;
        }

        public static String getDirectory()
        {
            return PROJECT_DIR;
        }

        public static void setRspec(Boolean val)
        {
            RSPEC = val;
        }

        public static Boolean getRspec()
        {
            return RSPEC;
        }

        public static void setCapybara(Boolean val)
        {
            CAPYBARA = val;
        }

        public static Boolean getCapybara()
        {
            return CAPYBARA;
        }

        public static void addModel(String name, String attribute, String type)
        {
            if (name.Length == 0) { return; };
            MODELS.Add(name + " " + attribute + ":" + type);
        }

        public static void addController(String name)
        {
            if (name.Length == 0) { return; };
            CONTROLLERS.Add(name);
        }

        public static String[] getModels()
        {
            return MODELS.ToArray();
        }

        public static String[] getControllers()
        {
            return CONTROLLERS.ToArray();
        }
    }
}

