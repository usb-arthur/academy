<template>
  <v-container>
    <v-row>
      <v-col cols="12">
        <v-tabs fixed-tabs v-model="tab">
          <v-tab>Thông tin cá nhân</v-tab>
          <v-tab>Khóa học của tôi</v-tab>
          <v-tab>Danh sách yêu thích của tôi</v-tab>
          <v-tab>Đổi mật khẩu</v-tab>
        </v-tabs>
      </v-col>
      <v-col cols="12">
        <v-tabs-items v-model="tab">
          <v-tab-item>
            <DetailAccount></DetailAccount>
          </v-tab-item>
          <v-tab-item>
            <MyCourseList :courses="myCoursesList"></MyCourseList>
          </v-tab-item>
          <v-tab-item>
            <MyCourseList :courses="myWishList"></MyCourseList>
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
import { mapActions, mapState } from "vuex";
export default {
  data: () => ({
    tab: null,
    myCoursesList: [],
    myWishList: []
  }),
  created() {
    this.getAllCourses().then(() => {
      this.myCoursesList = this.courses;
    });
    this.getAllWishList().then(() => {
      this.myWishList = this.wishList;
    });
  },
  computed: {
    ...mapState("course", ["courses", "wishList"])
  },
  methods: {
    ...mapActions("course", ["getAllCourses", "getAllWishList"])
  },
  components: { ChangePassword, DetailAccount, MyCourseList }
};
</script>
