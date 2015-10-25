require.config({
    baseUrl: "../../../Production/js/KeesDijk",
    //baseUrl: "../../../Production/js/Start",
    paths: {
        lodash: "../../Scripts/lodash"
    },
    shim: {
        'lodash': {
            exports: '_'
        }
    }
});