<template>
  <v-container class="text-left">
    <v-card v-if="courseBySearch.total > 0">
      <v-card-title style="font-size: 40px" class="mb-4">
        <v-row>
          <v-col cols="2">
            <v-select
              outlined
              dense
              v-model="sort"
              :items="sorts"
              item-text="text"
              item-value="value"
              hide-details
              label="Sắp xếp theo"
            ></v-select>
          </v-col>
          <v-col cols="2">
            <v-select
              outlined
              v-model="order"
              label="Tiêu chí"
              :items="orders"
              item-value="value"
              item-text="text"
              hide-details
              dense
            >
            </v-select>
          </v-col>
        </v-row>
      </v-card-title>
      <v-item-group>
        <v-container>
          <v-row>
            <v-col
              cols="4"
              v-for="course in courseBySearch.content"
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
          :length="courseBySearch.nPage"
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
    limit: constant.LIMIT,
    sort: constant.COURSE_SORT.NAME,
    order: constant.COURSE_ORDER.ASCENDING,
    sorts: [
      {
        text: "Tên",
        value: constant.COURSE_SORT.NAME
      },
      {
        text: "Sale",
        value: constant.COURSE_SORT.SALE
      }
    ],
    orders: [
      {
        text: "Tăng dần",
        value: constant.COURSE_ORDER.ASCENDING
      },
      {
        text: "Giảm dần",
        value: constant.COURSE_ORDER.DESCENDING
      }
    ]
  }),
  updated() {},
  watch: {
    sort(val) {
      const search = this.$route.query.search || "";
      this.getCoursesBySearch({
        page: this.page,
        limit: this.limit,
        order: this.order,
        sort: val,
        search
      });
    },
    order(val) {
      const search = this.$route.query.search || "";
      this.getCoursesBySearch({
        page: this.page,
        limit: this.limit,
        order: val,
        sort: this.sort,
        search
      });
    },
    page(val) {
      const search = this.$route.query.search || "";
      this.getCoursesBySearch({
        page: val,
        limit: this.limit,
        order: this.order,
        sort: this.sort,
        search
      });
    },
    $route(to) {
      const search = to.query.search || "";
      this.getCoursesBySearch({
        page: this.page,
        limit: this.limit,
        order: this.order,
        sort: this.sort,
        search
      });
    }
  },
  computed: {
    ...mapState("course", ["courseBySearch"])
  },
  created() {
    const search = this.$route.query.search || "";
    this.getCoursesBySearch({
      page: this.page,
      limit: this.limit,
      order: this.order,
      sort: this.sort,
      search
    });
  },
  methods: {
    ...mapActions("course", ["getCoursesBySearch"])
  }
};
</script>

<style></style>
