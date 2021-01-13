<template>
  <v-container class="text-left">
    <v-card-title style="font-size: 40px" class="mb-4">
      Danh sách khóa học
    </v-card-title>
    <v-item-group>
      <v-container>
        <v-row>
          <v-col
            cols="4"
            v-for="course in coursesByCategory.content"
            :key="course.id"
          >
            <v-card max-width="500" max-height="500" class="ma-4">
              <v-img
                height="250"
                :src="`https://localhost:5001/courses/${course.id}/images`"
              ></v-img>

              <router-link :to="`/chi-tiet-khoa-hoc/${course.id}`">
                <v-card-title>{{ course.courseName }}</v-card-title>
              </router-link>
              <v-card-subtitle style="padding-top: 0">
                {{ course.category.categoryName }}
              </v-card-subtitle>

              <v-card-text>
                <v-row align="center" class="mx-0">
                  <v-rating
                    :value="course.rate"
                    color="amber"
                    dense
                    half-increments
                    readonly
                    size="14"
                  ></v-rating>

                  <div class="grey--text ml-4">
                    {{ course.rate }} ({{ course.numOfFeedback }} người đánh
                    giá) và có {{ course.numOfStudent }} người theo học
                  </div>
                </v-row>
              </v-card-text>

              <v-divider class="my-0 mx-4"></v-divider>

              <v-card-title>
                {{ course.actualPrice | currency }}
                <span
                  v-if="course.sale"
                  class="mx-2 text-decoration-line-through"
                >
                  {{ course.courseFee | currency }}
                </span>
                <span class="mx-2" v-if="course.sale">
                  {{ course.sale }}%
                </span>
              </v-card-title>

              <v-card-text v-if="course.sale">
                <v-chip-group
                  active-class="deep-purple accent-4 white--text"
                  column
                >
                  <v-chip
                    >Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip
                  >
                </v-chip-group>
              </v-card-text>
            </v-card>
          </v-col>
        </v-row>
      </v-container>
    </v-item-group>
    <div class="text-center mt-6">
      <v-pagination
        v-model="page"
        :length="coursesByCategory.nPage"
      ></v-pagination>
    </div>
  </v-container>
</template>

<script>
import { mapActions, mapState } from "vuex";
import constant from "@/constants";

export default {
  data: () => ({
    page: 1,
    limit: constant.LIMIT,
  }),
  updated() {},
  watch: {
    page(val) {
      const { id } = this.$route.params;

      this.getCoursesByCategory({ id, page: val, limit: this.limit });
    },
    $route(to) {
      const { id } = to.params;
      this.getCoursesByCategory({ id, page: this.page, limit: this.limit });
    },
  },
  computed: {
    ...mapState("course", ["coursesByCategory"]),
  },
  created() {
    const { id } = this.$route.params;
    this.getCoursesByCategory({ id, page: this.page, limit: this.limit });
  },
  methods: {
    ...mapActions("course", ["getCoursesByCategory"]),
  },
};
</script>

<style></style>
