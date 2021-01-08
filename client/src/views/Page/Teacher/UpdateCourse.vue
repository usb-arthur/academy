<template>
  <v-container class="text-left">
    <v-form v-model="valid">
      <v-container>
        <v-row>
          <v-col cols="4">
            <v-text-field
              v-model="course.courseName"
              required
              label="Tên khóa học"
            >
            </v-text-field>
          </v-col>
          <v-col cols="4">
            <v-text-field
              type="number"
              v-model="course.courseFee"
              required
              label="Giá khóa học"
            >
            </v-text-field>
          </v-col>
          <v-col cols="4">
            <v-file-input
              v-model="image"
              show-size
              accept="image/png, image/jpeg, image/bmp"
              label="Chọn hình ảnh"
            ></v-file-input>
          </v-col>
          <v-col cols="12">
            <v-textarea
              rows="3"
              v-model="course.briefDescription"
              required
              label="Mô tả ngắn gọn khóa học"
            ></v-textarea>
          </v-col>
          <v-col cols="12">
            <v-tip-tap v-model="course.detailDescription"></v-tip-tap>
          </v-col>
          <v-col cols="12">
            <v-checkbox
              class="sale"
              v-model="hasSale"
              label="Có giảm giá?"
            ></v-checkbox>
          </v-col>
          <v-col cols="6" v-show="hasSale">
            <v-text-field
              v-model="course.sale"
              type="number"
              label="Giảm"
            ></v-text-field>
          </v-col>
          <v-col cols="6" v-show="hasSale">
            <v-text-field
              v-model="course.saleDate"
              type="date"
              label="Ngày giảm"
            ></v-text-field>
          </v-col>
          <v-col cols="12" class="text-right">
            <router-link to="/giang-vien/khoa-hoc">
              <v-btn color="success" class="mr-4">
                Quay lại
              </v-btn>
            </router-link>

            <v-btn
              @click="updateCourse($route.params.id, course)"
              color="primary"
            >
              Cập nhật
            </v-btn>
          </v-col>
        </v-row>
      </v-container>
    </v-form>
  </v-container>
</template>

<script>
import { mapActions, mapState } from "vuex";
import vTipTap from "@/components/WYSIWYG/vTipTap";

export default {
  data: () => ({
    hasSale: false,
    valid: false,
    video: null,
    image: null
  }),
  computed: {
    ...mapState("course", ["course"])
  },
  created() {
    console.log(this.$route.params);
    const { id } = this.$route.params;
    this.getCourseById(id);
  },
  methods: {
    ...mapActions("course", ["getCourseById", "updateCourseById"]),
    updateCourse(id, course) {
      this.updateCourseById({ id, course }).then(() => {
        this.$router.push("/giang-vien/khoa-hoc");
      });
    }
  },
  components: {
    vTipTap
  }
};
</script>
