<template>
  <v-card>
    <v-divider></v-divider>
    <v-card-text v-if="courses.length > 0">
      <v-row>
        <v-col v-for="course in courses" :key="course.id" cols="4">
          <v-card>
            <template slot="progress">
              <v-progress-linear
                color="deep-purple"
                height="10"
                indeterminate
              ></v-progress-linear>
            </template>

            <v-img
              height="250"
              :src="`https://localhost:5001/courses/${course.id}/images`"
            ></v-img>

            <router-link :to="`/giang-vien/chi-tiet-khoa-hoc/${course.id}`">
              <v-card-title>{{ course.courseName }}</v-card-title>
            </router-link>
          </v-card>
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
</template>

<script>
export default {
  props: {
    courses: Array,
    currentPage: Number,
    length: Number,
    title: String
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
