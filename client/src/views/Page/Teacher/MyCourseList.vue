<template>
  <v-card>
    <v-card-title>Các khóa học của tôi</v-card-title>
    <v-divider></v-divider>
    <v-card-text>
      <v-row>
        <v-carousel cycle hide-delimiter-background show-arrows-on-hover>
          <v-carousel-item v-for="course in courses" :key="course.id">
            <v-sheet height="100%">
              <v-card min-width="700">
                <template slot="progress">
                  <v-progress-linear
                    color="deep-purple"
                    height="10"
                    indeterminate
                  ></v-progress-linear>
                </template>

                <v-img
                  height="250"
                  :src="`https://localhost:5001/courses/${course.id}/images`"
                ></v-img>

                <v-card-title>{{ course.courseName }}</v-card-title>
                <v-card-text>
                  <div class="my-4 subtitle-1">
                    {{ course.briefDescription }}
                  </div>
                </v-card-text>
              </v-card>
            </v-sheet>
          </v-carousel-item>
        </v-carousel>
      </v-row>
    </v-card-text>
  </v-card>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  created() {
    this.getAllCourses();
  },
  computed: {
    ...mapState("course", ["courses"])
  },
  methods: {
    ...mapActions("course", ["getAllCourses"])
  }
};
</script>
