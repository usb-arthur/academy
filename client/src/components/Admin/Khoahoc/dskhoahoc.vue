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
          <h1 class="md-title">KHÓA HỌC</h1>
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
        <div class="md-toolbar-section-start">Đã chọn {{ count }} khóa học</div>

        <div class="md-toolbar-section-end">
          <md-button class="md-icon-button" @click="deletekh">
            <md-icon>delete</md-icon>
          </md-button>
        </div>
      </md-table-toolbar>

      <md-table-empty-state
        v-if="!isLoading"
        md-label="Không tìm thấy khóa học"
        :md-description="
          `Không tìm thấy khóa học tên '${search}'. Thử tìm theo tên khác hoặc tạo mới.`
        "
      >
        <md-button class="md-primary md-raised" @click="newUser"
          >Tạo khóa học mới</md-button
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
        <md-table-cell md-label="Tên khóa học" md-sort-by="courseName">{{
          item.courseName
        }}</md-table-cell>
        <md-table-cell md-label="Mô tả">{{
          item.briefDescription
        }}</md-table-cell>
        <md-table-cell md-label="Ngày tạo" md-sort-by="createdDate">{{
          item.createdDate
        }}</md-table-cell>
        <md-table-cell md-label="Ngày chỉnh sửa" md-sort-by="updatedDate">{{
          item.updatedDate
        }}</md-table-cell>
        <md-table-cell md-label="Số học viên" md-sort-by="numOfStudent">{{
          item.numOfStudent
        }}</md-table-cell>
        <md-table-cell md-label="Tình trạng" md-sort-by="status">{{
          item.status
        }}</md-table-cell>
      </md-table-row>
    </md-table>

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
    selected: []
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
    deletekh() {
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
