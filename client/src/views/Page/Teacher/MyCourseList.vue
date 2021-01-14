<template>
  <v-container class="text-left">
    <v-card>
      <v-divider></v-divider>
      <v-card-text v-if="courses && courses.length > 0">
        <v-row>
          <v-col v-for="course in courses" :key="course.id" cols="4">
            <v-course-detail
              :wishList="wishList"
              :course="course"
              :page="currentPage"
            ></v-course-detail>
          </v-col>
        </v-row>
      </v-card-text>
      <v-card-text v-else>
        <h1>Bạn hiện đang không có {{ title }} nào</h1>
      </v-card-text>
      <v-pagination
        v-if="courses.length > 0"
        v-model="page"
        :length="length"
      ></v-pagination>
    </v-card>
  </v-container>
</template>

<script>
import vCourseDetail from "../../../components/Course/vCourseDetail.vue";
export default {
  components: { vCourseDetail },
  props: {
    courses: Array,
    currentPage: Number,
    length: Number,
    title: String,
    wishList: {
      type: Boolean,
      default: false
    }
  },
  watch: {
    page(val) {
      this.$emit("pageChange", val);
    }
  },
  data: () => ({
    page: 0
  }),
  created() {
    this.page = this.currentPage;
  }
};
</script>
