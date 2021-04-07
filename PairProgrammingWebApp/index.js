Vue.createApp({
    data(){
        return {
            records: [],
            title: "",
            artist: "",
            addData: {title: "", artist: "", duration: null},
            duration: null,
            releasedate: null,
            addmessage: ""
        }
    },
    methods: {
        GetRecords(){
            axios.get("https://pairprogramming20210324110603.azurewebsites.net/api/records?" + "title=" + this.title ).then(function(response){
                this.records = response["data"];

            }.bind(this))
        },
        async AddRecord()
        { try {
            console.log(this.addData)
            response = await axios.post("https://pairprogramming20210324110603.azurewebsites.net/api/records", this.addData)
            this.addmessage = "response " + response.status + " " + response.statusText
        } catch (ex) { 
            alert(ex.message)
        } 
        }
    },
        
    created: function(){
        this.GetRecords();
    }

}).mount("#app")