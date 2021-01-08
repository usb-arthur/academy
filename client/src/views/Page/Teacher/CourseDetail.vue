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
                <v-list>
                  <v-list-item
                    :key="courseDetail.id"
                    v-for="courseDetail in courseDetails"
                  >
                    <span>{{ courseDetail.content }}</span>
                    <v-spacer></v-spacer>
                    <v-icon small class="mr-2">mdi-pencil</v-icon>
                    <v-icon @click="removeItem(courseDetail.id)" small>mdi-delete</v-icon>
                  </v-list-item>
                  <v-add-course-detail @handleSuccess="text = 'Thêm nội dung thành công'" @handleError="text = $event"></v-add-course-detail>
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

          <v-card-text>
            <v-chip-group
              v-model="selection"
              active-class="deep-purple accent-4 white--text"
              column
              v-if="course.sale"
            >
              <v-chip>Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip>
            </v-chip-group>
            <v-btn color="primary">Đánh dấu hoàn thành</v-btn>
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
          <v-btn color="blue darken-1" text @click="closeDelete"
          >Không</v-btn
          >
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
import VAddCourseDetail from "@/components/Teacher/vAddCourseDetail";

export default {
  components: { VAddCourseDetail },
  data: () => ({
    loading: false,
    selection: 1,
    dialogDelete: false,
    id: -1,
    text: '',
    snackbar: false
  }),
  watch: {
    text() {
      this.snackbar = true;
    }
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
    }
  },
  created() {
    const { id } = this.$route.params;
    this.getCourseById(id);
    this.getCourseDetailByCourseId(id);
  },
  methods: {
    ...mapActions("course", ["getCourseById", "getCourseDetailByCourseId", "deleteCourseDetail"]),
    closeDelete() {
      this.dialogDelete = false;
      this.$nextTick(() => {
        this.id = -1;
      });
    },
    deleteCourseConfirm() {
      this.deleteCourseDetail({ courseDetailId: this.id, courseId: this.$route.params.id })
        .then(() => {
          this.text = "Thao tác thành công";
          this.closeDelete();
        })
        .catch(err => {
          alert(err)
          this.text =
            err.response.statusText ||
            "Có lỗi xảy ra. Vui lòng liên hệ admin để biết thêm chi tiết";
        });
    },
    removeItem(id) {
      this.id = id;
      this.dialogDelete = true;
    }
  }
};
</script>
