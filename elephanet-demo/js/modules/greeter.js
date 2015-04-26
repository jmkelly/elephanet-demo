Kernel.module.define('greeter', {
    renderTo: "#greeter",

    init: function () {
        var self = this;
        console.log(self);
        self.template = Handlebars[self._internals.moduleType];
        var data = {};
        data.name = "James Kelly"
        self.render(data);
    },

    render: function (data) {
        var self = this;
        console.log(data);
        console.log(self.template(data));
        $(self.renderTo).html(self.template(data));
    }
});
