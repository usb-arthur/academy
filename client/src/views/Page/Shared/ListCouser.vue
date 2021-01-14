<template>
  <v-container class="text-left">
    <v-card v-if="coursesByCategory.total > 0">
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
              <v-course-detail :course="course"></v-course-detail>
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
    </v-card>
    <v-card v-else class="text-center">
      <v-card-text>
        <h1>Không có khoá học nào trong lĩnh vực này</h1>
      </v-card-text>
    </v-card>
  </v-container>
</template>

<script>
import { mapActions, mapState } from "vuex";
import constant from "@/constants";
import vCourseDetail from "../../../components/Course/vCourseDetail.vue";

export default {
  components: { vCourseDetail },
  data: () => ({
    page: 1,
    limit: constant.LIMIT
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
