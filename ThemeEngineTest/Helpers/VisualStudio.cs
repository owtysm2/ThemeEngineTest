namespace ThemeEngineTest.Helpers
{
    internal static class VisualStudio
    {
        public static bool DesignMode => IsInDesignMode();
        private static bool IsInDesignMode()
        {
            // otherwise we'd get a serialization error in the designer at random times
            string processName = System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToLower().Trim();
            return processName.Contains("devenv") || processName.Contains("designtoolsserver");
        }
    }
}
