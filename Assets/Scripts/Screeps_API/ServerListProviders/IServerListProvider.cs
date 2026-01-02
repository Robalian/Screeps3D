using Screeps_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Screeps_API.ServerListProviders
{
    interface IServerListProvider
    {
        void Load(Action<IEnumerable<IScreepsServer>> callback);
    }
}
