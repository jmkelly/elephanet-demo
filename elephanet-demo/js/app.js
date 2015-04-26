Kernel.register('greeter', 'greeter');
Kernel.register('toilets-list-show', 'toilets-list-show');

$('document').ready(function () {
    Kernel.startAll();
});