namespace Nancy.Demo.SparkViewEngine.FifthElement
{
    public class FifthElementModule : NancyModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NancyModule"/> class.
        /// </summary>
        public FifthElementModule()
        {
            Get["/5"] = (x) =>
                {
                    return View["Fifth.spark"];
                };
        }
    }
}