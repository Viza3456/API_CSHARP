const vueapi =
    {
        template : `
            <div>
                <div>
                    <nav class="navbar navbar-expand-sm bg-ligth navbar-dark">
                        <button class="btn btn-light btn-outline-primary m-1" @click = "createclick">Add Data</button>
                    </nav>
                </div>
                <table class="table table-hover">
                    <thead>
                        <tr> 
                            <th>Id</th>
                            <th>Name</th>
                            <th>Photo</th>
                            <th>CreateDate</th> 
                            <th>UpdateDate</th> 
                            <th>Edit</th> 
                            <th>Delete</th> 
                        </tr> 
                    </thead>
                    <tbody>
                        <tr v-for = "vue in vueapis"> 
                            <td>{{vue.Id}}</td>
                            <td>{{vue.Name}}</td>
                            <td>{{vue.Photo}}</td>
                            <td>{{vue.CreateDate}}</td> 
                            <td>{{vue.UpdateDate}}</td> 
                            <td>
                                <button type="button" class="btn btn-success" @click = "edit(vue)">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil-square" viewBox="0 0 16 16">
                                        <path d="M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"/>
                                        <path fill-rule="evenodd" d="M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"/>
                                    </svg> Edit
                                </button>
                            </td> 
                            <td>
                                <button type="button" class="btn btn-danger" @click = "deletedata(vue.Id)">
                                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
                                        <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/>
                                        <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/>
                                    </svg> Delete
                                </button>
                            </td> 
                        </tr> 
                    </tbody>
                </table>
                <div class="modal fade" role="dialog" id="myModal" tabindex="-1"> 
                    <div class="modal-dialog" role="document">
                        <div class="modal-content"> 
                            <div class="modal-header"> 
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">×</span>
                                </button> 
                            </div> 
                            <div class="modal-body row"> 
                                <div class = "col-md-6 form-group">
                                    <div style = "display: flex; margin-bottom: 20px;"> 
                                        <div class="input-group-addon" style = "height: 37px;
                                        width: 65px;
                                        background: #737373;color: white;
                                        padding: 5px;
                                        padding-left: 18px;">ID</div>
                                        <input type="number" v-model = "Id" style = "border-radius: 0;" class="form-control" placeholder="ID"> 
                                    </div>
                                    <div  style = "display: flex; margin-bottom: 20px;"> 
                                        <div class="input-group-addon" style = "height: 37px;
                                        width: 65px;
                                        background: #737373;
                                        color: white;
                                        padding: 5px;
                                        padding-left: 18px;">Name</div>
                                        <input type="text" v-model = "Name" style = "border-radius: 0;" class="form-control"placeholder="Name"> 
                                    </div>
                                </div>
                                <div  class = "col-md-6">
                                    <div class="form-group"> 
                                        <div>
                                            <label>Photo</label>
                                        </div>
                                        <div>
                                            <img :src="PhotoPath + Photo" style = "height: 200px;width: 200px;background: aliceblue;   background-size: contain;
                                            background-repeat: no-repeat;
                                            background-position: center;">
                                        </div>
                                    </div> 
                                    <button type="button" class="btn btn-primary" @click = "Choose_file">Choose file</button> 
                                    <input type="file" @change = "imgupload" id = "file1" style = "width: 0;">
                                </div>
                            </div> 
                            <div class="modal-footer"> 
                                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button> 
                                <button type="button" class="btn btn-primary" @click = "update">Update</button>
                                <button type="button" class="btn btn-primary" @click = "postdata">Save</button> 
                            </div>
                        </div> 
                    </div> 
                </div>
            </div>
        `,

        // <div class = "row m-1">
        //     <div class = "col-md-6">
        //         <input type="text" v-model = "SelectId" v-on:keyup = "Filterdata" style = "border-radius: 0;" class="form-control"placeholder="Enter Id">
        //     </div> 
        //     <div class = "col-md-6">
        //         <input type="text" v-model = "SelectName" v-on:keyup = "Filterdata" style = "border-radius: 0;" class="form-control"placeholder="Enter Name">
        //     </div> 
        // </div> 
        data() {
            return {
                vueapis:[],
                Id : "",
                Name : "",
                Photo : "",
                SelectId : null,
                SelectName : "",
                DataFilter : [],
                PhotoPath : variables.PHOTO_URL,
                cre : true,
                up : false,
            }
        },
        methods: {
            getdata(){
                axios.get(variables.API_URL +"VueApi")
                .then((result) => {
                    this.DataFilter = result.data;
                    this.vueapis = result.data;
                }).catch((err) => {
                    alert("Error");
                });
            },
            createclick(){
                this.Photo = "a1.jpeg";
                $('#myModal').modal('show');
            },
            postdata(){
                axios.post(variables.API_URL +"VueApi",{
                    Id : this.Id,
                    Name : this.Name,
                    Photo : this.Photo
                }
                ).then((result) => {
                    console.log('tag', this.Photo);
                    this.getdata();
                    $('#myModal').modal('hide');
                    alert("Post Successfully");
                }).catch((err) => {
                    alert("Error");
                });
            },
            edit(data){
                cre = false;
                up = true;
                this.Id = data.Id;
                this.Name = data.Name;
                this.Photo = data.Photo;
                $('#myModal').modal('show');
            },
            update(){
                console.log('tag', this.Id);
                axios.put(variables.API_URL +"VueApi/" + this.Id ,{
                    Id : this.Id,
                    Name : this.Name,
                    Photo : this.Photo
                }
                ).then((result) => {
                    this.getdata();
                    $('#myModal').modal('hide');
                    alert("Update Successfully");
                }).catch((err) => {
                    alert("Error");
                });
            },
            Choose_file(){
                $('#file1').trigger('click');
            },
            imgupload(event){
                let formdata = new FormData();
                formdata.append('file', event.target.files[0]);
                axios.post(variables.API_URL +"VueApi/SaveFile",formdata)
                .then((result) => {
                    this.Photo = result.data;
                });
            },
            deletedata(Id){
                if(!confirm("Are you sure?")) return;
                axios.delete(variables.API_URL +"VueApi/" + Id)
                .then((result) => {
                    this.getdata();
                    alert("Delete Successfully");
                }).catch((err) => {
                    alert("Error");
                });
            },
            // Filterdata(){
            //     var SelectId = this.SelectId;
            //     var SelectName = this.SelectName;
            //     this.vueapis = this.DataFilter.filter(
            //         function(el){
            //             console.log('tag', el);
            //             return el.SelectId.toString().toLowerCase().includes(
            //                 SelectId.toString().trim().toLowerCase()
            //             )&&
            //             el.SelectName.toString().toLowerCase().includes(
            //                 SelectName.toString().trim().toLoverCase()
            //             )
            //         }
            //     )
            // }
        },
        mounted() {
            this.getdata();
        },
    }