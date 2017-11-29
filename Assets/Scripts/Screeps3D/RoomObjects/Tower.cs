﻿using UnityEngine;

namespace Screeps3D {
    
    /*{
        "_id":"5945134eea485cae18c518ef",
        "type":"tower",
        "x":7,
        "y":24,
        "room":"W8S12",
        "notifyWhenAttacked":true,
        "user":"567d9401f60a26fc4c41bd38",
        "energy":990,
        "energyCapacity":1000,
        "hits":3000,
        "hitsMax":3000,
        "actionLog":{
            "attack":null,
            "heal":null,
            "repair":null
        }
    }*/
    
    public class Tower : Structure, IEnergyObject {
        public float Energy { get; private set; }
        public float EnergyCapacity { get; private set; }

        internal override void Unpack(JSONObject data) {
            base.Unpack(data);
            var energyObj = data["energy"];
            if (energyObj != null) {
                Energy = energyObj.n;
            }

            var energyCapacityObj = data["energyCapacity"];
            if (energyCapacityObj) {
                EnergyCapacity = energyCapacityObj.n;
            }
        }
    }
}