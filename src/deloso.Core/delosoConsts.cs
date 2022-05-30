using deloso.Debugging;

namespace deloso
{
    public class delosoConsts
    {
        public const string LocalizationSourceName = "deloso";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "798d648a92064043b4c07b510e06a1ab";
    }
}
