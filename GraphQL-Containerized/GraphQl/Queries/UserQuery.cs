using GraphQL.Types;
using GraphQL_Containerized.Types;

namespace GraphQL_Containerized.Queries
{
    public class UserQuery : ObjectGraphType // no <object>
    {
        public UserQuery()
        {
            Name = "UserQuery";
            Field<UserType>("user").Description("Returns a single User").Resolve(
                context => returnNewUser()
                );
        }

        public User returnNewUser()
        {
            return new User
            {
                Id = "user-id",
                ExternalUserId = "external-id",
                FirstName = "first-name",
                LastName = "last-name",
                UserGroupIds = new List<string> { "usergroup-1", "usergroup-2" },
                Properties = new List<Property> { new Property { Name = "prop-1", Value = "val-1" },
                                                  new Property { Name = "prop-2", Value = "val-2" } }
            };
        }
    }
}
