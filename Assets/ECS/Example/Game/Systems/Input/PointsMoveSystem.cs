using ME.ECS;
using UnityEngine;

namespace ME.Example.Game.Systems {

    using ME.Example.Game.Modules;
    using ME.Example.Game.Components;
    using ME.Example.Game.Entities;

    public class PointsMoveSystem : ISystem<State>, ISystemAdvanceTick<State>, ISystemUpdate<State> {

        public Entity p1;
        public Entity p2;
        
        public IWorld<State> world { get; set; }
        private RPCId testEventCallId;
        private RPCId createUnitCallId;

        void ISystemBase.OnConstruct() {

            var network = this.world.GetModule<ME.ECS.Network.INetworkModuleBase>();
            this.testEventCallId = network.RegisterRPC(new System.Action<Entity, Color, float>(this.MovePointEvent_RPC).Method);
            network.RegisterObject(this, 2);

        }

        void ISystemBase.OnDeconstruct() {

            var network = this.world.GetModule<ME.ECS.Network.INetworkModuleBase>();
            network.UnRegisterObject(this, 2);
            network.UnRegisterRPC(this.testEventCallId);

        }

        void ISystemAdvanceTick<State>.AdvanceTick(State state, float deltaTime) {}

        void ISystemUpdate<State>.Update(State state, float deltaTime) {

            ME.Example.Game.Components.UI.UIMove marker;
            if (this.world.GetMarker(out marker) == true) {
                
                this.AddEventUIButtonClick(marker.pointId == 1 ? this.p1 : this.p2, marker.color, marker.moveSide);
                
            }

        }

        private void AddEventUIButtonClick(Entity point, Color color, float moveSide) {

            var networkModule = this.world.GetModule<NetworkModule>();
            networkModule.RPC(this, this.testEventCallId, point, color, moveSide);

        }

        private void MovePointEvent_RPC(Entity point, Color color, float moveSide) {

            var componentColor = this.world.AddComponent<Point, PointSetColor>(point);
            componentColor.color = color;

            var componentPos = this.world.AddComponent<Point, PointAddPositionDelta>(point);
            componentPos.positionDelta = Vector3.left * moveSide;

        }

    }

}