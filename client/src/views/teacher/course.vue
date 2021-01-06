<template>
  <div>
    <navbar />
    <course />
  </div>
</template>

<script>
import navbar from "../../components/navbar/navbar.vue";
import course from "../../components/teacher/course.vue";
export default {
  name: "teacher",
  components: {
    navbar,
    course,
  },
};
</script>

<style>
</style>