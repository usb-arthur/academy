<template>
  <v-container fluid>
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
      </template>
      <template v-slot:item.actions="{ item }">
        <router-link :to="`/giang-vien/chi-tiet-khoa-hoc/${item.id}`">
          <v-icon small class="mr-2">
            mdi-eye
          </v-icon>
        </router-link>
        <router-link :to="`/giang-vien/cap-nhat-khoa-hoc/${item.id}`">
          <v-icon small class="mr-2">
            mdi-pencil
          </v-icon>
        </router-link>
        <v-icon small @click="deleteCourse(item)">
          mdi-delete
        </v-icon>
      </template>
    </v-data-table>
  </v-container>
</template>

<script>
import { createNamespacedHelpers } from "vuex";
const { mapActions, mapState } = createNamespacedHelpers("course");

export default {
  data: () => ({
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
    ]
  }),
  created() {
    this.getAllCourses();
  },
  computed: {
    ...mapState(["courses"])
  },
  methods: {
    ...mapActions(["getAllCourses", "deleteCourse"])
  }
};
</script>
