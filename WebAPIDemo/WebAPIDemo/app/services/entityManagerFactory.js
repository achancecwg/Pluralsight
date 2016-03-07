(function() {
    'use strict';
    
    var serviceId = 'entityManagerFactory';
    angular.module('app').factory(serviceId,
        ['config', emFactory]);
    


    function emFactory(config) {

        var metadataStore = new breeze.MetadataStore();

        var provider = {
            metadataStore: metadataStore,
            newManager: newManager
        };

        return provider;

        function newManager() {
            var manager = new breeze.EntityManager({serviceName: config.remoteServiceName, metadataStore: metadataStore});
            return manager;
        };

    };
 
    })();