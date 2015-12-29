using Blobs.Enums;

namespace Blobs.Interfaces
{
    public interface IBehavior
    {
        BehaviorType BehaviorType { get; }

        void TriggerBehavior();
    }
}