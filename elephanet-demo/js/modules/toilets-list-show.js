Kernel.module.define('toilets-list-show', {
    renderTo: "#toilets-list-show",

    init: function () {
        var self = this;
        var hub = self.hub;
        self.template = Handlebars[self._internals.moduleType];
        hub.broadcast('fetch-toilets-list');

        hub.listen('fetched-toilets-list', function (data) {
            self.render(data)
        });
    },

    render: function (data) {
        var self = this;
        $(self.renderTo).html(self.template(data));
    }
});
