using System;
using System.Threading.Tasks;

namespace StepStateMachine
{
    public enum State
    {
        Deraft = 1,
        Done = 2,
        Error = 3
    }

    public interface IRule
    {
        Task<TEntity> Run<TEntity>(TEntity entity) where TEntity : class, IStatebleEntity;
        Task<TEntity> Reverse<TEntity>(TEntity entity) where TEntity : class, IStatebleEntity;
    }

    public interface IStatebleEntity
    {
        public State State { get; set; }
    }

    public abstract class StepStateMachine<TEntity>
        where TEntity : class, IStatebleEntity
    {

    }
}
