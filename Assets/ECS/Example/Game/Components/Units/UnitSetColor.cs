using ME.ECS;

namespace ME.Example.Game.Components {

    using ME.Example.Game.Entities;

    public class UnitSetColor : IRunnableComponentOnce<State, Unit> {

        public UnityEngine.Color color;

        public void AdvanceTick(State state, ref Unit data, float deltaTime, int index) {

            data.color = this.color;

        }

        void IPoolableRecycle.OnRecycle() {}

        void IComponentCopyable<State, Unit>.CopyFrom(IComponent<State, Unit> other) {

            this.color = ((UnitSetColor)other).color;

        }

    }

}