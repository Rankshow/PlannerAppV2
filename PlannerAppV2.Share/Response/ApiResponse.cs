namespace PlannerAppV2.Shared.Response
{
    public class ApiResponse
    {
        public string Message { get; set; } = string.Empty;
        public bool IsSuccuss { get; set; } 
    }
    public class ApiResponse<T> : ApiResponse
    {
        public T? Value { get; set; }
    }
}
