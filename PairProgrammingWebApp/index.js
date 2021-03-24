Vue.createApp({
    data(){
        return {
            records: []
        }
    },
    methods: {
        GetRecords(){
            axios.get("https://pairprogramming20210324110603.azurewebsites.net/api/records").then(function(response){
                this.records = response["data"];

            }.bind(this))
        }
    },
    created: function(){
        this.GetRecords();
    }

}).mount("#app")