baseUrl = "https://pairprogramminwebapp.azurewebsites.net/api/records"
Vue.createApp({
    data() {
        return {
            records: [],
            title: "",
            artist: "",
            addData: { title: "", artist: "", duration: null, releaseDate: null },
            duration: null,
            releasedate: null,
            addmessage: ""
        }
    },
    methods: {
        GetRecords() {
            axios.get(baseUrl + "?title=" + this.title).then(function (response) {
                this.records = response["data"];

            }.bind(this))
        },
        async AddRecord() {
            try {
                console.log(this.addData)
                response = await axios.post(baseUrl, this.addData)
                this.addmessage = "response " + response.status + " " + response.statusText
            } catch (ex) {
                alert(JSON.stringify(this.addData))
            }
        }
    },

    created: function () {
        this.GetRecords();
    }

}).mount("#app")