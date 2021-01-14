<template>
  <div>
    <v-dialog v-model="addNewCatalog" persistent max-width="600px">
      <v-card>
        <v-card-title>
          <span class="headline">Tạo catalog mới</span>
        </v-card-title>
        <v-card-text>
          <v-container>
            <v-row>
              <v-text-field
                label="Tên lĩnh vực"
                required
                v-model="search"
              ></v-text-field>
            </v-row>
            <v-row>
              <v-select :items="getParentID" v-model="ThuocLV"></v-select>
            </v-row>
          </v-container>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" text @click="addNewCatalog = false">
            Close
          </v-btn>
          <v-btn color="blue darken-1" text @click="ConfirmAdd">
            Save
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>

    <v-dialog v-model="rename" persistent max-width="600px">
      <v-card>
        <v-card-title>
          <span class="headline">Đổi tên lĩnh vực</span>
        </v-card-title>
        <v-card-text>
          <v-container>
            <v-row>
              <v-text-field
                label="Tên lĩnh vực mới"
                required
                v-model="newname"
              ></v-text-field>
            </v-row>
          </v-container>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" text @click="rename = false">
            Close
          </v-btn>
          <v-btn color="blue darken-1" text @click="ConfirmRename">
            Save
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>

    <v-dialog v-model="DeleteDialog" persistent max-width="600px">
      <v-card>
        <v-card-title>
          <span class="headline">Xóa người dùng</span>
        </v-card-title>
        <v-card-text>
          <v-container>
            <v-simple-table dense>
              <template v-slot:default>
                <thead>
                  <tr>
                    <th class="text-left">
                      ID
                    </th>
                    <th class="text-left">
                      Tên
                    </th>
                    <th class="text-left">
                      Người tạo
                    </th>
                    <th class="text-left">
                      Ngày tạo
                    </th>
                  </tr>
                </thead>
                <tbody>
                  <tr v-for="item in selected" :key="item.id">
                    <td>{{ item.id }}</td>
                    <td>{{ item.categoryName }}</td>
                    <td>{{ item.createdBy }}</td>
                    <td>{{ item.createdDate }}</td>
                  </tr>
                </tbody>
              </template>
            </v-simple-table>
          </v-container>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" text @click="DeleteDialog = false">
            Hủy
          </v-btn>
          <v-btn color="blue darken-1" text @click="ConfirmDelete">
            Xác nhận xóa
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>

    <v-data-table
      :headers="header"
      :items="list"
      :items-per-page="5"
      :search="search"
      class="elevation-1"
    >
      <template v-slot:top>
        <v-toolbar flat>
          <v-text-field
            v-model="search"
            label="Search"
            class="mx-4"
          ></v-text-field>
          <v-btn color="primary" dark class="mb-2" @click="newUser">
            Thêm mới
          </v-btn>
          <v-spacer></v-spacer>
        </v-toolbar>
      </template>
      <template v-slot:[`item.actions`]="{ item }">
        <v-icon small class="mr-2" @click="renameCatalog(item)">
          mdi-pencil
        </v-icon>
        <v-icon small @click="deleteCatalog(item)">
          mdi-delete
        </v-icon>
      </template>
    </v-data-table>
  </div>
</template>

