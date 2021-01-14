<template>
  <v-card max-width="550" min-height="550" max-height="550" class="ma-4">
    <v-img
      height="250"
      :src="`https://localhost:5001/courses/${course.id}/images`"
    ></v-img>

    <router-link :to="`/chi-tiet-khoa-hoc/${course.id}`">
      <v-card-title>{{ course.courseName }} </v-card-title>
    </router-link>
    <v-card-subtitle style="padding-top: 0; padding-bottom: 0">
      <v-chip-group
        v-if="course.new || course.bestSeller"
        active-class="deep-purple accent-4 white--text"
        column
      >
        <v-chip color="error" v-if="course.new">Mới</v-chip>
        <v-chip color="primary" v-if="course.bestSeller">Bán chạy</v-chip>
      </v-chip-group>
    </v-card-subtitle>
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
          {{ course.rate }} ({{ course.numOfFeedback }} người đánh giá) và có
          {{ course.numOfStudent }} người theo học
        </div>
      </v-row>
    </v-card-text>

    <v-divider class="my-0 mx-4"></v-divider>

    <v-card-title>
      {{ course.actualPrice | currency }}
      <span v-if="course.sale" class="mx-2 text-decoration-line-through">
        {{ course.courseFee | currency }}
      </span>
      <span class="mx-2" v-if="course.sale"> {{ course.sale }}% </span>
    </v-card-title>

    <v-card-text v-if="course.sale">
      <v-chip-group active-class="deep-purple accent-4 white--text" column>
        <v-chip v-if="course.sale"
          >Thời gian còn lại {{ course.dateLeft }} day(s)</v-chip
        >
      </v-chip-group>
    </v-card-text>
  </v-card>
</template>

<script>
export default {
  props: {
    course: {
      type: Object
    }
  }
};
</script>

<style></style>
