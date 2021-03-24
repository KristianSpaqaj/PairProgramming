Vue.createApp({
    data(){
        return {
            records: [],
            title: "",
            artist: "",
            duration: null,
            releasedate: null
        }
    },
    methods: {
        GetRecords(){
            axios.get("https://pairprogramming20210324110603.azurewebsites.net/api/records?" + "title=" + this.title ).then(function(response){
                this.records = response["data"];

            }.bind(this))
        }
    },
    created: function(){
        this.GetRecords();
    }

}).mount("#app")