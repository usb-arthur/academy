<template>
  <v-card max-width="600" min-height="600" max-height="600" class="ma-4">
    <v-img
      height="250"
      :src="`https://localhost:5001/courses/${course.id}/images`"
    ></v-img>

    <router-link :to="`/chi-tiet-khoa-hoc/${course.id}`">
      <v-card-title>{{ course.courseName }} </v-card-title>
    </router-link>
    <v-card-subtitle style="padding-top: 0; padding-bottom: 0">
      <v-chip-group
        v-if="course.new || course.bestSeller"
        active-class="deep-purple accent-4 white--text"
        column
      >
        <v-chip color="error" v-if="course.new">Mới</v-chip>
        <v-chip color="primary" v-if="course.bestSeller">Bán chạy</v-chip>
      </v-chip-group>
    </v-card-subtitle>
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
          {{ course.rate }} ({{ course.numOfFeedback }} người đánh giá) và có
          {{ course.numOfStudent }} người theo học
        </div>
      </v-row>
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
        v-if="course.sale"
        active-class="deep-purple accent-4 white--text"
        column
      >
        <v-chip v-if="course.sale"
          >Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip
        >
      </v-chip-group>
      <v-btn
        @click="handleRemove(course.id)"
        class="mt-3"
        v-if="wishList"
        block
        color="error"
        >Xoá khỏi danh sách yêu thích</v-btn
      >
    </v-card-text>
    <v-snackbar v-model="snackbar" timeout="2000">
      {{ text }}
      <template v-slot:action="{ attrs }">
        <v-btn color="blue" text v-bind="attrs" @click="snackbar = false">
          Đóng
        </v-btn>
      </template>
    </v-snackbar>
  </v-card>
</template>

<script>
import { mapActions } from "vuex";
export default {
  props: {
    course: {
      type: Object
    },
    wishList: {
      type: Boolean,
      default: false
    },
    page: {
      type: Number,
      default: 1
    }
  },
  data: () => ({
    text: "",
    snackbar: ""
  }),
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
    }
  },
  methods: {
    ...mapActions("course", ["removeWishList"]),
    handleRemove(id) {
      this.removeWishList({ id, page: this.page })
        .then(() => {
          this.text =
            "Thành công xoá khoá học này ra khỏi danh sách yêu thích của bạn";
        })
        .catch(err => {
          this.text = err.response.data.message;
        });
    }
  }
};
</script>

<style></style>
