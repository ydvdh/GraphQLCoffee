using GraphQL.Utilities;
using GraphQLCoffee.Mutation;
using GraphQLCoffee.Query;
using System;

namespace GraphQLCoffee.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider): base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
