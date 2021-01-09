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
          <h1 class="md-title">NGƯỜI DÙNG</h1>
        </div>

        <md-field md-clearable class="md-toolbar-section-end">
          <md-input
            placeholder="Tìm theo tên..."
            v-model="search"
            @input="searchOnTable"
          />
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
          <md-button v-if="morethanone" class="md-icon-button">
            <md-icon>settings</md-icon>
          </md-button>
          <md-button
            v-if="morethanone"
            class="md-icon-button"
            @click="renameUser"
          >
            <md-icon>create</md-icon>
          </md-button>
          <md-button class="md-icon-button" @click="deleteUser">
            <md-icon>delete</md-icon>
          </md-button>
        </div>
      </md-table-toolbar>

      <md-table-empty-state
        v-if="!isLoading"
        md-label="Không tìm thấy người dùng"
        :md-description="
          `Không tìm thấy người dùng tên '${search}'. Thử tìm theo tên khác hoặc tạo mới.`
        "
      >
        <md-button class="md-primary md-raised" @click="newUser"
          >Tạo người dùng mới</md-button
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
        <md-table-cell md-label="Tên" md-sort-by="name">{{
          item.name
        }}</md-table-cell>
        <md-table-cell md-label="Email" md-sort-by="email">{{
          item.email
        }}</md-table-cell>
        <md-table-cell md-label="Giới tính" md-sort-by="gender">{{
          item.gender
        }}</md-table-cell>
        <md-table-cell md-label="Ngày sinh" md-sort-by="dateOfBirth">{{
          item.dateOfBirth
        }}</md-table-cell>
        <md-table-cell md-label="Số điện thoại" md-sort-by="phoneNumber">{{
          item.phoneNumber
        }}</md-table-cell>
      </md-table-row>
    </md-table>

    <v-dialog v-model="addNewUser" max-width="600px">
      <v-card>
        <v-card-title>
          <span class="headline">Thêm người dùng mới</span>
        </v-card-title>
        <v-card-text>
          <v-form ref="form" v-model="valid1" lazy-validation>
            <v-text-field
              v-model="userNew.name"
              :rules="[() => !!userNew.name || 'Không được để trống']"
              :counter="50"
              label="Tên"
              required
            ></v-text-field>

            <v-text-field
              v-model.number="userNew.gender"
              type="number"
              label="Giới tính"
              required
            ></v-text-field>

            <v-text-field
              v-model="userNew.email"
              :rules="[() => !!userNew.email || 'Không được để trống']"
              label="E-mail"
              required
            ></v-text-field>

            <v-text-field
              v-model="userNew.contact"
              :rules="[() => !!userNew.contact || 'Không được để trống']"
              label="Contact"
              required
            ></v-text-field>

            <v-text-field
              v-model="userNew.dateOfBirth"
              :rules="[() => !!userNew.dateOfBirth || 'Không được để trống']"
              label="Ngày sinh"
              required
            ></v-text-field>

            <v-text-field
              v-model="userNew.phoneNumber"
              :rules="[() => !!userNew.phoneNumber || 'Không được để trống']"
              label="Số điện thoại"
              required
            ></v-text-field>

            <v-btn
              :disabled="!valid1"
              color="success"
              class="mr-4"
              @click="validate"
            >
              Tạo
            </v-btn>
          </v-form>
        </v-card-text>
      </v-card>
    </v-dialog>

    <v-dialog v-model="patchUser" max-width="600px">
      <v-card>
        <v-card-title>
          <span class="headline">Chỉnh sửa người dùng</span>
        </v-card-title>
        <v-card-text>
          <v-form ref="form1" v-model="valid" lazy-validation>
            <v-text-field
              v-model="userNew.name"
              :rules="[() => !!userNew.name || 'Không được để trống']"
              :counter="50"
              label="Tên"
              required
            ></v-text-field>

            <v-text-field
              v-model.number="userNew.gender"
              type="number"
              label="Giới tính"
              required
            ></v-text-field>

            <v-text-field
              v-model="userNew.contact"
              :rules="[() => !!userNew.contact || 'Không được để trống']"
              label="Contact"
              required
            ></v-text-field>

            <v-text-field
              v-model="userNew.dateOfBirth"
              :rules="[() => !!userNew.dateOfBirth || 'Không được để trống']"
              label="Ngày sinh"
              type="date"
              required
            ></v-text-field>

            <v-btn
              :disabled="!valid"
              color="success"
              class="mr-4"
              @click="validate1"
            >
              Tạo
            </v-btn>
          </v-form>
        </v-card-text>
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
                      Email
                    </th>
                  </tr>
                </thead>
                <tbody>
                  <tr v-for="item in selected" :key="item.id">
                    <td>{{ item.id }}</td>
                    <td>{{ item.name }}</td>
                    <td>{{ item.email }}</td>
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
    valid: false,
    valid1: false,
    patchUser: false,
    addNewUser: false,
    userNew: {
      name: "",
      gender: 0,
      email: "",
      contact: "",
      dateOfBirth: "2021-01-08",
      phoneNumber: ""
    },
    isLoading: true,
    search: null,
    searched: [],
    selected: [],
    list: []
  }),
  computed: {
    dsUser() {
      return this.$store.state.user.items;
    },
    searchByName() {
      if (this.search) {
        return this.list.filter(item =>
          item.name.toLowerCase().includes(this.search.toLowerCase())
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
        .dispatch("user/getAllUser")
        .then(() => {
          this.list = this.dsUser;
        })
        .catch(err => console.log(err));
      this.searched = this.list;
      this.selected = [];
    },
    async validate() {
      if (this.$refs.form.validate()) {
        await this.$store
          .dispatch("user/UploadUser", this.userNew)
          .then(() => {
            this.search = null;
            this.$refs.form.reset();
          })

          .catch(err => console.log(err));
        this.addNewUser = !this.addNewUser;
      }
      this.RefreshTable();
    },
    async validate1() {
      if (this.$refs.form1.validate()) {
        await this.$store
          .dispatch("user/UpdateUser", {
            id: this.searched[0].id,
            name: this.userNew.name,
            gender: this.userNew.gender,
            contact: this.userNew.contact,
            dateOfBirth: this.userNew.dateOfBirth
          })
          .then(() => {
            this.$refs.form1.reset();
          })
          .catch(err => console.log(err));
        this.patchUser = !this.patchUser;
      }
      this.RefreshTable();
    },
    newUser() {
      this.userNew.name = this.search;
      this.addNewUser = !this.addNewUser;
    },
    onSelect(items) {
      this.selected = items;
    },
    activeCatalog() {
      window.alert("Active");
    },
    renameUser() {
      this.patchUser = !this.patchUser;
    },
    assignCatalog() {
      window.alert("assign");
    },
    detailCatalog() {
      window.alert("detail");
    },
    deleteUser() {
      this.DeleteDialog = !this.DeleteDialog;
    },
    async ConfirmDelete() {
      for (let i = 0; i < this.selected.length; i++) {
        await this.$store.dispatch("user/DeleteUser", {
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
      .dispatch("user/getAllUser")
      .then(() => {
        this.list = this.dsUser;
      })
      .catch(err => console.log(err));
    this.isLoading = false;
    this.searched = this.list;
  }
};
</script>

<style lang="scss" scoped>
.md-field {
  max-width: 300px;
}
</style>
