<template>
  <v-container>
    <v-row>
      <v-col cols="12">
        <v-tabs fixed-tabs v-model="tab">
          <v-tab>Thông tin cá nhân</v-tab>
          <v-tab>Khóa học của tôi</v-tab>
          <v-tab v-if="has('student')">Danh sách yêu thích của tôi</v-tab>
          <v-tab>Đổi mật khẩu</v-tab>
        </v-tabs>
      </v-col>
      <v-col cols="12">
        <v-tabs-items v-model="tab">
          <v-tab-item>
            <DetailAccount></DetailAccount>
          </v-tab-item>
          <v-tab-item>
            <MyCourseList
              title="khoá học"
              :currentPage="subscribeCourses.page"
              :length="subscribeCourses.nPage"
              @pageChange="coursePage = $event"
              :courses="subscribeCourses.content"
            ></MyCourseList>
          </v-tab-item>
          <v-tab-item v-if="has('student')">
            <MyCourseList
              title="có khoá học yêu thích"
              :currentPage="wishList.page"
              :length="wishList.nPage"
              @pageChange="wishListPage = $event"
              :courses="wishList.content"
            ></MyCourseList>
          </v-tab-item>
          <v-tab-item>
            <ChangePassword></ChangePassword>
          </v-tab-item>
        </v-tabs-items>
      </v-col>
    </v-row>
  </v-container>
</template>
<script>
import DetailAccount from "@/views/Page/Account/DetailAccount";
import MyCourseList from "@/views/Page/Teacher/MyCourseList";
import ChangePassword from "@/views/Page/Account/ChangePassword";
import constant from "@/constants";
import { mapActions, mapState } from "vuex";

export default {
  data: () => ({
    tab: null,
    coursePage: 1,
    wishListPage: 1,
    limit: constant.LIMIT,
  }),
  watch: {
    coursePage(val) {
      if (this.has("teacher")) {
        this.getCoursesPaging({ page: val, limit: this.limit });
      } else {
        this.getSubscribeCourse({ page: val, limit: this.limit });
      }
    },

    wishListPage(val) {
      if (!this.has("teacher"))
        this.getAllWishList({ page: val, limit: this.limit });
    },
  },
  created() {
    if (this.has("teacher")) {
      this.getCoursesPaging({ page: this.coursePage, limit: this.limit });
    } else {
      this.getSubscribeCourse({ page: this.coursePage, limit: this.limit });
      this.getAllWishList({ page: this.wishListPage, limit: this.limit });
    }
  },
  computed: {
    ...mapState("course", ["subscribeCourses", "wishList"]),
    ...mapState("auth", ["has"]),
  },
  methods: {
    ...mapActions("course", [
      "getCoursesPaging",
      "getAllWishList",
      "getSubscribeCourse",
    ]),
  },
  components: { ChangePassword, DetailAccount, MyCourseList },
};
</script>
