<template>
  <v-main>
    <v-container fluid align-left class="text-left" style="margin-top: 50px">
      <v-row>
        <div style="margin-left: 60px">
          <h2>CÁC KHÓA HỌC NỔI BẬT TRONG TUẦN</h2>
        </div>
      </v-row>

      <v-slide-group class="pa-4">
        <v-slide-item v-for="course in list2[0]" :key="course.id">
          <v-course-detail :course="course"></v-course-detail>
        </v-slide-item>
      </v-slide-group>
      <v-row>
        <div style="margin-left: 60px">
          <h2>CÁC KHÓA HỌC ĐƯỢC XEM NHIỀU NHẤT</h2>
        </div>
      </v-row>

      <v-slide-group class="pa-4">
        <v-slide-item v-for="course in list2[1]" :key="course.id">
          <v-course-detail :course="course"></v-course-detail>
        </v-slide-item>
      </v-slide-group>
      <v-row>
        <div style="margin-left: 60px">
          <h2>CÁC KHÓA HỌC MỚI NHẤT</h2>
        </div>
      </v-row>

      <v-slide-group class="pa-4">
        <v-slide-item v-for="course in list2[2]" :key="course.id">
          <v-course-detail :course="course"></v-course-detail>
        </v-slide-item>
      </v-slide-group>
      <v-row>
        <div style="margin-left: 60px">
          <h2>CÁC KHÓA HỌC ĐƯỢC ĐĂNG KÝ NHIỀU NHẤT</h2>
        </div>
      </v-row>

      <v-slide-group class="pa-4 stretch">
        <v-slide-item v-for="course in list2[3]" :key="course.id">
          <v-course-detail :course="course"></v-course-detail>
        </v-slide-item>
      </v-slide-group>
    </v-container>
  </v-main>
</template>

<script>
import vCourseDetail from "../../../components/Course/vCourseDetail.vue";
export default {
  components: { vCourseDetail },
  data() {
    return {
      list2: []
    };
  },
  computed: {
    dsCourse() {
      return this.$store.state.khoahoc.items;
    }
  },
  methods: {},
  async created() {
    for (let i = 0; i < 4; i++) {
      let temp = null;
      await this.$store
        .dispatch("khoahoc/GetStaticsCourse", {
          Payload: 10,
          Criteria: i
        })
        .then(() => {
          temp = this.dsCourse;
          this.list2.push(temp);
        })
        .catch(err => console.log(err));
    }
    console.log(this.list2);
  }
};
</script>

<style></style>
