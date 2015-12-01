var pricingHub = $.connection.pricingHub;
var projectHub = $.connection.projectHub;
var selectedId = 0;
pricingHub.client.projectBudgetRecalculated = function (message) {
    //TODO: update the budget widget
    console.log('budget updated');
};

projectHub.client.productAddedToProject = function (message) {
    console.log('product added');
    $('#floorplan').append("<div id='placed-icon-" + message.ProductId + "' class='placed-icon icon icon-" + message.ProductId + "'></div>");
    $('#placed-icon-' + message.ProductId).css('top', message.Y + 'px');
    $('#placed-icon-' + message.ProductId).css('left', message.X + 'px');
}

function addProductToProject(productId,x,y) {
    $.post('/api/ProjectProducts', {
        productId: selectedId,
        projectId: 1,
        x: x,
        y:y
    });
}

$.connection.hub.start().done(function () {
    console.log('started the hub');

    $('.icon').click(function (e) {
        $('.selected').removeClass('selected');
        selectedId = 0;
        $(this).addClass('selected');
        selectedId = $(this).data('id');
    });

    $('#floorplan').click(function(e) {
        if (0 == selectedId) {
            return;
        }
        addProductToProject(selectedId,e.offsetX,e.offsetY);
        $('.selected').removeClass('selected');
        selectedId = 0;
    });

});