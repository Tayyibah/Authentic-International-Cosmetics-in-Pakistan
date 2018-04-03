using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using  Entities.DBEntities;

namespace  UI.Common
{
    public static class GlobalDataManager
    {
        #region Private Data

        private static String FORMCATEGORIESLIST_KEY = "FormCategoriesData";

        #endregion
        public static String PageTitlePrefix = String.Empty;
        public static Boolean IsCSEncrypted = false;
        public static String BuildVersion = "";
        public static Boolean EnableOptimization = false;

        public static String BasePath = VirtualPathUtility.ToAbsolute("~");




        //public static List<FormCategories> FormCategoriesList
        //{
        //    get
        //    {
        //        if (ApplicationState[FORMCATEGORIESLIST_KEY] != null)
        //            return ApplicationState[FORMCATEGORIESLIST_KEY] as List<FormCategories>;
        //        else
        //            return new List<FormCategories>();
        //    }
        //    set
        //    {
        //        ApplicationState[FORMCATEGORIESLIST_KEY] = value;
        //    }
        //}

        //public static List<Messages> MessagesList
        //{
        //    get
        //    {
        //        if (ApplicationState[NOTIFICATIONMESSAGES] != null)
        //            return ApplicationState[NOTIFICATIONMESSAGES] as List<Messages>;
        //        else
        //            return new List<Messages>();
        //    }
        //    set
        //    {
        //        ApplicationState[NOTIFICATIONMESSAGES] = value;
        //    }
        //}




        private static HttpApplicationState ApplicationState
        {
            get
            {
                return System.Web.HttpContext.Current.Application;
            }
        }
    }
}