<template>
  <v-container class="text-left">
    <v-data-table :headers="headers" :items="courses" sort-by="courseName">
      <template slot="top">
        <v-toolbar flat>
          <v-toolbar-title>Khóa học của tôi</v-toolbar-title>
          <v-divider class="mx-4" inset vertical></v-divider>
          <v-spacer></v-spacer>
          <router-link to="/giang-vien/tao-khoa-hoc">
            <v-btn color="primary" dark class="mb-2">Tạo khóa học mới</v-btn>
          </router-link>
        </v-toolbar>
        <v-dialog v-model="dialogDelete" max-width="540px">
          <v-card>
            <v-card-title class="headline"
              >Are you sure you want to delete this course?</v-card-title
            >
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" text @click="closeDelete"
                >Cancel</v-btn
              >
              <v-btn color="blue darken-1" text @click="deleteCourseConfirm"
                >OK</v-btn
              >
              <v-spacer></v-spacer>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </template>
      <template v-slot:item.actions="{ item }">
        <router-link :to="`/giang-vien/chi-tiet-khoa-hoc/${item.id}`">
          <v-icon small class="mr-2"> mdi-eye </v-icon>
        </router-link>
        <router-link :to="`/giang-vien/cap-nhat-khoa-hoc/${item.id}`">
          <v-icon small class="mr-2"> mdi-pencil </v-icon>
        </router-link>
        <v-icon small @click="deleteItem(item.id)"> mdi-delete </v-icon>
      </template>
    </v-data-table>
    <v-snackbar v-model="snackbar" timeout="2000">
      {{ text }}
      <template v-slot:action="{ attrs }">
        <v-btn color="blue" text v-bind="attrs" @click="snackbar = false">
          Đóng
        </v-btn>
      </template>
    </v-snackbar>
  </v-container>
</template>

<script>
import { createNamespacedHelpers } from "vuex";
const { mapActions, mapState } = createNamespacedHelpers("course");

export default {
  data: () => ({
    snackbar: false,
    text: "",
    dialogDelete: false,
    headers: [
      {
        text: "Tên khóa học",
        align: "start",
        value: "courseName"
      },
      {
        text: "Giá",
        value: "courseFee"
      },
      {
        text: "Ngày tạo",
        value: "createdDate"
      },
      {
        text: "Lần cập nhật cuối",
        value: "updatedDate"
      },
      {
        text: "Trạng thái",
        value: "status"
      },
      {
        text: "",
        value: "actions",
        sortable: false
      }
    ],
    id: -1
  }),
  created() {
    this.getAllCourses();
  },
  watch: {
    dialogDelete(val) {
      val || this.closeDelete();
    },
    text() {
      this.snackbar = true;
    }
  },
  computed: {
    ...mapState(["courses"])
  },
  methods: {
    ...mapActions(["getAllCourses", "deleteCourse"]),
    closeDelete() {
      this.dialogDelete = false;
      this.$nextTick(() => {
        this.id = -1;
      });
    },
    deleteCourseConfirm() {
      this.deleteCourse(this.id)
        .then(() => {
          this.text = "Thao tác thành công";
          this.closeDelete();
        })
        .catch(err => {
          this.text =
            err.response.statusText ||
            "Có lỗi xảy ra. Vui lòng liên hệ admin để biết thêm chi tiết";
        });
    },
    deleteItem(id) {
      this.id = id;
      this.dialogDelete = true;
    }
  }
};
</script>
