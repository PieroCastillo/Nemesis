using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemesis
{
    public static class LanguageHelper
    {
        static AvailableLanguages Language
        {
            get
            {
                var cu = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                if (cu.Contains("es"))
                {
                    return AvailableLanguages.Spanish;
                }
                else if (cu.Contains("en"))
                {
                    return AvailableLanguages.English;
                }
                else
                {
                    return AvailableLanguages.English;
                }
            }
        }

        public static string GetWelcome()
        {
            switch (Language)
            {
                case AvailableLanguages.English: return "Welcome";
                case AvailableLanguages.Spanish: return "Bienvenido";
                default: return "Welcome";
            }
        }

        public static string GetWhatDoYouWantToDoText()
        {
            switch (Language)
            {
                case AvailableLanguages.English: return "What do you want to do?";
                case AvailableLanguages.Spanish: return "¿Qué desea hacer?";
                default: return "What do you want to do?";
            }
        }

        public static string GetOpenRecent()
        {
            switch (Language)
            {
                case AvailableLanguages.English: return "Open recent Sequence";
                case AvailableLanguages.Spanish: return "Abrir Secuencia reciente";
                default: return "Open recent Sequence";
            }
        }

        public static string GetCreateNew()
        {
            switch (Language)
            {
                case AvailableLanguages.English: return "Create new Sequence";
                case AvailableLanguages.Spanish: return "Crear nueva Secuencia";
                default: return "Create new Sequence";
            }
        }

    }

    enum AvailableLanguages
    {
        Spanish, English
    }
}
