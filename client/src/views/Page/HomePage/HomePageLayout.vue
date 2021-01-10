<template>
  <div>
    <v-app>
      <NavBar />
      <PageContent />
    </v-app>
  </div>
</template>

<script>
import NavBar from "../../../components/NavBar/NavBar.vue";
import PageContent from "./HomePageContent.vue";
export default {
  components: {
    NavBar,
    PageContent
  }
};
</script>
