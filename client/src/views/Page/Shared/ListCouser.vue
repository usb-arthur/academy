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
            <v-card>
              <v-img
                :src="`https://localhost:5001/courses/${course.id}/images`"
                height="300"
                class="grey darken-4"
              ></v-img>
              <router-link :to="`/chi-tiet-khoa-hoc/${course.id}`">
                <v-card-title class="title">
                  {{ course.courseName }}
                </v-card-title>
              </router-link>
              <v-card-text>
                <v-row align="center" class="mx-0">
                  <v-rating
                    :value="course.rate / 2"
                    color="amber"
                    dense
                    half-increments
                    readonly
                    size="14"
                  ></v-rating>

                  <div class="grey--text ml-4">
                    {{ course.rate / 2 }} ({{ course.numOfFeedback }} người đánh
                    giá) và có {{ course.numOfStudent }} người theo học
                  </div>
                </v-row>
              </v-card-text>

              <v-divider class="my-0 mx-4"></v-divider>

              <v-card-title>
                {{
                  ((course.courseFee * course.sale) / 100 || course.courseFee)
                    | currency
                }}
                <span v-if="course.sale" class="text-decoration-line-through">
                  {{ course.courseFee | currency }}
                </span>
                <span v-if="course.sale"> {{ course.sale }}% </span>
              </v-card-title>

              <v-card-text>
                <v-chip-group
                  active-class="deep-purple accent-4 white--text"
                  column
                  v-if="course.sale"
                >
                  <v-chip
                    >Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip
                  >
                  <v-chip class="ma-2" color="orange" text-color="white">
                    Đang giảm giá
                  </v-chip>

                  <v-chip class="ma-2" color="primary" text-color="white">
                    Mới
                  </v-chip>
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
    limit: constant.LIMIT
  }),
  updated() {},
  watch: {
    page(val) {
      const { id } = this.$route.params;

      this.getCoursesByCategory({ id, page: val, limit: this.limit });
    }
  },
  computed: {
    ...mapState("course", ["coursesByCategory"])
  },
  created() {
    const { id } = this.$route.params;
    this.getCoursesByCategory({ id, page: this.page, limit: this.limit });
  },
  methods: {
    ...mapActions("course", ["getCoursesByCategory"])
  }
};
</script>

<style></style>
