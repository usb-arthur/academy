<template>
  <v-container class="text-left">
    <v-card v-if="coursesByCategory.total > 0">
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
          <v-col cols="5" offset="3">
            <v-text-field
              outlined
              dense
              v-model="search"
              @keyup.enter="handleSearch(search)"
              label="Tìm kiếm"
            ></v-text-field>
          </v-col>
        </v-row>
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
    limit: constant.LIMIT,
    sort: constant.COURSE_SORT.NAME,
    order: constant.COURSE_ORDER.ASCENDING,
    search: "",
    sorts: [
      {
        text: "Tên",
        value: constant.COURSE_SORT.NAME,
      },
      {
        text: "Giá",
        value: constant.COURSE_SORT.PRICE,
      },
      {
        text: "Sale",
        value: constant.COURSE_SORT.SALE,
      },
      {
        text: "Lượt xem",
        value: constant.COURSE_SORT.VIEW,
      },
    ],
    orders: [
      {
        text: "Tăng dần",
        value: constant.COURSE_ORDER.ASCENDING,
      },
      {
        text: "Giảm dần",
        value: constant.COURSE_ORDER.DESCENDING,
      },
    ],
  }),
  updated() {},
  watch: {
    sort(val) {
      const { id } = this.$route.params;
      const search = this.$route.query.search || "";
      this.getCoursesByCategory({
        id,
        page: this.page,
        limit: this.limit,
        order: this.order,
        sort: val,
        search,
      });
    },
    order(val) {
      console.log(val);
      const { id } = this.$route.params;
      const search = this.$route.query.search || "";
      this.getCoursesByCategory({
        id,
        page: this.page,
        limit: this.limit,
        order: val,
        sort: this.sort,
        search,
      });
    },
    page(val) {
      const { id } = this.$route.params;
      const search = this.$route.query.search || "";
      this.getCoursesByCategory({
        id,
        page: val,
        limit: this.limit,
        order: this.order,
        sort: this.sort,
        search,
      });
    },
    $route(to) {
      const { id } = to.params;
      const search = to.query.search || "";
      this.getCoursesByCategory({
        id,
        page: this.page,
        limit: this.limit,
        order: this.order,
        sort: this.sort,
        search,
      });
    },
  },
  computed: {
    ...mapState("course", ["coursesByCategory"]),
  },
  created() {
    const { id } = this.$route.params;
    const search = this.$route.query.search || "";
    console.log(search);
    this.getCoursesByCategory({
      id,
      page: this.page,
      limit: this.limit,
      order: this.order,
      sort: this.sort,
      search,
    });
  },
  methods: {
    ...mapActions("course", ["getCoursesByCategory"]),
    handleSearch(search) {
      this.$router.push({ query: { search } });
    },
  },
};
</script>

<style></style>
