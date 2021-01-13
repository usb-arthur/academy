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
          <v-card max-width="500" max-height="500" class="ma-4">
            <v-img
              height="250"
              :src="`https://localhost:5001/courses/${course.id}/images`"
            ></v-img>

            <router-link :to="`/chi-tiet-khoa-hoc/${course.id}`">
              <v-card-title>{{ course.courseName }}</v-card-title>
            </router-link>
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
                  {{ course.rate }} ({{ course.numOfFeedback }} người đánh giá)
                  và có {{ course.numOfStudent }} người theo học
                </div>
              </v-row>
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
              <span class="mx-2" v-if="course.sale"> {{ course.sale }}% </span>
            </v-card-title>

            <v-card-text v-if="course.sale">
              <v-chip-group
                active-class="deep-purple accent-4 white--text"
                column
              >
                <v-chip>Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip>
              </v-chip-group>
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
          <v-card max-width="500" max-height="500" class="ma-4">
            <v-img
              height="250"
              :src="`https://localhost:5001/courses/${course.id}/images`"
            ></v-img>

            <router-link :to="`/chi-tiet-khoa-hoc/${course.id}`">
              <v-card-title>{{ course.courseName }}</v-card-title>
            </router-link>
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
                  {{ course.rate }} ({{ course.numOfFeedback }} người đánh giá)
                  và có {{ course.numOfStudent }} người theo học
                </div>
              </v-row>
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
              <span class="mx-2" v-if="course.sale"> {{ course.sale }}% </span>
            </v-card-title>

            <v-card-text v-if="course.sale">
              <v-chip-group
                active-class="deep-purple accent-4 white--text"
                column
              >
                <v-chip>Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip>
              </v-chip-group>
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
          <v-card max-width="500" max-height="500" class="ma-4">
            <v-img
              height="250"
              :src="`https://localhost:5001/courses/${course.id}/images`"
            ></v-img>

            <router-link :to="`/chi-tiet-khoa-hoc/${course.id}`">
              <v-card-title>{{ course.courseName }}</v-card-title>
            </router-link>
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
                  {{ course.rate }} ({{ course.numOfFeedback }} người đánh giá)
                  và có {{ course.numOfStudent }} người theo học
                </div>
              </v-row>
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
              <span class="mx-2" v-if="course.sale"> {{ course.sale }}% </span>
            </v-card-title>

            <v-card-text v-if="course.sale">
              <v-chip-group
                active-class="deep-purple accent-4 white--text"
                column
              >
                <v-chip>Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip>
              </v-chip-group>
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
          <v-card max-width="500" max-height="500" class="ma-4">
            <v-img
              height="250"
              :src="`https://localhost:5001/courses/${course.id}/images`"
            ></v-img>

            <router-link :to="`/chi-tiet-khoa-hoc/${course.id}`">
              <v-card-title>{{ course.courseName }}</v-card-title>
            </router-link>
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
                  {{ course.rate }} ({{ course.numOfFeedback }} người đánh giá)
                  và có {{ course.numOfStudent }} người theo học
                </div>
              </v-row>
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
              <span class="mx-2" v-if="course.sale"> {{ course.sale }}% </span>
            </v-card-title>

            <v-card-text v-if="course.sale">
              <v-chip-group
                active-class="deep-purple accent-4 white--text"
                column
              >
                <v-chip>Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip>
              </v-chip-group>
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
      list2: [],
    };
  },
  computed: {
    dsCourse() {
      return this.$store.state.khoahoc.items;
    },
  },
  methods: {},
  async created() {
    for (let i = 0; i < 4; i++) {
      let temp = null;
      await this.$store
        .dispatch("khoahoc/GetStaticsCourse", {
          Payload: 10,
          Criteria: i,
        })
        .then(() => {
          temp = this.dsCourse;
          this.list2.push(temp);
        })
        .catch((err) => console.log(err));
    }
    console.log(this.list2);
  },
};
</script>

<style></style>
