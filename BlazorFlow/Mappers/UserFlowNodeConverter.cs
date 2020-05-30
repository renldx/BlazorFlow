using AutoMapper;

namespace BlazorFlow.Mappers
{
    public class UserFlowNodeConverter : ITypeConverter<Models.UserFlowNode, Data.UserFlowNode>
    {
        public Data.UserFlowNode Convert(Models.UserFlowNode source, Data.UserFlowNode destination, ResolutionContext context)
        {
            return new Data.UserFlowNode();
        }
    }
}
