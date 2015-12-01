var pricingHub = $.connection.pricingHub;

pricingHub.client.projectBudgetRecalculated = function (message) {
    $('#total').text(message.HighCost);
};

$.connection.hub.start().done(function () {
    console.log('started the hub');
});