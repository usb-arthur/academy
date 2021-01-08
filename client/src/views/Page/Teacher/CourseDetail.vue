<template>
  <v-container class="text-left">
    <v-row>
      <v-col cols="6">
        <v-row>
          <v-col cols="12">
            <v-card>
              <v-card-title>Mô tả khóa học</v-card-title>
              <v-card-text v-html="course.detailDescription"></v-card-text>
            </v-card>
          </v-col>
          <v-col cols="12">
            <v-card>
              <v-card-title>
                Nội dung khóa học
              </v-card-title>
              <v-card-text>
                <v-list-item-group>
                  <v-list-item
                    :key="courseDetail.id"
                    v-for="courseDetail in courseDetails"
                  >
                    <span>{{ courseDetail.content }}</span>
                    <v-spacer></v-spacer>
                    <span v-if="courseDetail.isReview">Xem trước</span>
                  </v-list-item>
                  <v-add-course-detail></v-add-course-detail>
                </v-list-item-group>
              </v-card-text>
            </v-card>
          </v-col>
        </v-row>
      </v-col>
      <v-col cols="6">
        <v-card
          :loading="loading"
          max-width="600"
          class="mx-auto position-fixed"
        >
          <template slot="progress">
            <v-progress-linear
              color="deep-purple"
              height="10"
              indeterminate
            ></v-progress-linear>
          </template>

          <v-img
            height="250"
            src="https://cdn.vuetifyjs.com/images/cards/cooking.png"
          ></v-img>

          <v-card-title>{{ course.courseName }}</v-card-title>

          <v-card-text>
            <v-row align="center" class="mx-0">
              <v-rating
                :value="rate"
                color="amber"
                dense
                half-increments
                readonly
                size="14"
              ></v-rating>

              <div class="grey--text ml-4">
                {{ rate }} ({{ numOfFeedback }} người đánh giá) và có
                {{ numOfStudent }} người theo học
              </div>
            </v-row>

            <div class="my-4 subtitle-1">
              {{ course.briefDescription }}
            </div>
          </v-card-text>

          <v-divider class="my-0 mx-4"></v-divider>

          <v-card-title>
            {{ price | currency }}
            <span v-if="course.sale" class="text-decoration-line-through">
              {{ course.courseFee | currency }}
            </span>
            <span v-if="course.sale"> {{ course.sale }}% </span>
          </v-card-title>

          <v-card-text v-if="course.sale">
            <v-chip-group
              v-model="selection"
              active-class="deep-purple accent-4 white--text"
              column
            >
              <v-chip>Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip>
            </v-chip-group>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import { mapActions, mapState } from "vuex";
import VAddCourseDetail from "@/components/Teacher/vAddCourseDetail";

export default {
  components: { VAddCourseDetail },
  data: () => ({
    loading: false,
    selection: 1
  }),
  computed: {
    ...mapState("course", ["course", "courseDetails"]),
    rate() {
      return this.course.rate / 2 || 0;
    },
    numOfFeedback() {
      return this.course.numOfFeedback || 0;
    },
    numOfStudent() {
      return this.course.numOfStudent || 0;
    },
    price() {
      return (
        (this.course.courseFee * this.course.sale) / 100 ||
        this.course.courseFee
      );
    }
  },
  created() {
    const { id } = this.$route.params;
    this.getCourseById(id);
    this.getCourseDetailByCourseId(id);
  },
  methods: {
    ...mapActions("course", ["getCourseById", "getCourseDetailByCourseId"]),
    reserve() {
      this.loadi  ng = true;

      setTimeout(() => (this.loading = false), 2000);
    }
  }
};
</script>
