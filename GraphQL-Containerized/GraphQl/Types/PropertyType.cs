using GraphQL.Types;

namespace GraphQL_Containerized.GraphQl.Types
{
    public class PropertyType : ObjectGraphType<Property>
    {
        public PropertyType()
        {
            Field(x => x.Name);
            Field(x => x.Value);
        }
    }
}
