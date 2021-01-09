<template>
  <div>
    <md-table
      v-model="searched"
      md-sort="name"
      md-sort-order="asc"
      @md-selected="onSelect"
      md-card
      md-fixed-header
    >
      <md-table-toolbar>
        <div class="md-toolbar-section-start">
          <h1 class="md-title">LĨNH VỰC</h1>
        </div>

        <md-field md-clearable class="md-toolbar-section-end">
          <md-input
            placeholder="Tìm theo tên..."
            v-model="search"
            @input="searchOnTable"
          />

          <v-btn @click="newUser">
            <v-icon>mdi-plus</v-icon>
          </v-btn>
        </md-field>
      </md-table-toolbar>

      <md-table-toolbar slot="md-table-alternate-header" slot-scope="{ count }">
        <div class="md-toolbar-section-start">Đã chọn {{ count }} lĩnh vực</div>

        <div class="md-toolbar-section-end">
          <md-button
            v-if="morethanone"
            class="md-icon-button"
            @click="detailCatalog"
          >
            <md-icon>assignment</md-icon>
          </md-button>
          <md-button
            v-if="morethanone"
            class="md-icon-button"
            @click="assignCatalog"
          >
            <md-icon>settings</md-icon>
          </md-button>
          <md-button
            v-if="morethanone"
            class="md-icon-button"
            @click="renameCatalog"
          >
            <md-icon>create</md-icon>
          </md-button>
          <md-button class="md-icon-button" @click="deleteCatalog">
            <md-icon>delete</md-icon>
          </md-button>
        </div>
      </md-table-toolbar>

      <md-table-empty-state
        v-if="!isLoading"
        md-label="Không tìm thấy lĩnh vực"
        :md-description="
          `Không tìm thấy lĩnh vực tên '${search}'. Thử tìm theo tên khác hoặc tạo mới.`
        "
      >
        <md-button class="md-primary md-raised" @click="newUser"
          >Tạo lĩnh vực mới</md-button
        >
      </md-table-empty-state>

      <md-table-row
        slot="md-table-row"
        slot-scope="{ item }"
        md-selectable="multiple"
        md-auto-select
      >
        <md-table-cell md-label="ID" md-sort-by="id" md-numeric>{{
          item.id
        }}</md-table-cell>
        <md-table-cell md-label="Lĩnh vực" md-sort-by="categoryName">{{
          item.categoryName
        }}</md-table-cell>
        <md-table-cell md-label="Tạo bởi" md-sort-by="createdBy">{{
          item.createdBy
        }}</md-table-cell>
        <md-table-cell md-label="Cập nhật bởi" md-sort-by="updatedBy">{{
          item.updatedBy
        }}</md-table-cell>
        <md-table-cell md-label="Ngày tạo" md-sort-by="createdDate">{{
          item.createdDate
        }}</md-table-cell>
        <md-table-cell md-label="Ngày cập nhật" md-sort-by="updatedDate">{{
          item.updatedDate
        }}</md-table-cell>
        <md-table-cell md-label="Thuộc">{{ item.parent }}</md-table-cell>
      </md-table-row>
    </md-table>

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
                    <td>{{ item.name }}</td>
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
    list: []
  }),
  computed: {
    dslinhvucs() {
      let catagorylist = [];
      this.$store.state.linhvuc.items.map(obj => {
        catagorylist.push({
          id: obj.id,
          categoryName: obj.categoryName,
          createdDate: obj.createdDate,
          updateDate: obj.updatedDate,
          createdBy: obj.createdBy,
          updatedBy: obj.updatedBy,
          parent: null
        });
        obj.children.map(objc => {
          catagorylist.push({
            id: objc.id,
            categoryName: objc.categoryName,
            createdDate: objc.createdDate,
            updateDate: objc.updatedDate,
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
      if (this.ThuocLV == "") this.ThuocLV = null;
      await this.$store
        .dispatch("linhvuc/UploadCategory", {
          categoryName: this.search,
          categoryId: parseInt(
            this.ThuocLV.substr(0, this.ThuocLV.indexOf("-"))
          )
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
    renameCatalog() {
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
    deleteCatalog() {
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
