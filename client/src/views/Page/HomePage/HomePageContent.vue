<template>
  <v-main>
    <v-container fluid align-left style="margin-top: 50px">
      <v-row>
        <div style="margin-left: 60px">
          <h2>CÁC KHÓA HỌC NỔI BẬT TRONG TUẦN</h2>
        </div>
      </v-row>

      <v-slide-group class="pa-4">
        <v-slide-item v-for="course in list2[0]" :key="course.id">
          <v-card
            class="ma-4"
            height="300"
            width="450"
            :to="`/chi-tiet-khoa-hoc/${course.id}`"
          >
            <v-img
              height="150"
              width="450"
              src="https://www.nomadfoods.com/wp-content/uploads/2018/08/placeholder-1-e1533569576673-960x960.png"
            ></v-img>
            <v-card-title v-text="course.courseName"></v-card-title>
            <v-card-subtitle class="text-left"
              >Rating: {{ course.rate }} / 10 ({{
                course.numOfFeedback
              }}
              )</v-card-subtitle
            >
            <v-card-text class="text-left">
              <h5>{{ course.courseFee | currency }}</h5>
            </v-card-text>
          </v-card>
        </v-slide-item>
      </v-slide-group>
      <v-row>
        <div style="margin-left: 60px">
          <h2>CÁC KHÓA HỌC ĐƯỢC XEM NHIỀU NHẤT</h2>
        </div>
      </v-row>

      <v-slide-group class="pa-4">
        <v-slide-item v-for="course in list2[1]" :key="course.id">
          <v-card
            class="ma-4"
            height="300"
            width="450"
            :to="`/chi-tiet-khoa-hoc/${course.id}`"
          >
            <v-img
              height="150"
              width="450"
              src="https://www.nomadfoods.com/wp-content/uploads/2018/08/placeholder-1-e1533569576673-960x960.png"
            ></v-img>
            <v-card-title v-text="course.courseName"></v-card-title>
            <v-card-subtitle class="text-left"
              >Rating: {{ course.rate }} / 10 ({{
                course.numOfFeedback
              }}
              )</v-card-subtitle
            >
            <v-card-text>
              <h5 class="text-left">{{ course.courseFee | currency }}</h5>
            </v-card-text>
          </v-card>
        </v-slide-item>
      </v-slide-group>
      <v-row>
        <div style="margin-left: 60px">
          <h2>CÁC KHÓA HỌC MỚI NHẤT</h2>
        </div>
      </v-row>

      <v-slide-group class="pa-4">
        <v-slide-item v-for="course in list2[2]" :key="course.id">
          <v-card
            class="ma-4"
            height="300"
            width="450"
            :to="`/chi-tiet-khoa-hoc/${course.id}`"
          >
            <v-img
              height="150"
              width="450"
              src="https://www.nomadfoods.com/wp-content/uploads/2018/08/placeholder-1-e1533569576673-960x960.png"
            ></v-img>
            <v-card-title v-text="course.courseName"></v-card-title>
            <v-card-subtitle class="text-left"
              >Rating: {{ course.rate }} / 10 ({{
                course.numOfFeedback
              }}
              )</v-card-subtitle
            >
            <v-card-text class="text-left">
              <h5>{{ course.courseFee | currency }}</h5>
            </v-card-text>
          </v-card>
        </v-slide-item>
      </v-slide-group>
      <v-row>
        <div style="margin-left: 60px">
          <h2>CÁC KHÓA HỌC ĐƯỢC ĐĂNG KÝ NHIỀU NHẤT</h2>
        </div>
      </v-row>

      <v-slide-group class="pa-4 stretch">
        <v-slide-item v-for="course in list2[3]" :key="course.id">
          <v-card
            class="ma-4"
            height="300"
            width="450"
            :to="`/chi-tiet-khoa-hoc/${course.id}`"
          >
            <v-img
              height="150"
              width="450"
              src="https://www.nomadfoods.com/wp-content/uploads/2018/08/placeholder-1-e1533569576673-960x960.png"
            ></v-img>
            <v-card-title v-text="course.courseName"></v-card-title>
            <v-card-subtitle class="text-left"
              >Rating: {{ course.rate }} / 10 ({{
                course.numOfFeedback
              }}
              )</v-card-subtitle
            >
            <v-card-text class="text-left">
              <h5>{{ course.courseFee | currency }} VNĐ</h5>
            </v-card-text>
          </v-card>
        </v-slide-item>
      </v-slide-group>
    </v-container>
  </v-main>
</template>

<script>
export default {
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
