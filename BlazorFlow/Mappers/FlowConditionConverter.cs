using System;
using AutoMapper;
using BlazorFlow.Data;
using BlazorFlow.Helpers;

namespace BlazorFlow.Mappers
{
    public class FlowConditionConverter : ITypeConverter<FlowCondition, Models.FlowCondition>
    {
        public Models.FlowCondition Convert(FlowCondition source, Models.FlowCondition destination, ResolutionContext context)
        {
            var operation = EnumToOperation(source.FlowConditionOperator);
            var value = StringToIComparable(source.FlowConditionType, source.FlowConditionValue);

            return new Models.FlowCondition(operation, value) { FlowConditionId = source.FlowConditionId };
        }

        public Func<IComparable, IComparable, bool> EnumToOperation(FlowConditionOperator operation) => operation switch
        {
            FlowConditionOperator.LessThan => OperationHelper.LessThan<IComparable>(),
            FlowConditionOperator.LessThanOrEqualTo => OperationHelper.LessThanOrEqualTo<IComparable>(),
            FlowConditionOperator.EqualTo => OperationHelper.EqualTo<IComparable>(),
            FlowConditionOperator.GreaterThan => OperationHelper.GreaterThan<IComparable>(),
            FlowConditionOperator.GreaterThanOrEqualTo => OperationHelper.GreaterThanOrEqualTo<IComparable>(),
            _ => throw new Exception()
        };

        public IComparable StringToIComparable(FlowValueType valueType, string value) => valueType switch
        {
            FlowValueType.none => value,
            FlowValueType.radio => value,
            FlowValueType.select => value,
            FlowValueType.text => value,
            FlowValueType.textarea => value,
            FlowValueType.number => decimal.Parse(value),
            FlowValueType.datetime => DateTime.Parse(value),
            FlowValueType.checkbox => value, // TO FIX
            _ => throw new Exception()
        };
    }
}
