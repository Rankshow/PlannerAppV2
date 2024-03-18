namespace PlannerAppV2.Shared.Response
{
    public class ApierrorResponse
    {
        public string Message { get; set;} = string.Empty;
        public string[]? Errors { get; set; } 
        public bool IsSuccuss { get; set;}
    }
}
