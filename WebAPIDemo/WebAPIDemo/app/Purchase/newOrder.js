(function () {
    'use strict';
    var controllerId = 'newOrder';
    angular.module('app').controller(controllerId, ['common', 'datacontext', viewModel]);

    function viewModel(common, datacontext) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);
        var logInfo = getLogFn(controllerId, "info");
        var logSuccess = getLogFn(controllerId, "success");

        var vm = this;
        vm.addBookToOrder = addBookToOrder;
        vm.books = [];
        vm.order = null;
        vm.orderDetails = [];



        activate();

        function activate() {
            common.activateController([], controllerId)
                .then(function () {
                    log('Activated New Order View');
                    createOrder();
                });

            logInfo("Getting Books.....");
            datacontext.getBooks()
            .then(function (books) {
                vm.books = books;
            })
        }

        function addBookToOrder(book, order) {
            var details = vm.orderDetails;
            var len = details.length;
            var bookExists = false;

            details.forEach(function (detail) {
                if (detail.book === book) {
                    bookExists = true;
                    detail.quantity += 1;
                }
                else 
                    bookExists = false;
            })

            if (bookExists == false) {
                var newItem = datacontext.addBookToOrder(book, order);
            }
      


        }

        function createOrder() {
            vm.order = datacontext.createOrder();
        }
    }
})();