<template>
  <v-card>
    <v-card-title>
      Nội dung khóa học
    </v-card-title>
    <v-card-text>
      <v-list>
        <v-list-item
          :key="courseDetail.id"
          v-for="courseDetail in courseDetails"
        >
          <span>{{ courseDetail.content }}</span>
          <v-spacer></v-spacer>
          <v-icon
            v-if="teacher || courseDetail.isReview"
            @click="detail(courseDetail.id)"
            small
            class="mr-2"
            >mdi-eye</v-icon
          >
          <v-icon v-if="teacher" @click="removeItem(courseDetail.id)" small
            >mdi-delete</v-icon
          >
        </v-list-item>
        <v-add-course-detail
          v-if="teacher"
          @handleSuccess="text = 'Thêm nội dung thành công'"
          @handleError="text = $event"
        ></v-add-course-detail>
      </v-list>
    </v-card-text>
  </v-card>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  data: () => ({
    text: ""
  }),
  props: {
    teacher: {
      type: Boolean
    }
  },
  computed: {
    ...mapState("course", ["courseDetails"])
  },
  watch: {
    text(val) {
      this.$emit("handleCreate", val);
    }
  },
  created() {
    const { id } = this.$route.params;
    this.getCourseDetailByCourseId(id);
  },
  methods: {
    ...mapActions("course", ["getCourseDetailByCourseId"]),
    removeItem(id) {
      this.$emit("handleRemove", id);
    },
    detail(id) {
      this.$emit("handleViewClick", id);
    }
  }
};
</script>
