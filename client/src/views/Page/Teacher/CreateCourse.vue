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
              v-model="course.image"
              show-size
              accept="image/jpeg"
              label="Chọn hình ảnh"
            ></v-file-input>
          </v-col>
          <v-col cols="6">
            <v-select
              :items="categories"
              item-text="categoryName"
              item-value="id"
              v-model="categoryId"
              label="Chọn danh mục cha"
              dense
            ></v-select>
          </v-col>
          <v-col cols="6">
            <v-select
              :items="children(categoryId)"
              item-text="categoryName"
              item-value="id"
              v-model="course.categoryId"
              label="Chọn danh mục con"
              dense
            ></v-select>
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

            <v-btn @click="createCourse(course)" color="primary">
              Tạo mới
            </v-btn>
          </v-col>
        </v-row>
      </v-container>
    </v-form>
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
import VTipTap from "@/components/WYSIWYG/vTipTap";
import { mapState, mapActions, mapGetters } from "vuex";

export default {
  components: { VTipTap },
  data: () => ({
    hasSale: false,
    valid: false,
    snackbar: false,
    text: "",
    course: {
      courseName: "",
      courseFee: 0,
      briefDescription: "",
      detailDescription: "",
      categoryId: 0,
      sale: null,
      saleDate: null,
      image: null
    },
    video: null,
    categoryId: 0
  }),
  watch: {
    hasSale(val) {
      if (!val) {
        this.course.sale = this.course.saleDate = null;
      }
    },
    text() {
      this.snackbar = true;
    }
  },
  computed: {
    ...mapState("categories", ["categories"]),
    ...mapGetters("categories", ["children"])
  },
  created() {
    this.getAllCategories();
  },
  methods: {
    ...mapActions("categories", ["getAllCategories"]),
    ...mapActions("course", ["createNewCourse"]),
    createCourse(course) {
      this.createNewCourse(course)
        .then(() => {
          this.$router.push("/giang-vien");
        })
        .catch(err => {
          this.text =
            err.response.data.message ||
            "Có lỗi xảy ra. Vui lòng liên hệ admin để biết thêm chi tiết";
        });
    }
  }
};
</script>

<style>
.sale .v-input__control .v-input__slot label {
  margin-bottom: 0 !important;
}
</style>
