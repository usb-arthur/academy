<template>
  <v-card>
    <v-divider></v-divider>
    <v-card-text>
      <v-row>
        <v-col v-for="course in courses" :key="course.id" cols="4">
          <v-card>
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
          </v-card>
        </v-col>
      </v-row>
    </v-card-text>
  </v-card>
</template>

<script>
export default {
  props: {
    courses: Array
  }
};
</script>
