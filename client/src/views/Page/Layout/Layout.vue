<template>
  <v-app>
    <!-- <v-app-bar app absolute elevate-on-scroll scroll-target="#main">
      <v-app-bar-nav-icon @click="drawer = true"></v-app-bar-nav-icon>
      <v-toolbar-title>Giảng viên</v-toolbar-title>
      <v-spacer></v-spacer>
      <v-btn icon>
        <v-icon>mdi-heart</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>mdi-dots-vertical</v-icon>
      </v-btn>
    </v-app-bar>
    <v-navigation-drawer absolute temporary v-model="drawer">
      <v-list>
        <router-link to="/">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-home</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Home</v-list-item-title>
          </v-list-item>
        </router-link>
        <router-link to="/thong-tin-ca-nhan">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-account</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Tài khoản</v-list-item-title>
          </v-list-item>
        </router-link>
        <router-link to="/giang-vien/khoa-hoc">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-account</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Courses</v-list-item-title>
          </v-list-item>
        </router-link>
      </v-list>
    </v-navigation-drawer> -->
    <navbar />
    <v-main id="main">
      <router-view></router-view>
    </v-main>
  </v-app>
</template>

<script>
import navbar from "../../../components/NavBar/vNavBar.vue";
export default {
  data: () => ({
    drawer: false,
    group: null
  }),
  components: {
    navbar
  }
};
</script>
