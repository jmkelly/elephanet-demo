Kernel.hub.define('toilets', {
    init: function () {
        var self = this;
        console.log('toilet hub started');
        self.listen('fetch-toilets-list', function () {
            console.log('fetching toilets...')
            $.ajax({
                url: "toilets",
                contentType: 'application/json',
                success: function (data) {
                    hub.broadcast('fetched-toilets-list', data);
                },
                error: function () {
                    hub.broadcast('error', 'error fetching toilet data');
                }
            });
        });
    }
});

var hub = Kernel.hub.get('toilets');
hub.init();


