namespace DocordoAPI.Model.Exc
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DocordoLoginException : Exception
    {
        private DocordoLoginException() : base("DocordoLoginException") { }
        public static DocordoLoginException New()
        {
            return new DocordoLoginException();
        }
    }
}
