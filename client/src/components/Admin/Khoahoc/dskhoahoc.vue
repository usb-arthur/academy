<template>
  <div>
    <v-dialog v-model="DeleteDialog" persistent max-width="600px">
      <v-card>
        <v-card-title>
          <span class="headline">Xóa khóa học</span>
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
                      Tên khóa học
                    </th>
                    <th class="text-left">
                      Số học viên
                    </th>
                    <th class="text-left">
                      Ngày tạo
                    </th>
                    <th class="text-left">
                      Tình trạng
                    </th>
                  </tr>
                </thead>
                <tbody>
                  <tr v-for="item in selected" :key="item.id">
                    <td>{{ item.id }}</td>
                    <td>{{ item.courseName }}</td>
                    <td>{{ item.numOfStudent }}</td>
                    <td>{{ item.createdDate }}</td>
                    <td>{{ item.status }}</td>
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
          <v-spacer></v-spacer>
        </v-toolbar>
      </template>
      <template v-slot:[`item.actions`]="{ item }">
        <v-icon small @click="deletekh(item)">
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
    isLoading: true,
    DeleteDialog: false,
    list: [],
    search: null,
    searched: [],
    selected: [],
    header: [
      { text: "ID", value: "id" },
      { text: "Tên khóa học", value: "courseName" },
      { text: "Mô tả", value: "briefDescription" },
      { text: "Ngày tạo", value: "createdDate" },
      { text: "Ngày cập nhật", value: "updatedDate" },
      { text: "Số học viên", value: "numOfStudent" },
      { text: "Tình trạng", value: "status" },
      { text: "", value: "actions" }
    ]
  }),
  computed: {
    dskhoahoc() {
      return this.$store.state.khoahoc.items;
    },
    searchByName() {
      if (this.search) {
        return this.list.filter(item =>
          item.courseName.toLowerCase().includes(this.search.toLowerCase())
        );
      }

      return this.dskhoahoc;
    },
    morethanone() {
      if (this.selected.length < 2) return true;
      return false;
    }
  },
  methods: {
    async RefreshTable() {
      await this.$store
        .dispatch("khoahoc/getAllCourses")
        .then(() => {
          this.list = this.dskhoahoc;
        })
        .catch(err => console.log(err));
      this.searched = this.list;
      this.selected = [];
    },
    newUser() {
      window.alert("Noop");
    },
    onSelect(items) {
      this.selected = items;
    },
    deletekh(item) {
      this.selected = [];
      this.selected.push(item);
      this.DeleteDialog = !this.DeleteDialog;
    },
    async ConfirmDelete() {
      this.DeleteDialog = !this.DeleteDialog;
      for (let i = 0; i < this.selected.length; i++) {
        await this.$store.dispatch("khoahoc/DeleteCourse", {
          id: this.selected[i].id
        });
      }
      this.RefreshTable();
    },
    searchOnTable() {
      this.searched = this.searchByName;
    }
  },
  async created() {
    await this.$store
      .dispatch("khoahoc/getAllCourses")
      .then(() => {
        this.list = this.dskhoahoc;
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
