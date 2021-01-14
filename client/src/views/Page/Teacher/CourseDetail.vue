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
              <v-card-title> Nội dung khóa học </v-card-title>
              <v-card-text>
                <v-list>
                  <v-list-item
                    :key="courseDetail.id"
                    v-for="courseDetail in courseDetails"
                  >
                    <span>{{ courseDetail.content }}</span>
                    <v-spacer></v-spacer>
                    <v-dialog
                      transition="dialog-bottom-transition"
                      max-width="900"
                    >
                      <template v-slot:activator="{ on, attrs }">
                        <v-icon v-bind="attrs" v-on="on" small class="mr-2"
                          >mdi-eye</v-icon
                        >
                      </template>
                      <template v-slot:default="dialog">
                        <v-container fluid>
                          <v-row>
                            <v-col cols="12">
                              <vue-core-video-player
                                type="video/webm"
                                ref="videoPlayer"
                                :src="`https://localhost:5001/course-details/${courseDetail.id}/videos`"
                              ></vue-core-video-player>
                            </v-col>
                          </v-row>
                          <v-btn
                            class="mt-2"
                            block
                            @click="dialog.value = closeDialog()"
                            >Đóng</v-btn
                          >
                        </v-container>
                      </template>
                    </v-dialog>
                    <v-icon @click="removeItem(courseDetail.id)" small
                      >mdi-delete</v-icon
                    >
                  </v-list-item>
                  <v-add-course-detail
                    @handleSuccess="text = 'Thêm nội dung thành công'"
                    @handleError="text = $event"
                  ></v-add-course-detail>
                </v-list>
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
            :src="`https://localhost:5001/courses/${$route.params.id}/images`"
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
            {{ course.actualPrice | currency }}
            <span v-if="course.sale" class="mx-2 text-decoration-line-through">
              {{ course.courseFee | currency }}
            </span>
            <span class="mx-2" v-if="course.sale"> {{ course.sale }}% </span>
          </v-card-title>

          <v-card-text>
            <v-chip-group
              v-model="selection"
              active-class="deep-purple accent-4 white--text"
              column
              v-if="course.sale"
            >
              <v-chip>Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip>
            </v-chip-group>
            <v-btn
              v-if="course.courseStatus === courseStatus.INCOMPLETE"
              block
              @click="handleComplete(course.id, courseStatus.COMPLETED)"
              class="mt-2"
              color="primary"
              >Đánh dấu hoàn thành</v-btn
            >
            <v-btn
              v-if="course.courseStatus === courseStatus.COMPLETED"
              block
              @click="handleComplete(course.id, courseStatus.INCOMPLETE)"
              class="mt-2"
              color="primary"
              >Đánh dấu chưa hoàn thành</v-btn
            >
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
    <v-dialog v-model="dialogDelete" max-width="540px">
      <v-card>
        <v-card-title class="headline"
          >Bạn có chắc chắn muốn xóa nội dung này?</v-card-title
        >
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue darken-1" text @click="closeDelete">Không</v-btn>
          <v-btn color="blue darken-1" text @click="deleteCourseConfirm"
            >Có</v-btn
          >
          <v-spacer></v-spacer>
        </v-card-actions>
      </v-card>
    </v-dialog>
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
import { mapActions, mapState } from "vuex";
import constant from "@/constants";
import VAddCourseDetail from "@/components/Teacher/vAddCourseDetail";

export default {
  components: { VAddCourseDetail },
  data: () => ({
    loading: false,
    selection: 1,
    dialogDelete: false,
    id: -1,
    text: "",
    snackbar: false,
    video: false,
    courseStatus: constant.COURSE_STATUS,
  }),
  updated() {},
  watch: {
    text(val) {
      if (!this.snackbar && val != "") {
        this.snackbar = true;
      }
    },
    snackbar(val) {
      if (!val) {
        this.text = "";
      }
    },
  },
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
    },
    player() {
      return this.$refs.videoPlayer;
    },
  },
  created() {
    const { id } = this.$route.params;
    this.getCourseById(id);
    this.getCourseDetailByCourseId(id);
  },
  methods: {
    ...mapActions("course", [
      "getCourseById",
      "getCourseDetailByCourseId",
      "deleteCourseDetail",
      "patchCourseStatus",
    ]),
    closeDialog() {
      if (this.$refs.videoPlayer) {
        this.$refs.videoPlayer = this.$refs.videoPlayer.map((e) => {
          e.isPlaying = false;
          e.pause();
          return e;
        });
      }
    },
    closeDelete() {
      this.dialogDelete = false;
      this.$nextTick(() => {
        this.id = -1;
      });
    },
    deleteCourseConfirm() {
      this.deleteCourseDetail({
        courseDetailId: this.id,
        courseId: this.$route.params.id,
      })
        .then(() => {
          this.text = "Thao tác thành công";
          this.closeDelete();
        })
        .catch((err) => {
          alert(err);
          this.text =
            err.response.statusText ||
            "Có lỗi xảy ra. Vui lòng liên hệ admin để biết thêm chi tiết";
        });
    },
    removeItem(id) {
      this.id = id;
      this.dialogDelete = true;
    },
    handleComplete(courseId, courseStatus) {
      this.patchCourseStatus({ id: courseId, status: courseStatus })
        .then((res) => {
          this.text = `Khoá học này đã được đánh dấu ${res.data.objResult.status.toLowerCase()}`;
        })
        .catch((err) => (this.text = err.response.data.message));
    },
  },
};
</script>

<style>
.play-pause-layer {
  display: none !important;
}
</style>
