describe('When verifying the Jasmine test environment', function () {
    it('should run a true test', function () {
        expect(true).toBe(true);
    });
});

describe('when querying the breeze web api', function () {
    'use strict';
    
    var fns = window.testFns;
    var EntityQuery = breeze.EntityQuery;
    var em, tester;
    var failed = fns.failed;

    beforeEach(function () {
        tester = ngMidwayTester('BreezeWebApiTest');
        em = new breeze.EntityManager(fns.serviceName);
    });

    afterEach(function () {
        tester.destroy();
        tester = null;
    });
    
    it('should get at least one order', function (done) {
        EntityQuery.from("Orders")
        .using(em)
        .execute()
        .then(success)
        .catch(failed)
        .finally(done);

        function success(data) {
            var results = data.results;
            expect(results.length).toBeGreaterThan(0);
        };
    });
})