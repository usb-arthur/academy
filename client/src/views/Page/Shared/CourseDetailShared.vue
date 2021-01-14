<template>
  <v-container class="text-left">
    <v-row>
      <v-col cols="6">
        <v-row>
          <v-col cols="12">
            <v-card color="content-course">
              <v-card-title>
                <span>Nội dung khóa học</span> <v-spacer></v-spacer
                ><v-icon @click="refresh()">refresh</v-icon></v-card-title
              >
              <v-card-text>
                <v-list>
                  <v-list-item
                    :key="courseDetail.id"
                    v-for="courseDetail in courseDetails"
                  >
                    <v-icon v-if="courseDetail.done" class="mr-2">
                      check_circle_outline
                    </v-icon>
                    <v-icon v-else class="mr-2">error_outline</v-icon>
                    <span>{{ courseDetail.content }}</span>

                    <v-spacer></v-spacer>
                    <v-dialog
                      v-if="isInCourse || courseDetail.isReview"
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
                                :src="
                                  `https://localhost:5001/course-details/${courseDetail.id}/videos`
                                "
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
              <v-card-text>
                <div class="grey--text ml-4">
                  <v-row v-if="isInCourse">
                    <v-col cols="7">
                      <v-text-field
                        outlined
                        flat
                        v-model="feedbackSend.content"
                        dense
                        label="Cảm nghĩ của bạn về khoá học này"
                      ></v-text-field>
                    </v-col>
                    <v-col cols="3">
                      <v-select
                        :items="rating"
                        item-value="value"
                        item-text="text"
                        outlined
                        v-model="feedbackSend.rate"
                        flat
                        dense
                        label="Đánh giá"
                      ></v-select>
                    </v-col>
                    <v-col cols="2">
                      <v-btn
                        @click="sendFeedback(feedbackSend)"
                        block
                        color="primary"
                        >Gửi</v-btn
                      >
                    </v-col>
                  </v-row>
                  <div style=""
                    class="box-cmt"
                    v-for="(feedback, index) in feedbacks"
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
                    <v-divider v-if="index != feedbacks.length - 1"></v-divider>
                  </div>
                </div>
              </v-card-text>
            </v-card>
          </v-col>
        </v-row>
      </v-col>
      <v-col cols="6">
        <v-row>
          <v-col cols="12">
            <v-card :loading="loading">
              <template slot="progress">
                <v-progress-linear
                  color="deep-purple"
                  height="10"
                  indeterminate
                ></v-progress-linear>
              </template>

              <v-img
                height="250"
                :src="
                  `https://localhost:5001/courses/${$route.params.id}/images`
                "
              ></v-img>

              <div class="d-flex justify-content-between">
                <v-card-title>{{ course.courseName }}</v-card-title>
                <div class="mt-3 mr-4">
                  <v-btn @click="handleAddToWishList(course.id)" icon>
                    <v-icon>mdi-heart</v-icon>
                  </v-btn>
                </div>
              </div>
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
                <span
                  v-if="course.sale"
                  class="mx-2 text-decoration-line-through"
                >
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
                  <v-chip
                    >Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip
                  > </v-chip-group
                ><v-btn
                  v-if="!isInCourse"
                  block
                  color="primary"
                  @click="handleRegisterCourse(course.id)"
                  >Tham gia khoá học</v-btn
                >
              </v-card-text>
            </v-card>
          </v-col>
          <v-col cols="12">
            <v-card>
              <v-card-title>Mô tả khóa học</v-card-title>
              <v-card-text v-html="course.detailDescription"></v-card-text>
            </v-card>
          </v-col>
        </v-row>
      </v-col>
      <v-col cols="12">
        <v-card>
          <v-card-title>
            <h1>Các khoá học tương tự</h1>
          </v-card-title>
          <v-card-text>
            <v-slide-group class="pa-4">
              <v-slide-item v-for="course in relativeCourse" :key="course.id">
                <v-course-detail :course="course"></v-course-detail>
              </v-slide-item>
            </v-slide-group>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
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
import vCourseDetail from "../../../components/Course/vCourseDetail.vue";

