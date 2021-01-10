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
            <v-card color="content-course">
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
                  </v-list-item>
                </v-list>
              </v-card-text>
            </v-card>
          </v-col>
          <v-col cols="12">
            <v-card class="content-detail">
              <v-card-title> Giới thiệu giảng viên </v-card-title>
              <div class="grey--text ml-4">
                <div class="row">
                  <div class="col-3">
                    <span class="title-detail-teacher">Tên giảng viên:</span>
                  </div>
                  <div class="col-9">
                    <span class="content-teacher">{{ course.user.name }}</span>
                  </div>
                </div>
              </div>
              <div class="grey--text ml-4">
                <div class="row">
                  <div class="col-3">
                    <span class="title-detail-teacher">Số điện thoại:</span>
                  </div>
                  <div class="col-9">
                    <span class="content-teacher">{{
                      course.user.phoneNumber
                    }}</span>
                  </div>
                </div>
              </div>
              <div class="grey--text ml-4">
                <div class="row">
                  <div class="col-3">
                    <span class="title-detail-teacher">Email:</span>
                  </div>
                  <div class="col-9">
                    <span class="content-teacher">{{ course.user.email }}</span>
                  </div>
                </div>
              </div>
              <div class="grey--text ml-4">
                <div class="row">
                  <div class="col-3">
                    <span class="title-detail-teacher">Giới tính:</span>
                  </div>
                  <div class="col-9">
                    <span class="content-teacher">{{
                      course.user.gender
                    }}</span>
                  </div>
                </div>
              </div>
            </v-card>
          </v-col>
          <v-col cols="12">
            <v-card class="content-cmt">
              <v-card-title> Bình luận </v-card-title>
              <div class="grey--text ml-4">
                <div
                  class="box-cmt"
                  v-for="feedback in feedbacks"
                  :key="feedback.id"
                >
                  <div class="mt-2 ml-2">
                    <span class="box-cmt-name">{{
                      feedback.student.name
                    }}</span>
                  </div>
                  <div class="mt-2 ml-2">
                    <v-rating
                      :value="feedback.rate / 2"
                      color="amber"
                      dense
                      half-increments
                      readonly
                      size="14"
                    ></v-rating>
                  </div>
                  <div class="mt-2 ml-2">
                    <span class="box-cmt-content">
                      {{ feedback.content }}
                    </span>
                  </div>
                </div>
              </div>
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
            {{ price | currency }}
            <span v-if="course.sale" class="text-decoration-line-through">
              {{ course.courseFee | currency }}
            </span>
            <span v-if="course.sale"> {{ course.sale }}% </span>
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

export default {
  data: () => ({
    loading: false,
    selection: 1,
    dialogDelete: false,
    id: -1,
    text: "",
    snackbar: false,
    video: false,
  }),
  updated() {},
  watch: {
    text() {
      this.snackbar = true;
    },
  },
  computed: {
    ...mapState("course", ["course", "courseDetails"]),
    ...mapState("feedback", ["feedbacks"]),
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
    this.getFeedbacksByCourseId(id);
  },
  methods: {
    ...mapActions("course", [
      "getCourseById",
      "getCourseDetailByCourseId",
      "deleteCourseDetail",
    ]),
    ...mapActions("feedback", ["getFeedbacksByCourseId"]),
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
  },
};
</script>

<style>
.play-pause-layer {
  display: none !important;
}
.content-course {
  height: 350px;
  overflow: auto;
}
.content-detail {
  height: 220px;
}
.content-cmt {
  height: 450px;
}
.title-detail-teacher {
  color: #333;
}
.content-teacher {
  font-weight: 700;
  color: #000000a3;
}
.box-cmt {
  height: 100%;
  width: 100%;
  padding-right: 20px;
  margin-bottom: 20px;
}
.box-cmt-name {
  font-weight: 700;
  line-height: 1.2;
  letter-spacing: -0.02rem;
  font-size: 1rem;
}
.box-cmt-content {
  font-size: 0.8rem;
  font-weight: 400;
}
</style>
