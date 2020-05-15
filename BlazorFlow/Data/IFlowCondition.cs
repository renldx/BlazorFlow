namespace BlazorFlow.Data
{
    public interface IFlowCondition
    {
        public void SetUserValue(string userValue);

        public bool Evaluate();
    }
}
