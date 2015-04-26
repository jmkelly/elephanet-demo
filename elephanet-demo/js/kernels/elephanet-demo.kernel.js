Kernel.extend(Kernel, {
    onRegister: function (instance) {
        //check if module exists
        var availableModules = this._internals.modules;
        var loadingModule = instance._internals.moduleType;
        if (!(loadingModule in availableModules)) {
            //throw a useful error if the module name does not match any loaded modules
            var keys = [];
            for (var key in availableModules) {
                keys.push(key);
            }
            throw new Error("Module " + loadingModule + " not found. Available options are " + JSON.stringify(keys));
        }
    },

    onStart: function (instance) {
        instance.init();
    },

    onStop: function (instance) {
        instance.kill();
    }
});