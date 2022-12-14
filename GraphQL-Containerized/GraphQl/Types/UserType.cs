using GraphQL.Types;
using GraphQL_Containerized.GraphQl.Types;

namespace GraphQL_Containerized.Types
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType() : base()
        {
            Field(x => x.Id);
            Field(x => x.ExternalUserId);
            Field(x => x.FirstName);
            Field(x => x.LastName);
            Field(x => x.Email);
            Field(x => x.HomeOrganizationId);
            Field(x => x.UserGroupIds);
            Field(x => x.LastLoggedIn);
            Field(x => x.Created);
            Field(x => x.Modified);
            Field<ListGraphType<PropertyType>>("properties");
        }
    }
}
