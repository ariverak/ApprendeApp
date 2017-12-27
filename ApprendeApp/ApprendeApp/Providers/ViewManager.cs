using ApprendeApp.Views;
using System;

namespace ApprendeApp.Providers
{
    public static class ViewManager
    {
        public static Type GetViewType(string viewName) {
            switch (viewName)
            {
                case "ContentEvaluation":
                    return typeof(ContentEvaluation);
                default:
                    return typeof(ContentEvaluation);
            }
        }
    }
}