export default {
  components: { vCourseDetail },
  data: () => ({
    loading: false,
    selection: 1,
    dialog: false,
    id: -1,
    text: "",
    snackbar: false,
    video: false,
    rating: [
      {
        value: 0,
        text: "Quá tệ (0)"
      },
      {
        value: 1,
        text: "Tệ (1)"
      },
      {
        value: 2,
        text: "Bình thường (2)"
      },
      {
        value: 3,
        text: "Tạm được (3)"
      },
      {
        value: 4,
        text: "Tốt (4)"
      },
      {
        value: 5,
        text: "Rất tốt (5)"
      }
    ],
    feedbackSend: {
      content: "",
      rate: -1
    }
  }),
  updated() {},
  watch: {
    $route(to) {
      const { id } = to.params;
      this.getIsInCourse(id);
      this.feedbackSend.courseId = id;
      this.getCourseById(id).then(res => {
        this.getRelativeCourse({
          courseId: id,
          categoryId: res.data.objResult.category.id
        });
      });
      this.getCourseDetailByCourseId(id);
      this.getFeedbacksByCourseId(id);
    },
    text(val) {
      if (!this.snackbar && val != "") {
        this.snackbar = true;
      }
    },
    snackbar(val) {
      if (!val) {
        this.text = "";
      }
    }
  },
  computed: {
    ...mapState("auth", ["isAuthenticated"]),
    ...mapState("course", [
      "course",
      "courseDetails",
      "isInCourse",
      "relativeCourse"
    ]),
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
    }
  },
  created() {
    const { id } = this.$route.params;
    this.getIsInCourse(id);
    this.feedbackSend.courseId = id;
    this.getCourseById(id).then(res => {
      this.getRelativeCourse({
        courseId: id,
        categoryId: res.data.objResult.category.id
      });
    });
    this.getCourseDetailByCourseId(id);
    this.getFeedbacksByCourseId(id);
  },
  methods: {
    ...mapActions("course", [
      "getCourseById",
      "getCourseDetailByCourseId",
      "deleteCourseDetail",
      "addToWishList",
      "getIsInCourse",
      "getRelativeCourse",
      "registerCourse"
    ]),
    ...mapActions("feedback", ["getFeedbacksByCourseId", "createFeedback"]),
    closeDialog() {
      if (this.$refs.videoPlayer) {
        this.$refs.videoPlayer = this.$refs.videoPlayer.map(e => {
          e.isPlaying = false;
          e.pause();
          return e;
        });
      }
    },
    refresh() {
      const { id } = this.$route.params;
      this.getIsInCourse(id);
      this.feedbackSend.courseId = id;
      this.getCourseById(id).then(res => {
        this.getRelativeCourse({
          courseId: id,
          categoryId: res.data.objResult.category.id
        });
      });
      this.getCourseDetailByCourseId(id);
      this.getFeedbacksByCourseId(id);
    },
    sendFeedback(feedback) {
      this.createFeedback(feedback)
        .then(() => {
          this.text = "Thêm đánh giá thành công";
          this.feedbackSend.content = "";
          this.feedbackSend.rate = -1;
        })
        .catch(err => (this.text = err.response.data.message));
    },
    handleAddToWishList(coursId) {
      this.addToWishList(coursId)
        .then(() => {
          this.text = "Thêm vào danh sách yêu thích";
        })
        .catch(err => {
          this.text = err.response.data.message;
        });
    },
    handleRegisterCourse(id) {
      this.registerCourse(id)
        .then(() => {
          this.text = "Đăng ký thành công";
        })
        .catch(err => {
          this.text = err.response.data.message;
        });
    }
  }
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
  overflow: auto;
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
  color: #333;
}
</style>