<script>
export default {
  name: "TableSearch",
  data: () => ({
    DeleteDialog: false,
    newname: null,
    rename: false,
    ThuocLV: null,
    addNewCatalog: false,
    isLoading: true,
    search: null,
    searched: [],
    selected: [],
    list: [],
    header: [
      { text: "ID", value: "id" },
      { text: "Name", value: "categoryName" },
      { text: "Tạo bởi", value: "createdBy" },
      { text: "Cập nhật bởi", value: "updatedBy" },
      { text: "Ngày tạo", value: "createdDate" },
      { text: "Ngày cập nhật", value: "updatedDate" },
      { text: "Thuộc", value: "parent" },
      { text: "", value: "actions" }
    ]
  }),
  computed: {
    dslinhvucs() {
      let catagorylist = [];
      this.$store.state.linhvuc.items.map(obj => {
        catagorylist.push({
          id: obj.id,
          categoryName: obj.categoryName,
          createdDate: obj.createdDate,
          updatedDate: obj.updatedDate,
          createdBy: obj.createdBy,
          updatedBy: obj.updatedBy,
          parent: null
        });
        obj.children.map(objc => {
          catagorylist.push({
            id: objc.id,
            categoryName: objc.categoryName,
            createdDate: objc.createdDate,
            updatedDate: objc.updatedDate,
            createdBy: objc.createdBy,
            updatedBy: objc.updatedBy,
            parent: obj.id + " - " + obj.categoryName
          });
        });
      });
      //console.log(catagorylist)
      return catagorylist;
    },
    getParentID() {
      let listid = this.$store.state.linhvuc.items.map(
        obj => obj.id + "-" + obj.categoryName
      );
      listid.push("");
      return listid;
    },
    searchByName() {
      if (this.search != null) {
        return this.list.filter(item =>
          item.categoryName.toLowerCase().includes(this.search.toLowerCase())
        );
      }

      return this.list;
    },
    morethanone() {
      if (this.selected.length < 2) return true;
      return false;
    }
  },
  methods: {
    async RefreshTable() {
      await this.$store
        .dispatch("linhvuc/getAllCategories")
        .then(() => {
          this.list = this.dslinhvucs;
        })
        .catch(err => console.log(err));
      this.searched = this.list;
      this.selected = [];
      this.ThuocLV = null;
    },
    newUser() {
      //window.alert('Noop')
      this.addNewCatalog = !this.addNewCatalog;
    },
    async ConfirmAdd() {
      let temp = null;
      if (this.ThuocLV != "")
        temp = parseInt(this.ThuocLV.substr(0, this.ThuocLV.indexOf("-")));
      await this.$store
        .dispatch("linhvuc/UploadCategory", {
          categoryName: this.search,
          categoryId: temp
        })
        .then(() => {
          this.search = null;
        })

        .catch(err => console.log(err));
      /*await this.$store.dispatch("linhvuc/getAllCategories")
                .then(() => { this.list = this.dslinhvucs})
                .catch(err => console.log(err));
                this.searched = this.list;*/
      this.RefreshTable();
      this.addNewCatalog = !this.addNewCatalog;
    },
    onSelect(items) {
      this.selected = items;
    },
    activeCatalog() {
      window.alert("Active");
    },
    renameCatalog(item) {
      this.selected = [];
      this.selected.push(item);
      this.newname = item.categoryName;
      this.rename = !this.rename;
    },
    async ConfirmRename() {
      if (this.newname != "" || this.newname != null) {
        await this.$store
          .dispatch("linhvuc/UpdateNameCategory", {
            id: this.selected[0].id,
            categoryName: this.newname
          })
          .then(() => {})
          .catch(err => console.log(err));
        this.RefreshTable();
        this.rename = !this.rename;
      }
    },
    assignCatalog() {
      window.alert("assign");
    },
    detailCatalog() {
      window.alert("detail");
    },
    deleteCatalog(item) {
      this.selected = [];
      this.selected.push(item);
      this.DeleteDialog = !this.DeleteDialog;
    },
    async ConfirmDelete() {
      for (let i = 0; i < this.selected.length; i++) {
        await this.$store.dispatch("linhvuc/DeleteCategory", {
          id: this.selected[i].id
        });
      }
      this.DeleteDialog = !this.DeleteDialog;
      this.RefreshTable();
    },
    searchOnTable() {
      this.searched = this.searchByName;
    }
  },
  async created() {
    await this.$store
      .dispatch("linhvuc/getAllCategories")
      .then(() => {
        this.list = this.dslinhvucs;
      })
      .catch(err => console.log(err));
    this.isLoading = false;
    this.searched = this.list;
    console.log(this.list);
  },
  mounted() {}
};
</script>

<style lang="scss" scoped>
.md-field {
  max-width: 300px;
}
</style>
