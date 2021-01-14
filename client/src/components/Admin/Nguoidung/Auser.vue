<template>
  <div>
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

            <v-radio-group
              v-model="userNew.gender"
              mandatory
              label="Giới tính: "
            >
              <v-radio label="Nam" value="0"></v-radio>
              <v-radio label="Nữ" value="1"></v-radio>
            </v-radio-group>

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
              type="date"
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

            <v-radio-group
              v-model="userNew.gender"
              mandatory
              label="Giới tính: "
            >
              <v-radio label="Nam" value="0"></v-radio>
              <v-radio label="Nữ" value="1"></v-radio>
            </v-radio-group>

            <v-text-field
              v-model="userNew.phoneNumber"
              :rules="[() => !!userNew.phoneNumber || 'Không được để trống']"
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
              Xác nhận
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
        <v-icon small class="mr-2" @click="renameUser(item)">
          mdi-pencil
        </v-icon>
        <v-icon small @click="deleteUser(item)">
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
    radios: null,
    DeleteDialog: false,
    valid: false,
    valid1: false,
    patchUser: false,
    addNewUser: false,
    userNew: {
      name: "",
      gender: null,
      email: "",
      contact: "",
      dateOfBirth: "2021-01-08",
      phoneNumber: ""
    },
    isLoading: true,
    search: null,
    searched: [],
    selected: [],
    list: [],
    header: [
      { text: "ID", value: "id" },
      { text: "Tên", value: "name" },
      { text: "Email", value: "email" },
      { text: "Giới tính", value: "gender" },
      { text: "Ngày sinh", value: "dateOfBirth" },
      { text: "Số điện thoại", value: "phoneNumber" },
      { text: "", value: "actions" }
    ]
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
            id: this.userNew.id,
            name: this.userNew.name,
            gender: this.userNew.gender,
            phoneNumber: this.userNew.phoneNumber,
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
    renameUser(item) {
      this.selected = [];
      this.selected.push(item);
      Object.assign(this.userNew, item);
      this.patchUser = !this.patchUser;
    },
    assignCatalog() {
      window.alert("assign");
    },
    detailCatalog() {
      window.alert("detail");
    },
    deleteUser(item) {
      this.selected = [];
      this.selected.push(item);
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
