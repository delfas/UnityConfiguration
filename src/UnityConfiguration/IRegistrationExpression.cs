namespace UnityConfiguration
{
    public interface IRegistrationExpression : ILifetimePolicyExpression
    {
        /// <summary>
        /// Specify arguments that will be passed to the constructor when constructing the type.
        /// If some of the parameters should be resolved from the container, specify its type.
        /// </summary>
        /// <param name="args">Value or type of the parameters.</param>
        /// <example>
        /// WithConstructorArguments(42, "some string", typeof(IBar));
        /// </example>
        ILifetimePolicyExpression WithConstructorArguments(params object[] args);
    }
    
    public interface INamedRegistrationExpression : IRegistrationExpression
    {
        /// <summary>
        /// Specify a name for this registration mapping.
        /// </summary>
        /// <param name="name">The name for this registration mapping.</param>
        IRegistrationExpression WithName(string name);
    }
}