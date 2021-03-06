﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRPC.Service.Regestry {

    public class DefaultModulesRegestry : IModulesRegestry {

        private readonly List<JRpcModule> modules = new List<JRpcModule>();

        public Dictionary<string, JRpcModule> GetAllServices() {
            return modules.ToDictionary(t => t.ModuleName, t => t);
        }

        public void AddJRpcModule(JRpcModule module) {
            modules.Add(module);
        }
    }
}
